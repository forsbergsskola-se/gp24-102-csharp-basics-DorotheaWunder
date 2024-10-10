int numberA;
int numberB;
int product;

Console.WriteLine("Type your fist number");
numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Type your second number");
numberB = Convert.ToInt32(Console.ReadLine());

product = numberA * numberB;

Console.WriteLine($"The product of {numberA} * {numberB} = {product}");