using System.Windows.Forms;

namespace ShabbatMealPlanner
{
    partial class Guest
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.TextBox txtGuestName;
        private System.Windows.Forms.ListBox lstGuest;
        private System.Windows.Forms.Button btnConfirm;

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.txtGuestName = new System.Windows.Forms.TextBox();
            this.lstGuest = new System.Windows.Forms.ListBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(240, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(280, 20);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Welcome";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInstruction
            // 
            this.lblInstruction.Location = new System.Drawing.Point(240, 63);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(280, 20);
            this.lblInstruction.TabIndex = 1;
            this.lblInstruction.Text = "Enter Guest Name";
            this.lblInstruction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtGuestName
            // 
            this.txtGuestName.ForeColor = System.Drawing.Color.Gray;
            this.txtGuestName.Location = new System.Drawing.Point(243, 111);
            this.txtGuestName.Name = "txtGuestName";
            this.txtGuestName.Size = new System.Drawing.Size(280, 22);
            this.txtGuestName.TabIndex = 2;
            this.txtGuestName.Text = "Type here...";
            this.txtGuestName.TextChanged += new System.EventHandler(this.txtGuestName_TextChanged);
            this.txtGuestName.Enter += new System.EventHandler(this.TxtGuestName_Enter);
            this.txtGuestName.Leave += new System.EventHandler(this.TxtGuestName_Leave);
            // 
            // lstGuest
            // 
            this.lstGuest.FormattingEnabled = true;
            this.lstGuest.ItemHeight = 16;
            this.lstGuest.Location = new System.Drawing.Point(290, 183);
            this.lstGuest.Name = "lstGuest";
            this.lstGuest.Size = new System.Drawing.Size(180, 116);
            this.lstGuest.TabIndex = 3;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(311, 353);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(138, 23);
            this.btnConfirm.TabIndex = 4;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // Guest
            // 
            this.ClientSize = new System.Drawing.Size(736, 421);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lstGuest);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblInstruction);
            this.Controls.Add(this.txtGuestName);
            this.Name = "Guest";
            this.Text = "Guest Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        
    }
}