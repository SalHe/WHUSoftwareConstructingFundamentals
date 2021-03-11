using System;
using System.Collections.Generic;
using System.Text;

namespace Polygon
{
    public class Circle: IShape
    {
        public bool IsValid => radius > 0;

        public string ShapeName => "圆形";

        public double Area => radius * radius * Math.PI;

        public double radius { get; set; }

    }
}
