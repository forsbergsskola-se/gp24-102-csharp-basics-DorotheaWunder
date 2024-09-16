Console.WriteLine("Give me a number");

var inputNr = double. Parse(Console. ReadLine());
Console.WriteLine(inputNr);

//for whatever reason the number is rounded up if nr behind comma is > 5
int integerNr = Convert.ToInt32(inputNr);
Console.WriteLine(integerNr);