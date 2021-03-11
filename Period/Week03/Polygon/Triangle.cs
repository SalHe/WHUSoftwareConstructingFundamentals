using System;
using System.Collections.Generic;
using System.Text;

namespace Polygon
{
    public class Triangle : IShape
    {
        public string ShapeName
        {
            get
            {
                //if (Math.Abs(Math.Pow(A, 2) + Math.Pow(B, 2) - Math.Pow(C, 2)) < 0.0000001
                //    || Math.Abs(Math.Pow(A, 2) + Math.Pow(C, 2) - Math.Pow(B, 2)) < 0.0000001
                //    || Math.Abs(Math.Pow(B, 2) + Math.Pow(C, 2) - Math.Pow(A, 2)) < 0.0000001)
                //    return "直角三角形";
                //else if (A== B && B== C)
                //{
                //    return "等边三角形";
                //}
                //else if ()
                //{
                    
                //}
                return "三角形";
            }
        }

        public bool IsValid => A + B > C && A + C > B && B + C > A;

        public double Area
        {
            get
            {
                double p = (A + B + C) / 2;
                return Math.Sqrt(p * (p-A) * (p-B) * (p-C));
            }
        }

        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; } 

        

        

    }
}
