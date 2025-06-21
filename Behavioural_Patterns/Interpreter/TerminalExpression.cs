﻿namespace DesignPatterns.Behavioural_Patterns.Interpreter
{
    /// <summary>
    /// -- ENGLISH
    /// The Interpreter pattern, given a language, defines a representation for its grammar along with an interpreter
    /// that uses the representation to interpret sentences in the language
    /// -- ITALIANO
    /// Il pattern Interpreter, dato un linguaggio, definisce una rappresentazione per la sua grammatica e fornisce un interprete 
    /// che utilizza questa rappresentazione per interpretare le frasi del linguaggio.
    /// </summary>
    public sealed class Interpreter
    {

    }

    /// <summary>
    /// -- ENGLISH
    /// A Terminal Expression, in the context of the Interpreter Pattern, is a class that represents the most fundamental 
    /// and indivisible elements of the grammar being interpreted.
    /// In this example, the terminal expression is an integer.
    /// -- ITALIANO
    /// Un'espressione terminale, nel contesto del pattern Interpreter, è una classe che rappresenta gli elementi più
    /// fondamentali e indivisibili della grammatica in fase di interpretazione.
    /// In questo esempio, l'espressione terminale è un intero.
    /// </summary>
    public class TerminalExpression : IExpression<int>
    {
        private int _number;

        public TerminalExpression(int number)
        {
            _number = number;
        }
        public int Interpret()
        {
            return _number;
        }
    }

    public class AddExpression : IExpression<int>
    {
        private IExpression<int> _left, _right;

        public AddExpression(IExpression<int> left, IExpression<int> right)
        {
            _left = left;
            _right = right;
        }
        public int Interpret()
        {
            return _left.Interpret() + _right.Interpret();
        }
    }

    public class SubtractExpression : IExpression<int>
    {
        private IExpression<int> _left, _right;

        public SubtractExpression(IExpression<int> left, IExpression<int> right)
        {
            _left = left;
            _right = right;
        }
        public int Interpret()
        {
            return _left.Interpret() - _right.Interpret();
        }
    }

    public class MultiplyExpression : IExpression<int>
    {
        private IExpression<int> _left, _right;

        public MultiplyExpression(IExpression<int> left, IExpression<int> right)
        {
            _left = left;
            _right = right;
        }
        public int Interpret()
        {
            return _left.Interpret() * _right.Interpret();
        }
    }

    public class DivideExpression : IExpression<int>
    {
        private IExpression<int> _left, _right;

        public DivideExpression(IExpression<int> left, IExpression<int> right)
        {
            _left = left;
            _right = right;
        }
        public int Interpret()
        {
            return _left.Interpret() / _right.Interpret();
        }
    }

    public class ExpressionParser
    {
        private static readonly Dictionary<string, int> OperatorPrecedence = new Dictionary<string, int>()
        {
            {"+", 1 },
            {"-", 1 },
            {"*", 2 },
            {"/", 2 }
        };

        public static IExpression<int> Parse(string expression)
        {
            char[] tokens = expression.ToCharArray();
            Stack<IExpression<int>> stack = new Stack<IExpression<int>>();
            Stack<string> operators = new Stack<string>();
            foreach (char token in tokens)
            {
                if (string.IsNullOrEmpty(token.ToString()))
                {
                    continue;
                }
                else if (int.TryParse(token.ToString(), null, out int num))
                {
                    stack.Push(new TerminalExpression(num));
                }
                else if (OperatorPrecedence.ContainsKey(token.ToString()))
                {
                    while (operators.Count > 0 &&
                           OperatorPrecedence.ContainsKey(operators.Peek()) &&
                           OperatorPrecedence[operators.Peek()] >= OperatorPrecedence[token.ToString()])
                    {
                        string op = operators.Pop();
                        ApplyOperator(op, ref stack);
                    }
                    operators.Push(token.ToString());
                }
            }

            while (operators.Count > 0)
            {
                ApplyOperator(operators.Pop(), ref stack);
            }
            return stack.Pop();
        }

        private static void ApplyOperator(string op, ref Stack<IExpression<int>> stack)
        {
            if (stack.Count < 2)
            {
                throw new ArgumentException("Non valid expression!");
            }
            IExpression<int> right = stack.Pop();
            IExpression<int> left = stack.Pop();

            IExpression<int> operation = op switch
            {
                "+" => new AddExpression(left, right),
                "-" => new SubtractExpression(left, right),
                "*" => new MultiplyExpression(left, right),
                "/" => new DivideExpression(left, right),
                _ => throw new ArgumentException($"the value:\"{op}\" is not a valid operator; therefore it shouldn\'t have been passed" +
                                                 $"to this case in the switch statement")
            };
            stack.Push(operation);
        }
    }
}
