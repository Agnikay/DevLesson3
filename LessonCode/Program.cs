using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace LessonCode
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperHeroAbility(name: "Dr.Strange", ability: "Magic", age: 50);
            SuperHeroAbility(age: 50, ability: "Magic", name: "Dr.Strange");
            SuperheroThings();
            SuperheroThings("Tank");
            StartUseMarkI();
            Type t = typeof(AwesomeSuperhero);
            MagicSuperpowerAttribute attr = Attribute.GetCustomAttribute(t, typeof(MagicSuperpowerAttribute)) as MagicSuperpowerAttribute;
            Console.WriteLine("Mana={0}, Rank={1}", attr.Mana, attr.Rank);

            Console.WriteLine("*************Serialization***************");

            XmlSerializer serializer = new XmlSerializer(typeof(Employee));
            Employee employee = new Employee();
            employee.EmployeeName = "Vasya Pupkin";
            employee.IsGood = true;
            employee.PhoneNumber = "+393934934";
            employee.YearsOfExperience = 20;

            using (TextWriter writer = new StreamWriter("Out.xml"))
            {
                serializer.Serialize(writer, employee);
            }

            using (TextReader reader = new StreamReader("Out.xml"))
            {
                Employee employeeDeser = serializer.Deserialize(reader) as Employee;
            }

            Console.ReadLine();
        }

        static void SuperHeroAbility(string name, string ability, int age)
        {
            Console.WriteLine("Name: {0} and his ability is {1}", name, ability);
        }

        static void SuperheroThings(string car = "Batmobile")
        {
            Console.WriteLine("Superhero car = {0}", car);
        }

        [Obsolete]
        static void StartUseMarkI()
        {

        }
    }
}
