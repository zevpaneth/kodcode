namespace TestWeek4
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cmbDayWeek = new ComboBox();
            cmbDayMonth = new ComboBox();
            cmbMonth = new ComboBox();
            cmbYear = new ComboBox();
            btnResult = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(348, 48);
            label1.Name = "label1";
            label1.Size = new Size(194, 41);
            label1.TabIndex = 0;
            label1.Text = "כתיבת תאריך";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(691, 147);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 1;
            label2.Text = "יום בשבוע";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(479, 147);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 2;
            label3.Text = "יום בחודש";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(321, 147);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 3;
            label4.Text = "חודש";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(168, 147);
            label5.Name = "label5";
            label5.Size = new Size(37, 20);
            label5.TabIndex = 4;
            label5.Text = "שנה";
            // 
            // cmbDayWeek
            // 
            cmbDayWeek.FormattingEnabled = true;
            cmbDayWeek.Items.AddRange(new object[] { "", "ראשון", "שני שלישי", "רביעי", "חמישי", "ששי" });
            cmbDayWeek.Location = new Point(650, 201);
            cmbDayWeek.Name = "cmbDayWeek";
            cmbDayWeek.Size = new Size(115, 28);
            cmbDayWeek.TabIndex = 5;
            // 
            // cmbDayMonth
            // 
            cmbDayMonth.FormattingEnabled = true;
            cmbDayMonth.Items.AddRange(new object[] { "", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30" });
            cmbDayMonth.Location = new Point(443, 201);
            cmbDayMonth.Name = "cmbDayMonth";
            cmbDayMonth.Size = new Size(109, 28);
            cmbDayMonth.TabIndex = 6;
            // 
            // cmbMonth
            // 
            cmbMonth.FormattingEnabled = true;
            cmbMonth.Items.AddRange(new object[] { "", "תשרי", "מרחשון", "כסלו", "טבת", "שבט", "אדר", "אדר הראשון", "אדר השני", "ניסן", "אייר", "סיון", "תמוז", "אב", "אלול" });
            cmbMonth.Location = new Point(259, 201);
            cmbMonth.Name = "cmbMonth";
            cmbMonth.Size = new Size(104, 28);
            cmbMonth.TabIndex = 7;
            // 
            // cmbYear
            // 
            cmbYear.FormattingEnabled = true;
            cmbYear.Items.AddRange(new object[] { "", "תשפ\"ד", "תשפ\"ה", "תשפ\"ו", "תשפ\"ז", "תשפ\"ח", "תשפ\"ט", "תש\"צ", "תשצ\"א", "תשצ\"ב", "תשצ\"ג" });
            cmbYear.Location = new Point(100, 201);
            cmbYear.Name = "cmbYear";
            cmbYear.Size = new Size(105, 28);
            cmbYear.TabIndex = 8;
            // 
            // btnResult
            // 
            btnResult.Location = new Point(100, 270);
            btnResult.Name = "btnResult";
            btnResult.Size = new Size(665, 80);
            btnResult.TabIndex = 9;
            btnResult.Text = "תשובה";
            btnResult.UseVisualStyleBackColor = true;
            btnResult.Click += btnResult_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(888, 395);
            Controls.Add(btnResult);
            Controls.Add(cmbYear);
            Controls.Add(cmbMonth);
            Controls.Add(cmbDayMonth);
            Controls.Add(cmbDayWeek);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cmbDayWeek;
        private ComboBox cmbDayMonth;
        private ComboBox cmbMonth;
        private ComboBox cmbYear;
        private Button btnResult;
    }
}
