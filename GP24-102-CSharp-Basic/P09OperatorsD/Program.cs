int numberA;
int numberB;
float result;

Console.WriteLine("Your first number is:");
numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Your second number is:");
numberB = Convert.ToInt32(Console.ReadLine());

float numberAfloat = (float)numberA;
float numberBfloat = (float)numberB;
result = numberAfloat / numberBfloat;

Console.WriteLine($"{numberA} divided by {numberB} = {result}");