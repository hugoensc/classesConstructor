using System;

namespace classesConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            var person1 = new Person();
            //Console.WriteLine(person1.Age);
            person1.Telefonos.Add("7711744182");
            Console.WriteLine(person1.Telefonos[0]);
        }
    }
}
