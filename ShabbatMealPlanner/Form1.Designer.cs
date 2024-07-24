namespace ShabbatMealPlanner
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblHostSection = new System.Windows.Forms.Label();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.lblGuestSection = new System.Windows.Forms.Label();
            this.txtGuestName = new System.Windows.Forms.TextBox();
            this.btnRegisterGuest = new System.Windows.Forms.Button();
            this.lblPreferences = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.txtDishName = new System.Windows.Forms.TextBox();
            this.btnAddPreference = new System.Windows.Forms.Button();
            this.columnGuest = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDish = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnShowOrder = new System.Windows.Forms.Button();
            this.lstAdedCategories = new System.Windows.Forms.ListBox();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHostSection
            // 
            this.lblHostSection.AutoSize = true;
            this.lblHostSection.Location = new System.Drawing.Point(16, 11);
            this.lblHostSection.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHostSection.Name = "lblHostSection";
            this.lblHostSection.Size = new System.Drawing.Size(83, 16);
            this.lblHostSection.TabIndex = 0;
            this.lblHostSection.Text = "Host Section";
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(20, 31);
            this.txtCategoryName.Margin = new System.Windows.Forms.Padding(4);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(265, 22);
            this.txtCategoryName.TabIndex = 1;
            this.txtCategoryName.TextChanged += new System.EventHandler(this.txtCategoryName_TextChanged);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Location = new System.Drawing.Point(295, 28);
            this.btnAddCategory.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(124, 28);
            this.btnAddCategory.TabIndex = 2;
            this.btnAddCategory.Text = "Add Category";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // lblGuestSection
            // 
            this.lblGuestSection.AutoSize = true;
            this.lblGuestSection.Location = new System.Drawing.Point(16, 70);
            this.lblGuestSection.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGuestSection.Name = "lblGuestSection";
            this.lblGuestSection.Size = new System.Drawing.Size(90, 16);
            this.lblGuestSection.TabIndex = 3;
            this.lblGuestSection.Text = "Guest Section";
            // 
            // txtGuestName
            // 
            this.txtGuestName.Location = new System.Drawing.Point(20, 90);
            this.txtGuestName.Margin = new System.Windows.Forms.Padding(4);
            this.txtGuestName.Name = "txtGuestName";
            this.txtGuestName.Size = new System.Drawing.Size(265, 22);
            this.txtGuestName.TabIndex = 4;
            // 
            // btnRegisterGuest
            // 
            this.btnRegisterGuest.Location = new System.Drawing.Point(295, 87);
            this.btnRegisterGuest.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegisterGuest.Name = "btnRegisterGuest";
            this.btnRegisterGuest.Size = new System.Drawing.Size(124, 28);
            this.btnRegisterGuest.TabIndex = 5;
            this.btnRegisterGuest.Text = "Register Guest";
            this.btnRegisterGuest.UseVisualStyleBackColor = true;
            this.btnRegisterGuest.Click += new System.EventHandler(this.btnRegisterGuest_Click);
            // 
            // lblPreferences
            // 
            this.lblPreferences.AutoSize = true;
            this.lblPreferences.Location = new System.Drawing.Point(16, 129);
            this.lblPreferences.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPreferences.Name = "lblPreferences";
            this.lblPreferences.Size = new System.Drawing.Size(113, 16);
            this.lblPreferences.TabIndex = 6;
            this.lblPreferences.Text = "Meal Preferences";
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(20, 149);
            this.cmbCategory.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(265, 24);
            this.cmbCategory.TabIndex = 7;
            // 
            // txtDishName
            // 
            this.txtDishName.Location = new System.Drawing.Point(20, 182);
            this.txtDishName.Margin = new System.Windows.Forms.Padding(4);
            this.txtDishName.Name = "txtDishName";
            this.txtDishName.Size = new System.Drawing.Size(265, 22);
            this.txtDishName.TabIndex = 8;
            // 
            // btnAddPreference
            // 
            this.btnAddPreference.Location = new System.Drawing.Point(295, 180);
            this.btnAddPreference.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddPreference.Name = "btnAddPreference";
            this.btnAddPreference.Size = new System.Drawing.Size(124, 28);
            this.btnAddPreference.TabIndex = 9;
            this.btnAddPreference.Text = "Add Preference";
            this.btnAddPreference.UseVisualStyleBackColor = true;
            this.btnAddPreference.Click += new System.EventHandler(this.btnAddPreference_Click);
            // 
            // btnShowOrder
            // 
            this.btnShowOrder.Location = new System.Drawing.Point(457, 28);
            this.btnShowOrder.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowOrder.Name = "btnShowOrder";
            this.btnShowOrder.Size = new System.Drawing.Size(168, 28);
            this.btnShowOrder.TabIndex = 11;
            this.btnShowOrder.Text = "View aded categories\r\n";
            this.btnShowOrder.UseVisualStyleBackColor = true;
            this.btnShowOrder.Click += new System.EventHandler(this.btnShowOrder_Click);
            // 
            // lstAdedCategories
            // 
            this.lstAdedCategories.FormattingEnabled = true;
            this.lstAdedCategories.ItemHeight = 16;
            this.lstAdedCategories.Location = new System.Drawing.Point(718, 28);
            this.lstAdedCategories.Name = "lstAdedCategories";
            this.lstAdedCategories.Size = new System.Drawing.Size(274, 164);
            this.lstAdedCategories.TabIndex = 12;
            // 
            // dgvOrders
            // 
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Location = new System.Drawing.Point(20, 231);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.RowHeadersWidth = 51;
            this.dgvOrders.RowTemplate.Height = 24;
            this.dgvOrders.Size = new System.Drawing.Size(972, 311);
            this.dgvOrders.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 581);
            this.Controls.Add(this.dgvOrders);
            this.Controls.Add(this.lstAdedCategories);
            this.Controls.Add(this.btnShowOrder);
            this.Controls.Add(this.btnAddPreference);
            this.Controls.Add(this.txtDishName);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.lblPreferences);
            this.Controls.Add(this.btnRegisterGuest);
            this.Controls.Add(this.txtGuestName);
            this.Controls.Add(this.lblGuestSection);
            this.Controls.Add(this.btnAddCategory);
            this.Controls.Add(this.txtCategoryName);
            this.Controls.Add(this.lblHostSection);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Shabbat Meal Planner";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHostSection;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.Label lblGuestSection;
        private System.Windows.Forms.TextBox txtGuestName;
        private System.Windows.Forms.Button btnRegisterGuest;
        private System.Windows.Forms.Label lblPreferences;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.TextBox txtDishName;
        private System.Windows.Forms.Button btnAddPreference;
        private System.Windows.Forms.ColumnHeader columnGuest;
        private System.Windows.Forms.ColumnHeader columnCategory;
        private System.Windows.Forms.ColumnHeader columnDish;
        private System.Windows.Forms.Button btnShowOrder;
        private System.Windows.Forms.ListBox lstAdedCategories;
        private System.Windows.Forms.DataGridView dgvOrders;
    }
}