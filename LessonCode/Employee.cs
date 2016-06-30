using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace LessonCode
{
    [XmlRoot(ElementName = "Worker")]
    public class Employee
    {
        [XmlElement(ElementName = "Name")]
        public string EmployeeName { set; get; }
        public string PhoneNumber { set; get; }
        public int YearsOfExperience { set; get; }
        [XmlAttribute]
        public bool IsGood { set; get; }
    }
}
