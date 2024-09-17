Console.WriteLine("Enter a letter");
string inputLetter = Console.ReadLine();

string typeLetter;
//I'm pretty sure there is a more elegant and less cluttered solution -.-
if (inputLetter == "a" || inputLetter == "e" || inputLetter == "i" || inputLetter == "o" || inputLetter == "u")
{
    typeLetter = "vowel";
}
else
{
    typeLetter = "consonant";
}

Console.WriteLine("Your letter is " + inputLetter + " so your letter is a " + typeLetter);