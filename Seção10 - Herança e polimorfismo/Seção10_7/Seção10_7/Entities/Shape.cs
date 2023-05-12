using Seção10_7.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seção10_7.Entities
{
    abstract class Shape
    {

        public Color Color { get; set; }

        public Shape() { }

        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();

    }
}
