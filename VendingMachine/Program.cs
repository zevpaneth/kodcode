using System;
using System.IO;
using System.Xml;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello, World!");

        // 1. Construct path to Employees.xml
        string pathString = Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..", "Employees.xml");
        string fullPath = Path.GetFullPath(pathString);

        // 2. Print full path
        Console.WriteLine("Project Directory: " + fullPath);

        // 3. Check if file exists
        if (File.Exists(fullPath))
        {
            // 4. Create XmlDocument instance
            XmlDocument xmlDoc = new XmlDocument();

            // 5. Load XML content into XmlDocument
            xmlDoc.Load(fullPath);

            // 6. Search for Employee with id='2'
            XmlNode xmlNode = xmlDoc.SelectSingleNode("/Employees/Employee[@id='2']");
            if (xmlNode != null && xmlNode.Attributes != null)
            {
                // 7. Output attributes of the selected Employee
                Console.WriteLine("Employee with id='2' found:");
                foreach (XmlAttribute attribute in xmlNode.Attributes)
                {
                    Console.WriteLine(attribute.Name + ": " + attribute.Value);
                }
            }
            else
            {
                Console.WriteLine("Employee with id='2' not found.");
            }

            Console.WriteLine();

            // 8. Search for all employees
            XmlNodeList allEmployees = xmlDoc.SelectNodes("/Employees/Employee");
            Console.WriteLine("All Employees:");
            foreach (XmlNode employee in allEmployees)
            {
                foreach (XmlAttribute attribute in employee.Attributes)
                {
                    Console.WriteLine(attribute.Name + ": " + attribute.Value);
                }
                Console.WriteLine(); // Separate employees with an empty line
            }

            // 9. Insert new employee (sample)
            // Example: Create a new employee node
            XmlElement newEmployee = xmlDoc.CreateElement("Employee");
            newEmployee.SetAttribute("id", "5");
            newEmployee.SetAttribute("name", "John Doe");
            newEmployee.SetAttribute("department", "HR");

            // Append the new employee to the root node (Employees)
            xmlDoc.DocumentElement?.AppendChild(newEmployee);

            // 10. Save changes back to the XML file
            xmlDoc.Save(fullPath);

            Console.WriteLine();
            Console.WriteLine("New employee inserted.");

        }
        else
        {
            Console.WriteLine("File not found: " + fullPath);
        }

        Console.ReadLine(); // Keep console window open
    }
}