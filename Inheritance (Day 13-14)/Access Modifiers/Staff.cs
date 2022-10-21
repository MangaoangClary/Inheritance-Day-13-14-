using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Modifiers
{
    internal class Staff:Employee
    {
        public override void Name()
        {
            Console.WriteLine("Name: Jairus");
        }
        public override void Address()
        {
            Console.WriteLine("Address: Nueva Ecija");
        }
        public override void Gender()
        {
            Console.WriteLine("Gender: Male");
        }
        public override void Phone()
        {
            Console.WriteLine("Phone: ");
        }
        public override void Email()
        {
            Console.WriteLine("Email: Jairus@gmail.com");
        }
        public override void BirthDate()
        {
            Console.WriteLine("BirthDate: 02/17/97");
        }
        public override void Designation()
        {
            Console.WriteLine("Designation: Palayan City ");
        }
        public override void Salary()
        {
            Console.WriteLine("Salary: 21000");
        }
        public void ServiceDepartment()
        {
            Console.WriteLine("ServiceDepartment: ");
        }
    }
}
