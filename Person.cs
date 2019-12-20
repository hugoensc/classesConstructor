using System;
using System.Collections.Generic;
using System.Text;

namespace classesConstructor
{
    class Person
    {
        private string firstName;
        private int age = 28;

        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                firstName = value;
            }
        }

        public string LastName { get; set; }
        public int Age 
        {
            get
            {
                return age;
            }
        }

        public List<string> Telefonos { get; set; }

        public Person()
        {
            Console.WriteLine("Ensamblando humano....\n\n\t\t Humano Ensamblado ;)");
            Telefonos = new List<string>();
        }
    }
}
