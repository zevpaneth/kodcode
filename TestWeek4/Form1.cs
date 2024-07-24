using System.Xml;

namespace TestWeek4
{
    public partial class Form1 : Form
    {
        private Controler controler;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            XmlDocument xmlDoc = MainProject.Main();
            controler = new Controler(xmlDoc); 
            List<string> fullDate = new List<string>() { cmbDayWeek.Text, cmbDayMonth.Text, cmbMonth.Text, cmbYear.Text };
            controler.AddDate(fullDate);

        }
    }
}
