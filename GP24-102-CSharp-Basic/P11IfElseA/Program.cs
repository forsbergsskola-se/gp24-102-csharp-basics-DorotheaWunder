int age;
Console.WriteLine("What is your age?");
int ageInput = Convert.ToInt32(Console.ReadLine());
age = ageInput;
Console.WriteLine("Your age is " + ageInput);

if (age <=12)
{
    Console.WriteLine("You are a child");
}
else if(age > 12 && age <= 19)
{
    Console.WriteLine("You are a teenager");
}
else
{
    Console.WriteLine("You are an adult. Go do your taxes!");
}

Console.WriteLine("Now give me another number");
int numberInput = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Your other number is " + numberInput);

if (age < numberInput)
{
    Console.WriteLine("You new number " + numberInput + " is bigger than your age of " + age);
}
else if(age == numberInput)
{
    Console.WriteLine("You new number " + numberInput + " is the same as your age of " + age);
}
else
{
    Console.WriteLine("You new number " + numberInput + " is less than your age of " + age);
}

int modulo = numberInput % 2;
if (modulo != 0)
{
    Console.WriteLine("By the way, your new number " + numberInput + " is an odd number");
}
else
{
    Console.WriteLine("By the way, your new number " + numberInput + " is an even number");
}
