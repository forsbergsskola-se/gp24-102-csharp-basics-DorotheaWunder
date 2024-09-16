Console.WriteLine("Give me a number");

string inputNrString = Console.ReadLine();
double inputNrFloat = Convert.ToDouble(inputNrString);

Console.WriteLine(inputNrFloat);

//for whatever reason the number is rounded up if nr behind comma is >= 5
int integerNr = Convert.ToInt32(inputNrFloat);
Console.WriteLine(integerNr);

int doesntWork = Convert.ToInt32(inputNrString);
Console.WriteLine(doesntWork);