int age = 0;
bool isChild;
bool isTeenager;
bool isAdult;

Console.WriteLine("What is your age?");
int ageInput = Convert.ToInt32(Console.ReadLine());
age = +ageInput;

Console.WriteLine(age);

isChild = age <= 12;
isTeenager = age > 12 && age <= 19;
isAdult = age > 19;

Console.WriteLine("You are a child " + isChild);
Console.WriteLine("You are a teenager " + isTeenager);
Console.WriteLine("You are an adult " + isAdult);