namespace CoffeeShopApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblName = new Label();
            txtName = new TextBox();
            dataGridView1 = new DataGridView();
            Name = new DataGridViewTextBoxColumn();
            Sugar = new DataGridViewTextBoxColumn();
            Cofee = new DataGridViewTextBoxColumn();
            Milk = new DataGridViewTextBoxColumn();
            Cocoa = new DataGridViewTextBoxColumn();
            lblSugar = new Label();
            lblCofee = new Label();
            lblMilk = new Label();
            lblCocoa = new Label();
            numCocoa = new NumericUpDown();
            numMilk = new NumericUpDown();
            numCofee = new NumericUpDown();
            numSugar = new NumericUpDown();
            lblPrice = new Label();
            txtPrice = new TextBox();
            btnPlus = new Button();
            btnMinus = new Button();
            btnAdd = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCocoa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMilk).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCofee).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSugar).BeginInit();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(47, 69);
            lblName.Name = "lblName";
            lblName.Size = new Size(104, 20);
            lblName.TabIndex = 0;
            lblName.Text = "Name of drink";
            // 
            // txtName
            // 
            txtName.Location = new Point(206, 62);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Name, Sugar, Cofee, Milk, Cocoa });
            dataGridView1.Location = new Point(47, 253);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(680, 307);
            dataGridView1.TabIndex = 2;
            // 
            // Name
            // 
            Name.HeaderText = "Name";
            Name.MinimumWidth = 6;
            Name.Name = "Name";
            Name.Width = 125;
            // 
            // Sugar
            // 
            Sugar.HeaderText = "Sugar";
            Sugar.MinimumWidth = 6;
            Sugar.Name = "Sugar";
            Sugar.Width = 125;
            // 
            // Cofee
            // 
            Cofee.HeaderText = "Cofee";
            Cofee.MinimumWidth = 6;
            Cofee.Name = "Cofee";
            Cofee.Width = 125;
            // 
            // Milk
            // 
            Milk.HeaderText = "Milk";
            Milk.MinimumWidth = 6;
            Milk.Name = "Milk";
            Milk.Width = 125;
            // 
            // Cocoa
            // 
            Cocoa.HeaderText = "Cocoa";
            Cocoa.MinimumWidth = 6;
            Cocoa.Name = "Cocoa";
            Cocoa.Width = 125;
            // 
            // lblSugar
            // 
            lblSugar.AutoSize = true;
            lblSugar.Location = new Point(105, 145);
            lblSugar.Name = "lblSugar";
            lblSugar.Size = new Size(47, 20);
            lblSugar.TabIndex = 3;
            lblSugar.Text = "Sugar";
            // 
            // lblCofee
            // 
            lblCofee.AutoSize = true;
            lblCofee.Location = new Point(231, 145);
            lblCofee.Name = "lblCofee";
            lblCofee.Size = new Size(48, 20);
            lblCofee.TabIndex = 4;
            lblCofee.Text = "Cofee";
            // 
            // lblMilk
            // 
            lblMilk.AutoSize = true;
            lblMilk.Location = new Point(352, 145);
            lblMilk.Name = "lblMilk";
            lblMilk.Size = new Size(37, 20);
            lblMilk.TabIndex = 5;
            lblMilk.Text = "Milk";
            // 
            // lblCocoa
            // 
            lblCocoa.AutoSize = true;
            lblCocoa.Location = new Point(477, 145);
            lblCocoa.Name = "lblCocoa";
            lblCocoa.Size = new Size(51, 20);
            lblCocoa.TabIndex = 0;
            lblCocoa.Text = "Cocoa";
            // 
            // numCocoa
            // 
            numCocoa.Location = new Point(477, 188);
            numCocoa.Name = "numCocoa";
            numCocoa.Size = new Size(48, 27);
            numCocoa.TabIndex = 6;
            // 
            // numMilk
            // 
            numMilk.Location = new Point(352, 188);
            numMilk.Name = "numMilk";
            numMilk.Size = new Size(48, 27);
            numMilk.TabIndex = 7;
            // 
            // numCofee
            // 
            numCofee.Location = new Point(231, 188);
            numCofee.Name = "numCofee";
            numCofee.Size = new Size(48, 27);
            numCofee.TabIndex = 8;
            // 
            // numSugar
            // 
            numSugar.Location = new Point(104, 188);
            numSugar.Name = "numSugar";
            numSugar.Size = new Size(48, 27);
            numSugar.TabIndex = 9;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(635, 145);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(41, 20);
            lblPrice.TabIndex = 10;
            lblPrice.Text = "Price";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(602, 188);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(102, 27);
            txtPrice.TabIndex = 11;
            // 
            // btnPlus
            // 
            btnPlus.Location = new Point(730, 163);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(32, 29);
            btnPlus.TabIndex = 12;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            // 
            // btnMinus
            // 
            btnMinus.Location = new Point(730, 211);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(32, 29);
            btnMinus.TabIndex = 13;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(844, 92);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 14;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(844, 163);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(844, 326);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 16;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(988, 595);
            Controls.Add(btnSave);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(btnMinus);
            Controls.Add(btnPlus);
            Controls.Add(txtPrice);
            Controls.Add(lblPrice);
            Controls.Add(numSugar);
            Controls.Add(numCofee);
            Controls.Add(numMilk);
            Controls.Add(numCocoa);
            Controls.Add(lblCocoa);
            Controls.Add(lblMilk);
            Controls.Add(lblCofee);
            Controls.Add(lblSugar);
            Controls.Add(dataGridView1);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCocoa).EndInit();
            ((System.ComponentModel.ISupportInitialize)numMilk).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCofee).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSugar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private TextBox txtName;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Sugar;
        private DataGridViewTextBoxColumn Cofee;
        private DataGridViewTextBoxColumn Milk;
        private DataGridViewTextBoxColumn Cocoa;
        private Label lblSugar;
        private Label lblCofee;
        private Label lblMilk;
        private Label lblCocoa;
        private NumericUpDown numCocoa;
        private NumericUpDown numMilk;
        private NumericUpDown numCofee;
        private NumericUpDown numSugar;
        private Label lblPrice;
        private TextBox txtPrice;
        private Button btnPlus;
        private Button btnMinus;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnSave;
    }
}
