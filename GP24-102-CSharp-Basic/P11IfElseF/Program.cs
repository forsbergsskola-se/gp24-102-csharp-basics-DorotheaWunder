int numberInput;

Console.WriteLine("Enter a number");
numberInput = Convert.ToInt32(Console.ReadLine());

int modulo = numberInput % 2;
if (modulo != 0)
{
    Console.WriteLine("Your number is " + numberInput + " Your number is odd");
}
else
{
    Console.WriteLine("Your number is " + numberInput + " Your number is even");
}