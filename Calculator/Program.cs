namespace ConsoleCalculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            Calc calcEngine = new Calc();

            //Calculator body
            Console.WriteLine("Input the first number");
            calcEngine.firstOperand = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the second number");
            calcEngine.secondOperand = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What operation would you like to carry out? add, subtract, multiply, divide");
            //Initialize answer variable
            int ans = 0;
            calcEngine.mathOperation = Console.ReadLine().ToString();

            if (calcEngine.mathOperation == "add")
            {
                ans = calcEngine.Add(calcEngine.firstOperand, calcEngine.secondOperand);
                Console.WriteLine($"The answer is {ans}");
            }
            else if (calcEngine.mathOperation == "subtract")
            {
                ans = calcEngine.Subtract(calcEngine.firstOperand, calcEngine.secondOperand);
                Console.WriteLine($"The answer is {ans}");
            }
            else if (calcEngine.mathOperation == "multiply")
            {
                ans = calcEngine.Multiply(calcEngine.firstOperand, calcEngine.secondOperand);
                Console.WriteLine($"The answer is {ans}");
            }
            else if (calcEngine.mathOperation == "divide")
            {
                ans = calcEngine.Divide(calcEngine.firstOperand, calcEngine.secondOperand);
                Console.WriteLine($"The answer is {ans}");
            }
            else
            {
                Console.WriteLine("Wrong mathematical operation!!!");
            }
        }
    }
}