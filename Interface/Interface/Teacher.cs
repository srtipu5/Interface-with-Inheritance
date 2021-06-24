using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
   public class Teacher:Student
    {
        public Teacher(string id, string name, string gender, string age) : base(id, name, gender, age)
        {

        }
        public override void Details()
        {
            string details = "Teacher Id : " + Id + Environment.NewLine +
                "Name : " + Name + Environment.NewLine +
                "Gender : " + Gender + Environment.NewLine +
                "Age : " + Age + Environment.NewLine;

            Console.WriteLine(details);
        }
    }
}
