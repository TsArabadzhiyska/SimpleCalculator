using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
     abstract class Operation
     {
        public abstract decimal MathOperation(decimal currentval, decimal secondval);


    }
    class Division:Operation
    {
        public override decimal MathOperation(decimal currentval, decimal secondval)
        {
                try
                {
                return currentval /= secondval;
                }
                catch (DivideByZeroException)
                {

                    throw;
                }
            throw new NotImplementedException();
        }
    }
    class Multiplication:Operation
    {
        public override decimal MathOperation(decimal currentval, decimal secondval)
        {
            return currentval *= secondval;
            throw new NotImplementedException();
        }
    }
    class Substraction : Operation
    {
        public override decimal MathOperation(decimal currentval, decimal secondval)
        {
            return currentval -= secondval;
            throw new NotImplementedException();
        }
    }
    class Addition : Operation
    {
        public override decimal MathOperation(decimal currentval, decimal secondval)
        {
            return currentval += secondval;
            throw new NotImplementedException();
        }
    }
   
}
