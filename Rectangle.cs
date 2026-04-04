using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller3DJP261
{
    internal class Rectangle : Shape
    {
        protected float b;
        protected float h;

        public float B { get { return b; } }

        public float H { get { return h; } }

        public Rectangle(string name, float b, float h) : base(name)
        {
            this.b = b;
            this.h = h;
        }

        public override float GetArea()
        {
            return b * h;
        }

        public override string GetData()
        {
            return $"B: {b} - H: {h}";
        }

    }
}

