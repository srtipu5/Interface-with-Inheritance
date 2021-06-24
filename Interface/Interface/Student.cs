using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class Student : Person,IPerson
    {
        public Student(string id,string name,string gender,string age):base(id,name,gender,age)
        {
           
        }

        public virtual void Details()
        {
            string details = "Student Id : " + Id + Environment.NewLine +
                "Name : " + Name + Environment.NewLine +
                "Gender : " + Gender + Environment.NewLine +
                "Age : " + Age + Environment.NewLine;

            Console.WriteLine(details);
        }
    }
}
