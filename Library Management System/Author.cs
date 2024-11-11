using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_CSharp.Library_Management_System
{
    public class Author
    {
        public string Name { get; set; }
        public char Gender { get; set; }
        public Author(string name, char gender)
        {
            Name = name;
            Gender = gender;
        }
        public Author() { }
        public override string ToString()
        {
            return $"{Name} {Gender}";
        }
    }
}
