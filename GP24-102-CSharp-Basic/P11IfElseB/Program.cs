int pointsGrade;
string letterGrade;

Console.WriteLine("How many points from 0 - 100 did you get in the test?");
pointsGrade = Convert.ToInt32(Console.ReadLine());

if (pointsGrade >= 90 && pointsGrade <= 100)
{
    letterGrade = "A";
}
else if (pointsGrade >= 80 && pointsGrade <= 89)
{
    letterGrade = "B";
}
else if (pointsGrade >= 70 && pointsGrade <= 79)
{
    letterGrade = "C";
}
else if (pointsGrade >= 60 && pointsGrade <= 69)
{
    letterGrade = "D";
}
else if (pointsGrade < 60)
{
    letterGrade = "F";
}
else
{
    letterGrade = "an F- because you don't know how to enter a correct number or you cheated!";
}



Console.WriteLine($"You got {pointsGrade} points. That means your grade is {letterGrade}");