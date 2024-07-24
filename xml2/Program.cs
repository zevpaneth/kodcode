using System.Xml;

namespace Xml2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string _pathString = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..") + "\\Students.xml");

            XmlDocument xmlDoc = new XmlDocument(); ;

            if (File.Exists(_pathString))
            {
                xmlDoc.Load(_pathString);
            }
            else
            {
                XmlNode StudentsNode = xmlDoc.CreateElement("Students");
                xmlDoc.AppendChild(StudentsNode);
            }


            XmlNode studentNode = xmlDoc.SelectSingleNode("//Student[2]");

            if (studentNode != null)
            {
                XmlNode idNode = studentNode.SelectSingleNode("ID");
                if (idNode != null)
                {
                    studentNode.RemoveChild(idNode);
                    Console.WriteLine("ID node removed from Student.");

                }
                else
                {
                    Console.WriteLine("No ID node found for this Student.");
                }
            }
            else { Console.WriteLine("No Student node found in the document."); }





            XmlElement studentElement = xmlDoc.CreateElement("Student");

            if (studentElement != null)
            {
                XmlNode studentNode = xmlDoc.CreateElement("ID");
                studentNode.InnerText = "";
                studentElement.AppendChild(studentNode);
            }
            Console.WriteLine("Hi!!");

            root.AppendChild(studentElement);


            Console.WriteLine("Hi!! Hi!!!!1");


            xmlDoc.Save(_pathString);





        }
    }
}
