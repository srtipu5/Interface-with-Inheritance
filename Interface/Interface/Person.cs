using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class Person
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Age { get; set; }
        public Person(string id,string name,string gender,string age)
        {
            Id = id;
            Name = name;
            Gender = gender;
            Age = age;
        }
    }
}
