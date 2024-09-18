int numberA;
int numberB;
int modulo;

Console.WriteLine("Your first number is: ");
numberA = Convert.ToInt32(Console.ReadLine());
    
Console.WriteLine("Your second number is: ");
numberB = Convert.ToInt32(Console.ReadLine());

modulo = numberA % numberB;

Console.WriteLine($"The remainder of {numberA} divided by {numberB} is: {modulo}");