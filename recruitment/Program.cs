
List<string> names = ["buster", "terry", "tom", "jerry"];
List<string> recruits = [];
bool realChoice = false;
string choice = "placeholder";
while (names.Count > 2)
{
    Console.WriteLine("choices");
    Console.WriteLine();
    for (int i = 0; i < names.Count; i++)
    {
        Console.WriteLine(names[i]);
    }
    Console.WriteLine();
    Console.WriteLine("choose 1 by writing their name");
    while (realChoice == false)
    {
        choice = Console.ReadLine();
        realChoice = names.Contains(choice);

    }
    recruits.Add(choice);
    names.Remove(choice);
    Console.WriteLine("your group");
    for (int i = 0; i < recruits.Count; i++)
    {
        Console.WriteLine(recruits[i]);
    }
    Console.WriteLine();
    realChoice = false;

}
Console.WriteLine("your final group");
Console.WriteLine(recruits[0]);
Console.WriteLine(recruits[1]);
Console.ReadLine();