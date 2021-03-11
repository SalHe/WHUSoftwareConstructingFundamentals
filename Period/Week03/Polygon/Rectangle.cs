using System;
using System.Collections.Generic;
using System.Text;

namespace Polygon
{
    public class Rectangle : IShape
    {
        public double Area => Width * Height;

        public bool IsValid => Width > 0 && Height > 0;

        public virtual string ShapeName => "矩形";

        public double Width { get; set; }
        public double Height { get; set; }
    }
}