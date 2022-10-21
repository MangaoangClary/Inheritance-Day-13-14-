using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Modifiers
{
    internal class Employee:Person
    {
        public virtual void Designation()
        {
            Console.WriteLine("Designation: ");
        }
        public virtual void Salary()
        {
            Console.WriteLine("Salary: ");
        }
        }
}
