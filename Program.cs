// See https://aka.ms/new-console-template for more information
Console.WriteLine("Input the first number");
int firstNum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input the second number");
int secondNum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("What operation would you like to carry out? add, subtract, multiply, divide");
string mathOp = Console.ReadLine();

int ans;

if (mathOp == "add") {
   ans = firstNum + secondNum;
   Console.WriteLine($"The answer is {ans}");
}
else if (mathOp == "subtract") {
   ans = firstNum - secondNum;
   Console.WriteLine($"The answer is {ans}");
}
else if (mathOp == "multiply") {
   ans = firstNum * secondNum;
   Console.WriteLine($"The answer is {ans}");
}
else if (mathOp == "divide") {
   ans = firstNum / secondNum;
   Console.WriteLine($"The answer is {ans}");
}
else {
   Console.WriteLine("Wrong mathematical operation!!!");
}

// int sum = firstNum + secondNum;