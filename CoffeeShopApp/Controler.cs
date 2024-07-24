using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CoffeeShopApp
{
    internal class Controler
    {
        private XmlDocument _document;
        public Controler(XmlDocument document)
        {
            _document = document;
        }

        public List<List<string>> GetDrinksData()
        {
            List<List<string>> AllDrinks = new List<List<string>>();
            XmlNodeList drinksNodes = _document.SelectNodes("/drinks/drink");
            if (drinksNodes != null)
            {
            }
            return null;
        }
    }
}