namespace employee
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdbFermale = new System.Windows.Forms.RadioButton();
            this.rdbMale = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.rdbWidower = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.rdbSingle = new System.Windows.Forms.RadioButton();
            this.rdbMarried = new System.Windows.Forms.RadioButton();
            this.rdbDivorcee = new System.Windows.Forms.RadioButton();
            this.lblHouseNumber = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblCallNumber = new System.Windows.Forms.Label();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtCallNumber = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.txtHouseNumber = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnAddition = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearchByCode = new System.Windows.Forms.Button();
            this.btnSearchById = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Aharoni", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(313, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "רשימת עובדים";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(3, 0);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(26, 16);
            this.lblAge.TabIndex = 1;
            this.lblAge.Text = "גיל";
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(109, 0);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(76, 16);
            this.lblBirthDate.TabIndex = 2;
            this.lblBirthDate.Text = "תאריך לידה";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(315, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(54, 16);
            this.lblFirstName.TabIndex = 3;
            this.lblFirstName.Text = "שם פרטי";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(421, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(67, 16);
            this.lblLastName.TabIndex = 4;
            this.lblLastName.Text = "שם משפחה";
            // 
            // lblId
            // 
            this.lblId.AllowDrop = true;
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(527, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(67, 16);
            this.lblId.TabIndex = 5;
            this.lblId.Text = "מספר זהות";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(633, 0);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(27, 16);
            this.lblCode.TabIndex = 6;
            this.lblCode.Text = "קוד";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(3, 53);
            this.txtAge.Name = "txtAge";
            this.txtAge.ReadOnly = true;
            this.txtAge.Size = new System.Drawing.Size(100, 22);
            this.txtAge.TabIndex = 7;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(527, 53);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 22);
            this.txtId.TabIndex = 8;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(421, 53);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 22);
            this.txtLastName.TabIndex = 9;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(315, 53);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 22);
            this.txtFirstName.TabIndex = 10;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(633, 53);
            this.txtCode.Name = "txtCode";
            this.txtCode.ReadOnly = true;
            this.txtCode.Size = new System.Drawing.Size(100, 22);
            this.txtCode.TabIndex = 12;
            this.txtCode.Text = "456";
            this.txtCode.TextChanged += new System.EventHandler(this.txtCode_TextChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.lblAge, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtCode, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtAge, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblCode, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtId, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblId, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtLastName, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtFirstName, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblLastName, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblBirthDate, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblFirstName, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.dtpBirthDate, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(28, 89);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(738, 100);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Location = new System.Drawing.Point(109, 53);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(200, 22);
            this.dtpBirthDate.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdbFermale);
            this.panel1.Controls.Add(this.rdbMale);
            this.panel1.Location = new System.Drawing.Point(442, 226);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 240);
            this.panel1.TabIndex = 16;
            // 
            // rdbFermale
            // 
            this.rdbFermale.AutoSize = true;
            this.rdbFermale.Location = new System.Drawing.Point(50, 129);
            this.rdbFermale.Name = "rdbFermale";
            this.rdbFermale.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdbFermale.Size = new System.Drawing.Size(56, 20);
            this.rdbFermale.TabIndex = 1;
            this.rdbFermale.TabStop = true;
            this.rdbFermale.Text = "נקבה";
            this.rdbFermale.UseVisualStyleBackColor = true;
            // 
            // rdbMale
            // 
            this.rdbMale.AutoSize = true;
            this.rdbMale.Location = new System.Drawing.Point(59, 78);
            this.rdbMale.Name = "rdbMale";
            this.rdbMale.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdbMale.Size = new System.Drawing.Size(47, 20);
            this.rdbMale.TabIndex = 0;
            this.rdbMale.TabStop = true;
            this.rdbMale.Text = "זכר";
            this.rdbMale.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioButton8);
            this.panel2.Controls.Add(this.rdbWidower);
            this.panel2.Controls.Add(this.radioButton7);
            this.panel2.Controls.Add(this.rdbSingle);
            this.panel2.Controls.Add(this.rdbMarried);
            this.panel2.Controls.Add(this.rdbDivorcee);
            this.panel2.Location = new System.Drawing.Point(140, 226);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(73, 240);
            this.panel2.TabIndex = 17;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(493, 150);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(103, 20);
            this.radioButton8.TabIndex = 1;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "radioButton2";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // rdbWidower
            // 
            this.rdbWidower.AutoSize = true;
            this.rdbWidower.Location = new System.Drawing.Point(-2, 150);
            this.rdbWidower.Name = "rdbWidower";
            this.rdbWidower.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdbWidower.Size = new System.Drawing.Size(57, 20);
            this.rdbWidower.TabIndex = 4;
            this.rdbWidower.TabStop = true;
            this.rdbWidower.Text = "אלמן";
            this.rdbWidower.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdbWidower.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(503, 71);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(103, 20);
            this.radioButton7.TabIndex = 0;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "radioButton1";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // rdbSingle
            // 
            this.rdbSingle.AutoSize = true;
            this.rdbSingle.Location = new System.Drawing.Point(3, 35);
            this.rdbSingle.Name = "rdbSingle";
            this.rdbSingle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdbSingle.Size = new System.Drawing.Size(52, 20);
            this.rdbSingle.TabIndex = 3;
            this.rdbSingle.TabStop = true;
            this.rdbSingle.Text = "רווק";
            this.rdbSingle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdbSingle.UseVisualStyleBackColor = true;
            // 
            // rdbMarried
            // 
            this.rdbMarried.AutoSize = true;
            this.rdbMarried.Location = new System.Drawing.Point(3, 71);
            this.rdbMarried.Name = "rdbMarried";
            this.rdbMarried.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdbMarried.Size = new System.Drawing.Size(52, 20);
            this.rdbMarried.TabIndex = 2;
            this.rdbMarried.TabStop = true;
            this.rdbMarried.Text = "נשוי";
            this.rdbMarried.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdbMarried.UseVisualStyleBackColor = true;
            // 
            // rdbDivorcee
            // 
            this.rdbDivorcee.AutoSize = true;
            this.rdbDivorcee.Location = new System.Drawing.Point(0, 115);
            this.rdbDivorcee.Name = "rdbDivorcee";
            this.rdbDivorcee.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdbDivorcee.Size = new System.Drawing.Size(55, 20);
            this.rdbDivorcee.TabIndex = 1;
            this.rdbDivorcee.TabStop = true;
            this.rdbDivorcee.Text = "גרוש";
            this.rdbDivorcee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdbDivorcee.UseVisualStyleBackColor = true;
            // 
            // lblHouseNumber
            // 
            this.lblHouseNumber.AutoSize = true;
            this.lblHouseNumber.Location = new System.Drawing.Point(80, 0);
            this.lblHouseNumber.Name = "lblHouseNumber";
            this.lblHouseNumber.Size = new System.Drawing.Size(62, 16);
            this.lblHouseNumber.TabIndex = 18;
            this.lblHouseNumber.Text = "מספר בית";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(286, 0);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(40, 16);
            this.lblPhoneNumber.TabIndex = 19;
            this.lblPhoneNumber.Text = "טלפון";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(180, 0);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(35, 16);
            this.lblStreet.TabIndex = 20;
            this.lblStreet.Text = "רחוב";
            // 
            // lblCallNumber
            // 
            this.lblCallNumber.AutoSize = true;
            this.lblCallNumber.Location = new System.Drawing.Point(410, 0);
            this.lblCallNumber.Name = "lblCallNumber";
            this.lblCallNumber.Size = new System.Drawing.Size(30, 16);
            this.lblCallNumber.TabIndex = 21;
            this.lblCallNumber.Text = "נייד";
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(442, 492);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 22;
            this.btnPrevious.Text = ">>>";
            this.btnPrevious.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(296, 492);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 23;
            this.btnNext.Text = "<<<";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.58974F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.41026F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 106F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 124F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 190F));
            this.tableLayoutPanel2.Controls.Add(this.lblCallNumber, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblPhoneNumber, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblStreet, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblHouseNumber, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblCity, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtCallNumber, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtPhoneNumber, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtStreet, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtHouseNumber, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtCity, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(102, 608);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(598, 49);
            this.tableLayoutPanel2.TabIndex = 24;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(3, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(27, 16);
            this.lblCity.TabIndex = 22;
            this.lblCity.Text = "עיר";
            // 
            // txtCallNumber
            // 
            this.txtCallNumber.Location = new System.Drawing.Point(410, 31);
            this.txtCallNumber.Name = "txtCallNumber";
            this.txtCallNumber.Size = new System.Drawing.Size(100, 22);
            this.txtCallNumber.TabIndex = 23;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(286, 31);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(100, 22);
            this.txtPhoneNumber.TabIndex = 24;
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(180, 31);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(100, 22);
            this.txtStreet.TabIndex = 25;
            // 
            // txtHouseNumber
            // 
            this.txtHouseNumber.Location = new System.Drawing.Point(80, 31);
            this.txtHouseNumber.Name = "txtHouseNumber";
            this.txtHouseNumber.Size = new System.Drawing.Size(94, 22);
            this.txtHouseNumber.TabIndex = 26;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(3, 31);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(71, 22);
            this.txtCity.TabIndex = 27;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.07407F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.92593F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 161F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 172F));
            this.tableLayoutPanel3.Controls.Add(this.btnNew, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnAddition, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnUpdate, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnDelete, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(102, 675);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(586, 43);
            this.tableLayoutPanel3.TabIndex = 25;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(416, 3);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "חדש";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnAddition
            // 
            this.btnAddition.Location = new System.Drawing.Point(255, 3);
            this.btnAddition.Name = "btnAddition";
            this.btnAddition.Size = new System.Drawing.Size(112, 23);
            this.btnAddition.TabIndex = 1;
            this.btnAddition.Text = "הוספת עובד";
            this.btnAddition.UseVisualStyleBackColor = true;
            this.btnAddition.Click += new System.EventHandler(this.btnAddition_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(139, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "עדכון";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(3, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(105, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "מחיקת עובד";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSearchByCode
            // 
            this.btnSearchByCode.Location = new System.Drawing.Point(492, 748);
            this.btnSearchByCode.Name = "btnSearchByCode";
            this.btnSearchByCode.Size = new System.Drawing.Size(143, 23);
            this.btnSearchByCode.TabIndex = 26;
            this.btnSearchByCode.Text = "חיפוש עובד לפי קוד";
            this.btnSearchByCode.UseVisualStyleBackColor = true;
            // 
            // btnSearchById
            // 
            this.btnSearchById.Location = new System.Drawing.Point(266, 748);
            this.btnSearchById.Name = "btnSearchById";
            this.btnSearchById.Size = new System.Drawing.Size(133, 23);
            this.btnSearchById.TabIndex = 27;
            this.btnSearchById.Text = "חיפוש עובד לפי ת\"ז";
            this.btnSearchById.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 794);
            this.Controls.Add(this.btnSearchById);
            this.Controls.Add(this.btnSearchByCode);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rdbFermale;
        private System.Windows.Forms.RadioButton rdbMale;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton rdbWidower;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton rdbSingle;
        private System.Windows.Forms.RadioButton rdbMarried;
        private System.Windows.Forms.RadioButton rdbDivorcee;
        private System.Windows.Forms.Label lblHouseNumber;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblCallNumber;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtCallNumber;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.TextBox txtHouseNumber;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnAddition;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearchByCode;
        private System.Windows.Forms.Button btnSearchById;
    }
}

