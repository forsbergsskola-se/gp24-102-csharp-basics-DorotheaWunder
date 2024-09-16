int age;

Console.WriteLine("What is your age?");
string inputStringAge = Console.ReadLine();
int nrAge = Convert.ToInt32(inputStringAge);
age =  +nrAge;

Console.WriteLine(nrAge);

bool isChild = age <= 12;
//bool isTeenager = age <= 13 || age >= 19;
bool isTeenager = !(age <12 || age >= 20);
bool isAdult = age > 19;

Console.WriteLine("You are a child: " + isChild);
Console.WriteLine("You are a teenager: " + isTeenager);
Console.WriteLine("You are an adult: " + isAdult);

