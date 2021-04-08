using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class MainForm : Form
    {
        private CalculationNode _calculationTree;
        private CalculationNode _currentCalculationNode;
        private bool _isFirstOperandOver = false;
        private Dictionary<string, CalculationNode.CalculationOperator> _operators;
        private readonly StringBuilder _inputNumber = new StringBuilder();

        public MainForm()
        {
            InitializeComponent();
            BindBtnEvent();
            Clear(null, null);
        }

        private void BindBtnEvent()
        {
            Dictionary<Button, string> buttons = new Dictionary<Button, string>()
            {
                {btnNum0, "0"},
                {btnNum1, "1"},
                {btnNum2, "2"},
                {btnNum3, "3"},
                {btnNum4, "4"},
                {btnNum5, "5"},
                {btnNum6, "6"},
                {btnNum7, "7"},
                {btnNum8, "8"},
                {btnNum9, "9"},
                {btnPoint, "."},

                {btnPlus, "+"},
                {btnSub, "-"},
                {btnMultiply, "*"},
                {btnDivide, "/"},

                {btnClear, "Clear"}
            };
            foreach (var entry in buttons)
            {
                var button = entry.Key;
                var numOrOp = entry.Value;
                button.Text = numOrOp;
                if (numOrOp == "Clear")
                {
                    button.Click += Clear;
                }
                else
                {
                    button.Click += (sender, args) =>
                    {
                        AppendInput(numOrOp);
                        try
                        {
                            var ans = _calculationTree.ActualValue;
                            Text = ans.ToString(CultureInfo.CurrentCulture);
                        }
                        catch (ArithmeticException e)
                        {
                            Text = e.Message;
                        }
                    };
                }
            }

            _operators = new Dictionary<string, CalculationNode.CalculationOperator>()
            {
                {"+", (value1, value2) => value1 + value2},
                {"-", (value1, value2) => value1 - value2},
                {"*", (value1, value2) => value1 * value2},
                {"/", (value1, value2) => value1 / value2},
            };
        }

        private void Clear(object sender, EventArgs e)
        {
            _inputNumber.Length = 0;
            _isFirstOperandOver = false;
            tbDisplay.Text = "";
            _currentCalculationNode = _calculationTree = new CalculationNode();
        }

        private void AppendInput(string input)
        {
            tbDisplay.AppendText(input);
            switch (input)
            {
                case "+":
                case "-":
                case "*":
                case "/":
                    _isFirstOperandOver = true;
                    _inputNumber.Length = 0;
                    var op = _operators[input];
                    if (_calculationTree.Operator == null)
                    {
                        _calculationTree.Operator = op;
                    }
                    else
                    {
                        if ((input == "*" || input == "/") && (_calculationTree.Operator == _operators["+"] ||
                                                               _calculationTree.Operator == _operators["-"]))
                        {
                            _currentCalculationNode = _calculationTree.Value2 = new CalculationNode()
                            {
                                Value1 = _calculationTree.Value2,
                                Operator = op
                            };
                        }
                        else
                        {
                            _currentCalculationNode = _calculationTree = new CalculationNode()
                            {
                                Value1 = _calculationTree,
                                Operator = op
                            };
                        }
                    }

                    break;
                default:
                    if (Regex.IsMatch(input, @"[\.\d]+")) // 输入数字
                    {
                        _inputNumber.Append(input);
                        var operand = DigestNumber(_inputNumber.ToString());
                        if (_currentCalculationNode.Value1 == null || !_isFirstOperandOver)
                        {
                            _currentCalculationNode.Value1 = operand;
                        }
                        else
                        {
                            _currentCalculationNode.Value2 = operand;
                        }
                    }

                    break;
            }
        }

        private CalculationNode DigestNumber(string numberString)
        {
            if (numberString.Length <= 0) return null;
            var number = double.Parse(numberString);
            var operand = new CalculationNode();
            operand.JustValue(number);
            return operand;
        }
    }
}