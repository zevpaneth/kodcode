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
    public partial class Guest : Form
    {
        public Guest()
        {
            InitializeComponent();
        }

        private void txtGuestName_TextChanged(object sender, EventArgs e)
        {
            string filter = txtGuestName.Text;
            List<string> guests = SMPControler.GuestSearchFilter(filter);
            lstGuest.Items.Clear();
            foreach (string guest in guests)
            {
                lstGuest.Items.Add(guest);
            }
        }

        private void BtnConfirm_Click(object sender, System.EventArgs e)
        {
            CategoryEditor categoryEditor = new CategoryEditor();

            if (string.IsNullOrWhiteSpace(txtGuestName.Text) || txtGuestName.Text == "Type here...")
            {


                MessageBox.Show("Please enter a guest name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                string GuestName = txtGuestName.Text;
                SMPControler.AddGuest(GuestName);
                txtGuestName.Clear();

                MessageBox.Show("Guest confirmed!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                categoryEditor.Show(int guestID, int categoryID);
            }


        }

        private void TxtGuestName_Enter(object sender, System.EventArgs e)
        {
            if (txtGuestName.Text == "Type here...")
            {
                txtGuestName.Text = "";
                txtGuestName.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void TxtGuestName_Leave(object sender, System.EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtGuestName.Text))
            {
                txtGuestName.Text = "Type here...";
                txtGuestName.ForeColor = System.Drawing.Color.Gray;
            }
        }
    }
}
