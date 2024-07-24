using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Windows.Forms;

namespace ShabbatMealPlanner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            string categoryName = txtCategoryName.Text;
            SMPControler.AddCategory(categoryName);
            txtCategoryName.Clear();
        }

        private void btnRegisterGuest_Click(object sender, EventArgs e)
        {
            string guestName = txtGuestName.Text;
            SMPControler.AddGuest(guestName);
            txtGuestName.Clear();
        }

        private void btnAddPreference_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> Categories = SMPControler.GetAdedCatgories();

            foreach (string category in Categories)
            {
                lstAdedCategories.Items.Add(category);
                //columnCategory.Text += category;
            }

            LoadOrdersIntoDataGridView();
        }

        private void txtCategoryName_TextChanged(object sender, EventArgs e)
        {
            string filter = txtCategoryName.Text;
            List<string> Categories = SMPControler.CategrySearchFilter(filter);
            lstAdedCategories.Items.Clear();
            foreach (string category in Categories)
            {
                lstAdedCategories.Items.Add(category);
            }

        }

        private void LoadOrdersIntoDataGridView()
        {
            dgvOrders.DataSource = SMPControler.GetTable();

        }

        private void btnShowOrder_Click(object sender, EventArgs e)
        {
            List<OrderSummary> orderSummaries = new List<OrderSummary>();
            List<string> categories = SMPControler.GetCategories();
            for (int i = 0; i < categories.Count; i++)
            {
                orderSummaries.Add(new OrderSummary(orderSummaries, i, categories[i]));
            }
            orderSummaries.First().Show();
        }
    }
}