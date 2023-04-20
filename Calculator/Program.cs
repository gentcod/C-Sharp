namespace ConsoleCalculator
{
   public class Program
   {
      static void Main(string[] args)
      {
         Calc calcEngine = new Calc();

         //Calculator body
         Console.WriteLine("Input the first number");
         int firstNum = Convert.ToInt32(Console.ReadLine());

         Console.WriteLine("Input the second number");
         int secondNum = Convert.ToInt32(Console.ReadLine());

         Console.WriteLine("What operation would you like to carry out? add, subtract, multiply, divide");
         string operation = Console.ReadLine().ToString();

         calcEngine.Calculate(firstNum, secondNum, operation);
      }
   }
}