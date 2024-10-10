using System.Text;

string charSelection = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%";
var stringOutput = new StringBuilder();
Random random = new Random();

for (int i = 0; i < 6; i++ )
{
	var randomPickPosition = random.Next(charSelection.Length);
	var randomAddChar = charSelection[randomPickPosition];
	stringOutput= stringOutput.Append(randomAddChar);
}
	
Console.WriteLine($"Your new password is: {stringOutput}");