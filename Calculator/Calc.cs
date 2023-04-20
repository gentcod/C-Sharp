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

        public void Calculate(int operand1, int operand2, string operation)
        {
            firstOperand = operand1;
            secondOperand = operand2;
            mathOperation = operation;

            //Initialize answer variable
            int ans = 0;

            if (mathOperation != null)
            {
                if (mathOperation == "add")
                {
                    ans = Add(firstOperand, secondOperand);
                    Console.WriteLine($"The answer is {ans}");
                }
                else if (mathOperation == "subtract")
                {
                    ans = Subtract(firstOperand, secondOperand);
                    Console.WriteLine($"The answer is {ans}");
                }
                else if (mathOperation == "multiply")
                {
                    ans = Multiply(firstOperand, secondOperand);
                    Console.WriteLine($"The answer is {ans}");
                }
                else if (mathOperation == "divide")
                {
                    ans = Divide(firstOperand, secondOperand);
                    Console.WriteLine($"The answer is {ans}");
                }
                else
                {
                    Console.WriteLine("Wrong mathematical operation!!!");
                }
            }
        }

    }
}