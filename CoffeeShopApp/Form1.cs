using System.Xml;

namespace CoffeeShopApp
{
    public partial class Form1 : Form
    {
        XmlDocument doc;
        public Form1()
        {
            InitializeComponent();
            // doc = Program.Main();
            Controler controler = new Controler(doc);


            string name = txtName.Text;
            int sugar = (int)numSugar.Value;
            int cofee = (int)numCofee.Value;
            int milk = (int)numMilk.Value;
            int cocoa = (int)numCocoa.Value;
            int price = int.Parse(txtPrice.Text);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //List<List<string>> drinksList = doc.GetDrinksData();
        }
    }
}
