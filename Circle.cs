using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller3DJP261
{
    internal class Circle : Shape
    {
        protected float r;

        public Circle(string name, float r) : base(name)
        {
            this.r = r;
        }

        public override float GetArea()
        {
            return r * r * 3.14f;
        }

    }
}
