using System;

namespace Calculator
{
    public class CalculationNode
    {
        public delegate double CalculationOperator(double value1, double value2);

        public CalculationNode Value1 { get; set; }
        public CalculationNode Value2 { get; set; }
        public CalculationOperator Operator { get; set; }

        private double? _actualValue;

        public double ActualValue
        {
            get
            {
                if (Operator != null)
                {
                    if (Value1 == null) throw new ArithmeticException("操作数1为null");
                    if (Value2 == null) throw new ArithmeticException("操作数2为null");
                    return Operator(Value1.ActualValue, Value2.ActualValue);
                }

                return _actualValue ?? throw new ArithmeticException("该操作数为null");
            }
            private set =>
                _actualValue = value;
        }

        public void JustValue(double value)
        {
            Operator = null;
            ActualValue = value;
        }
    }
}