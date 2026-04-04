using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller3DJP261
{
    internal class ShapeMenu
    {
        public void Execute()
        {
            ShowMenu();
        }

        private void ShowMenu()
        {
            string option;
            Console.WriteLine("Introduce qué figura quieres calcular:");
            Console.WriteLine("1. Rectángulo");
            Console.WriteLine("2. Círculo");
            Console.WriteLine("3. Triángulo");
            option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    RectangleMenu();
                    break;
            }

        }

        private void RectangleMenu()
        {/*
            float b;
            float h;
            Rectangle r;

            b = GetPositiveNumber("Introduce la base");
            h = GetPositiveNumber("Introduce la altura");
            r = new Rectangle(b, h);
            Console.WriteLine($"El perímetro es {r.GetPerimeter()} y el área es {r.GetArea()}");
      */  }

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


    }
}
