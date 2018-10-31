using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            XDocument xdoc = new XDocument();
           
            XElement student1 = new XElement("students");          
            XAttribute studNameAttr = new XAttribute("name", "Ivanov V.D.");
            XElement studGroupElem = new XElement("group", "1");           
            student1.Add(studNameAttr);
            student1.Add(studGroupElem);

            XElement student2 = new XElement("student");
            XAttribute stud2NameAttr = new XAttribute("name", "Petrov.D.");
            XElement stud2GroupElem = new XElement("group", "2");
            student2.Add(stud2NameAttr);
            student2.Add(stud2GroupElem);

          
            XElement students = new XElement("students");
           
            students.Add(student1);
            students.Add(student2);
            
            xdoc.Add(students);
            
            xdoc.Save(@"C:\Users\Марина\Documents\visual studio 2015\Projects\Test3010_WPF\Students\students.xml");
        }
    }
}
