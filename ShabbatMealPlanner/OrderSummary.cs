using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ShabbatMealPlanner
{
    public partial class OrderSummary : Form
    {
        public List<OrderSummary> OrderSummaries { get; set; }
        public int OrderId { get; set; }
        public OrderSummary(List<OrderSummary> orderSummaries, int orderiD, string categoryName)
        {
            InitializeComponent();
            OrderSummaries = orderSummaries;
            OrderId = orderiD;
            this.lblFoodType.Text = categoryName;
        }

        private void OrderSummary_Load(object sender, EventArgs e)
        {
            dgvDishes.DataSource = SMPControler.GetDishes(lblFoodType.Text);
        }


        private void btnForward_Click(object sender, EventArgs e)
        {
            // Handle forward button click here
        }

        private void btnBackward_Click(object sender, EventArgs e)
        {

        }

        private void lblFoodType_Click(object sender, EventArgs e)
        {

        }
    }
}