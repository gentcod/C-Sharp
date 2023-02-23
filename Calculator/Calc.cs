//Create calculate function that can be called by every file
namespace ConsoleCalculator
{
    public class Calc
    {
        public int firstOperand;
        public int secondOperand;
        public string mathOperation;

        //public Calc(int firstNum, int secondNum, string mathOp) 
        public Calc()
        {
            
        }

        public int Add(int operand1, int operand2)
        {
            return operand1 + operand2;
        }

        public int Subtract(int operand1, int operand2)
        {
            return operand1 - operand2;
        }

        public int Multiply(int operand1, int operand2)
        {
            return operand1 * operand2;
        }

        public int Divide(int operand1, int operand2)
        {
            return operand1 / operand2;
        }

    }
}