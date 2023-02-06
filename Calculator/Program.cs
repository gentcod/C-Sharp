//Calculator body
Console.WriteLine("Input the first number");
int firstNum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input the second number");
int secondNum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("What operation would you like to carry out? add, subtract, multiply, divide");
string mathOp = Console.ReadLine();

//Initialize answer variable
int ans;
//Import calculator function
Calc calcEngine = new Calc();

if (mathOp == "add")
{
    ans = calcEngine.Add(firstNum, secondNum);
    Console.WriteLine($"The answer is {ans}");
}
else if (mathOp == "subtract")
{
    ans = calcEngine.Subtract(firstNum, secondNum);
    Console.WriteLine($"The answer is {ans}");
}
else if (mathOp == "multiply")
{
    ans = calcEngine.Multiply(firstNum, secondNum);
    Console.WriteLine($"The answer is {ans}");
}
else if (mathOp == "divide")
{
    ans = calcEngine.Divide(firstNum, secondNum);
    Console.WriteLine($"The answer is {ans}");
}
else
{
    Console.WriteLine("Wrong mathematical operation!!!");
}