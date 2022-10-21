using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Modifiers
{
    internal class Person
    {
        public virtual void Name() 
        {
            Console.WriteLine("Name: Clary Jane");
        }
        public virtual void Address()
        {
            Console.WriteLine("Address: Nueva Ecija");
        }
        public virtual void Gender()
        {
            Console.WriteLine("Gender: Female");
        }
        public virtual void Phone()
        {
            Console.WriteLine("Phone: 09651324726");
        }
        public virtual void Email()
        {
            Console.WriteLine("Email: clra.mangaoang.au@phinmaed.com");
        }
        public virtual void BirthDate()
        {
            Console.WriteLine("BirthDate: 07/26/97");
        }
    }
}
