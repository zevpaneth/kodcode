using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShabbatMealPlanner
{
    public partial class CategoryEditor : Form
    {
        public CategoryEditor()
        {
            InitializeComponent();
        }

        

        private void dgvOtherGuests_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void txtDishName_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnAddDish_Click(object sender, EventArgs e)
        {
            string dishName = txtDishName.Text;
            int guestID = SMPControler.GetGuestID();
            int categoryID = SMPControler.GetCategoryID();
            SMPControler.AddDish(dishName, guestID, categoryID);
            txtDishName.Clear();
        }
    }
}
