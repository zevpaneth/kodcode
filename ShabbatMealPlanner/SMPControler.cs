using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ShabbatMealPlanner
{
    internal class SMPControler
    {
        public static void AddCategory(string Name)
        {
            string categoryName = Name;
            string sql = $"IF NOT EXISTS (SELECT 1 FROM Categories WHERE CategoryName=@CategoryName) BEGIN INSERT INTO Categories (CategoryName) VALUES (@CategoryName) END";

            string[] parameters = { "@CategoryName" };
            string[] values = { categoryName };

            string result = DBConnection.runSQL(sql, parameters, values);


        }

        public static void AddGuest(string Name)
        {
            
            string sql = $"IF NOT EXISTS (SELECT 1 FROM Guests WHERE GuestName=@GuestName) BEGIN INSERT INTO Guests (GuestName) VALUES (@GuestName) END";

            string[] parameters = { "@GuestName" };
            string[] values = { Name };

            string result = DBConnection.runSQL(sql, parameters, values);
        }

        internal static void AddDish(string Name, int GuestID, int CategoryID)
        {
            string dishName = Name;
            string sql = $"IF NOT EXISTS (SELECT 1 FROM DishOrders WHERE  DishName=@DishName) BEGIN INSERT INTO DishOrders (DishName, GuestID, CategoryID) VALUES (@DishName, @GuestID, @CategoryID) END";

            string[] parameters = { "@DishName", "@GuestID", "@CategoryID" };
            object[] values = { dishName , GuestID , CategoryID};

            string result = DBConnection.runSQL(sql, parameters, values);
        }

        public static void RemoveCategory(string Name) { }

        public static List<string> GetAdedCatgories()
        {
            string sql = "SELECT * FROM Categories ORDER BY CategoryID";
            SqlDataReader readr = DBConnection.runSQL2(sql);
            List<string> categories = new List<string>();

            for (int i = 0; readr.Read(); i++)
            {
                categories.Add(readr.GetString(1));
            }
            return categories;
        }




        public static List<string> CategrySearchFilter(string filter)
        {
            string sql = "SELECT CategoryName FROM Categories WHERE CategoryName LIKE '%' + @filter + '%'";

            string[] parameters = { "@filter" };
            string[] values = { filter };
            SqlDataReader readr = DBConnection.runSQL2(sql, parameters, values);
            List<string> categories = new List<string>();

             while (readr.Read()) 
            {
                categories.Add(readr.GetString(0));
            }
            return categories;
        }

        public static List<string> GuestSearchFilter(string filter) {
            string sql = "SELECT GuestName FROM Guests WHERE GuestName LIKE '%' + @filter + '%'";

            string[] parameters = { "@filter" };
            string[] values = { filter };
            SqlDataReader readr = DBConnection.runSQL2(sql, parameters, values);
            List<string> guests = new List<string>();

            while (readr.Read())
            {
                guests.Add(readr.GetString(0));
            }
            return guests;
        }

        public static DataTable GetTable()
        {
            string sql = "SELECT * FROM Categories, Guests";

            DataTable table = DBConnection.RunSQLTable(sql);
            
            return table;
        }

        internal static List<string> UpdateFoodName(string foodName)
        {
            string sql = "SELECT CategoryName FROM Categories WHERE CategoryName = @CategoryName";
            return null;
        }

        internal static DataTable GetDishes(string lblFoodType)
        {
            string sql = "SELECT DishName AS Name, COUNT(DishName) AS Calculation FROM DishOrders\r\nJOIN Categories ON Categories.CategoryID = DishOrders.CategoryName\r\nWHERE Categories.CategoryName = @categoryName\r\nGROUP BY DishName;";

            string[] parameters = { "@categoryName" };
            string[] values = { lblFoodType };
            return DBConnection.RunSQLTable(sql, parameters, values);
        }

        internal static List<string> GetCategories()
        {
            string sql = "SELECT CategoryName FROM Categories";
            SqlDataReader reader = DBConnection.runSQL2(sql);
            List<string> categories = new List<string>();

            for (int i = 0; reader.Read(); i++)
            {
                categories.Add(reader.GetString(0));
            }
            reader.Close();
            return categories;
        }

        
    }
}

