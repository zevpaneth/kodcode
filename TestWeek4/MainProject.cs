using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TestWeek4
{
    internal class MainProject
    {
        private static string _pathString = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..") + "\\Date.xml");
        
        public static XmlDocument Main()
        {
            if (File.Exists(_pathString))
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(_pathString);
                return xmlDoc;
            }
            else
            {
                XmlDocument xmlDoc = new XmlDocument();
                XmlElement Dates = xmlDoc.CreateElement("Dates");
                return xmlDoc;
            }
        }

        public static void Save(XmlDocument xmlDoc)
        {

            xmlDoc.Save(_pathString);
        }
    }
}
