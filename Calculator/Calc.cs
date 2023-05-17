namespace ConsoleCalculator;

public class Calc
{
   public int firstOperand;
   public int secondOperand;
   private readonly List<string> _mathOperation = new List<string> { "add", "subtract", "divide", "multiply" };

   //public Calc(int firstNum, int secondNum, string mathOp) 
   public Calc() { }

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

      //Initialize answer variable
      int ans = 0;

      if (operation != null)
      {
         string opr = operation.ToLower();

         if (_mathOperation.Contains(opr))
         {
            if (opr == "add")
               ans = Add(firstOperand, secondOperand);

            if (opr == "subtract")
               ans = Subtract(firstOperand, secondOperand);

            if (opr == "multiply")
               ans = Multiply(firstOperand, secondOperand);

            if (opr == "divide")
               ans = Divide(firstOperand, secondOperand);

            Console.WriteLine($"The answer is {ans}");
         }

         else
         {
            Console.WriteLine("This operation is wrong, run the application again");
            return;
         }
      }
    }

}