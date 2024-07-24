using System;
using System.Windows.Forms;
using System.Xml;

namespace TestWeek4
{
    internal class Controler
    {
        private XmlDocument _xmlDoc;

        public Controler(XmlDocument doc)
        {
            _xmlDoc = doc;
        }

        public void AddDate(List<string> fullDate)
        {
            if (_xmlDoc == null)
            {
                _xmlDoc = new XmlDocument();
            }
            int i = 1;

            if (_xmlDoc.SelectSingleNode($"//Date{i}") != null)
            {
                i++;
            }

            XmlElement dateElement = _xmlDoc.CreateElement($"Date{i}");

            List<string> tagsName = new List<string>() { "DayOfWeek", "DayOfMonth", "Month", "Year" };
            for (int y = 0; y < tagsName.Count; y++)
            {
                XmlElement child = _xmlDoc.CreateElement(tagsName[y]);
                child.InnerText = fullDate[y];
                dateElement.AppendChild(child);
            }

            XmlElement result = _xmlDoc.CreateElement("Result");
            dateElement.AppendChild( result );
            _xmlDoc.AppendChild( dateElement );
            //MessageBox.Show(GetResult(dateElement));


        }

        //private string? GetResult(XmlElement dateElement)
        //{
        //    XmlNode result = _xmlDoc.SelectSingleNode($"//{dateElement}");
        //    if (result != null) {return result.InnerText;return null;}
        //    else
        //    {
        //        string dayWeek = _xmlDoc.SelectSingleNode($"//{dateElement}/ DayOfWeek").InnerText;
        //        string dayMonth = _xmlDoc.SelectSingleNode($"//{dateElement}/ DayOfMonth").InnerText;
        //        string month = _xmlDoc.SelectSingleNode($"//{dateElement}/Month").InnerText;
        //        string year = _xmlDoc.SelectSingleNode($"//{dateElement}/year").InnerText;



        //        return null;
        //    };
        //    return null;
        //}
    }
}