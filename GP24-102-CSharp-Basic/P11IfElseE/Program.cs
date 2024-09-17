int numberA;
int numberB;
string operatorType;
int result;

Console.WriteLine("Enter your first number");
numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter your operator (+, -, *, /)");
operatorType = (Console.ReadLine());
Console.WriteLine("Enter your second number");
numberB = Convert.ToInt32(Console.ReadLine());

if (operatorType == "+")
{
    result = numberA + numberB;
}
else if (operatorType == "-")
{
    result = numberA - numberB;
}
else if (operatorType == "*")
{
    result = numberA * numberB;
}
else if (operatorType == "/")
{
    result = numberA / numberB;
}
else
{
    result = 0;
    Console.WriteLine("You didn't enter a valid operator");
}


Console.WriteLine(numberA + operatorType + numberB + "=" + result);




