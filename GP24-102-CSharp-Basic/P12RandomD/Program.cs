Random random = new Random();
string[] itemList;
int listPosition;
string itemChoice;

itemList = new string [] { "Sword", "Bow", "Spear", "Club", "Axe" };
listPosition = random.Next(itemList.Length);
itemChoice = itemList[listPosition];

Console.WriteLine($"Congratulations, you got: {itemChoice}");