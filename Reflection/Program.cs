using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstTarget();
            SecondTarget();
        }
        private static void FirstTarget()
        {
            Type style = typeof(Console);

            var mode = style.GetMethods();

            foreach(var mode in methods)
            {
                Console.WriteLine("Title of mode: {0}", mode.Name);
                Console.WriteLine("Reasons: ");
                foreach(var reson in mode.GetParameters())
                {
                    Console.WriteLine(reson.ParameterType + " _ " + reson.Name);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
            Console.Clear();

        }
        private static void SecondTarget()
        {
            Man man = new Man()
            {
                Name = "Aiden",
                Surname = "Pearce",
                Age = "29",
                Busy = false
            };
            Type style = typeof(Man);
            var internals = style.GetProperties();

            for(int j = 0; j < internals.Length; j++)
            {
                switch(internals[j].Name)
                {
                    case "Age":
                        int years = (int)internals[j].GetValue(man);
                        Console.WriteLine("Age: ", years);
                        break;
                    case "Surname":
                        string surname = (string)internals[j].GetValue(man);
                        Console.WriteLine("Surname: ", surname);
                        break;
                    case "Name":
                        string name = (string)internals[j].GetValue(man);
                        Console.WriteLine("Name: ", name);
                        break;
                    case "Busy":
                        bool busy = (bool)internals[j].GetValue(man);
                        Console.WriteLine("Busy(yes/no): ", busy);
                        break;
                }

            }

            Console.ReadLine();
            Console.Clear();
        }
    }
}
