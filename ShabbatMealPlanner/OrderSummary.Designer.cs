namespace ShabbatMealPlanner
{
    partial class OrderSummary : System.Windows.Forms.Form
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.dgvDishes = new System.Windows.Forms.DataGridView();
            this.lblFoodType = new System.Windows.Forms.Label();
            this.btnBackward = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDishes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDishes
            // 
            this.dgvDishes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDishes.Location = new System.Drawing.Point(187, 121);
            this.dgvDishes.Name = "dgvDishes";
            this.dgvDishes.RowHeadersWidth = 51;
            this.dgvDishes.RowTemplate.Height = 24;
            this.dgvDishes.Size = new System.Drawing.Size(337, 200);
            this.dgvDishes.TabIndex = 0;
            // 
            // lblFoodType
            // 
            this.lblFoodType.AutoSize = true;
            this.lblFoodType.Location = new System.Drawing.Point(299, 61);
            this.lblFoodType.Name = "lblFoodType";
            this.lblFoodType.Size = new System.Drawing.Size(74, 16);
            this.lblFoodType.TabIndex = 1;
            this.lblFoodType.Text = "Food Type";
            this.lblFoodType.Click += new System.EventHandler(this.lblFoodType_Click);
            // 
            // btnBackward
            // 
            this.btnBackward.Location = new System.Drawing.Point(187, 360);
            this.btnBackward.Name = "btnBackward";
            this.btnBackward.Size = new System.Drawing.Size(75, 23);
            this.btnBackward.TabIndex = 2;
            this.btnBackward.Text = "Backward";
            this.btnBackward.UseVisualStyleBackColor = true;
            this.btnBackward.Click += new System.EventHandler(this.btnBackward_Click);
            // 
            // btnForward
            // 
            this.btnForward.Location = new System.Drawing.Point(449, 360);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(75, 23);
            this.btnForward.TabIndex = 3;
            this.btnForward.Text = "Forward";
            this.btnForward.UseVisualStyleBackColor = true;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // OrderSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnForward);
            this.Controls.Add(this.btnBackward);
            this.Controls.Add(this.lblFoodType);
            this.Controls.Add(this.dgvDishes);
            this.Name = "OrderSummary";
            this.Text = "Order Summary";
            this.Load += new System.EventHandler(this.OrderSummary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDishes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDishes;
        private System.Windows.Forms.Label lblFoodType;
        private System.Windows.Forms.Button btnBackward;
        private System.Windows.Forms.Button btnForward;
    }
}