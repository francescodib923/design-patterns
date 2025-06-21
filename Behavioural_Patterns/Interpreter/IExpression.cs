using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioural_Patterns.Interpreter
{
    public interface IExpression<T>
    {
        public T Interpret();
    }
}
