using System;
using System.Collections.Generic;
using System.Text;

namespace Polygon
{
    public interface IShape
    {
        public double Area { get; }

        public bool IsValid { get; }

        public string ShapeName { get; }

        public virtual string Description => "一个" + (IsValid ? "有效的" : "无效的") + $" {ShapeName}, 面积：{Area:F}";
    }
}