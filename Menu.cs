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
            E1();
        }

        private void E1()
        {
            float b;
            float h;

            
            b= GetPositiveNumber("Introduce la base");
            h= GetPositiveNumber("Introduce la altura");
            Console.WriteLine($"El perímetro es {2 * b + 2 * h} y el área es {b * h}");

        }

        private float GetPositiveNumber(string message)
        {
            float value = 0;

            while (value <= 0)
            {
                Console.WriteLine(message);
                value = float.Parse(Console.ReadLine());
                if (value <= 0)
                {
                    Console.WriteLine("El número debe ser positivo");
                }
            }
            return value;
        }

        private void Example()
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
