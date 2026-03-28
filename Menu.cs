using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller3DJP261
{
    internal class Menu
    {
        public void Execute()
        {
            string name;
            int age;


            Console.WriteLine("Introduce tu nombre:");
            name = Console.ReadLine();
            Console.WriteLine($"Hola {name}");
            age = GetAge();
            Console.WriteLine($"Tienes {age} años");
            Console.WriteLine($"El próximo año tendrás {age + 1}");
        }

        private int GetAge()
        {
            int age = -1;

            while (age < 0)
            {
                Console.WriteLine("Introduce tu edad:");
                age=int.Parse(Console.ReadLine());
                if (age<0)
                {
                    Console.WriteLine("La edad no puede ser negativa");
                }
            }
            return age;
        }

    }
}
