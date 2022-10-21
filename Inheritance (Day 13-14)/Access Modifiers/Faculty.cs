using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Modifiers
{
    internal class Faculty:Employee
    {
        public override void Name()
        {
            Console.WriteLine("Name: Sofia Gail");
        }
        public override void Address()
        {
            Console.WriteLine("Address: Palayan City Nueva Ecija");
        }
        public override void Gender()
        {
            Console.WriteLine("Gender: Female");
        }
        public override void Phone()
        {
            Console.WriteLine("Phone: 09631327426");
        }
        public override void Email()
        {
            Console.WriteLine("Email: SofiaGail@gmail.com");
        }
        public override void BirthDate()
        {
            Console.WriteLine("BirthDate: 12/02/89");
        }
        public override void Designation()// Override to change this Desination() method value from the super class
        {
            Console.WriteLine("Designation: Manila City ");
        }
        public override void Salary()
        {
            Console.WriteLine("Salary: 24000");
        }
        public void CollegeDepartment()
        {
            Console.WriteLine("CollegeDepartment: ");
        }
        public void SubjectLoad()
        {
            Console.WriteLine("SubjectLoad: ");
        }
    }
}
