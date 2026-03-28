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
            Rectangle r;
            
            b= GetPositiveNumber("Introduce la base");
            h= GetPositiveNumber("Introduce la altura");
            r=new Rectangle(b, h);
            Console.WriteLine($"El perímetro es {r.GetPerimeter()} y el área es {r.GetArea()}");

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
            Person p;


            Console.WriteLine("Introduce tu nombre:");
            name = Console.ReadLine();
            age = GetAge();
            p = new Person(name, age);
            Console.WriteLine($"Hola {p.Name}");
            Console.WriteLine($"Tienes {p.Age} años");
            Console.WriteLine($"El próximo año tendrás {p.Age + 1}");
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
