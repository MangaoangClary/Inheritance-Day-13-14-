using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Modifiers
{
    internal class Student:Person
    {
        public void SchoolLastGraduated()
        {
            Console.WriteLine("SchoolLastGraduated: Arellano Univ.");
        }
        public void Course()
        {
            Console.WriteLine("Course: BSIT");
        }
    }
}
