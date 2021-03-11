using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Polygon
{
    public class Square : Rectangle
    {
        public override string ShapeName => "正方形";

        public double Length
        {
            get => Math.Abs(base.Width - base.Height) < 0.000001 ? base.Height : throw new InvalidDataException("边长不等");
            set => base.Height = base.Width = value;
        }

        public new double Width
        {
            get => base.Width;
            set
            {
                if (Math.Abs(Width - base.Height) > 0.000001)
                {
                    throw new ArgumentException("边长不可与另一边长不同");
                }

                Length = value;
            }
        }

        public new double Height
        {
            get => base.Height;
            set
            {
                if (Math.Abs(Height - base.Width) > 0.000001)
                {
                    throw new ArgumentException("边长不可与另一边长不同");
                }

                Length = value;
            }
        }
    }
}