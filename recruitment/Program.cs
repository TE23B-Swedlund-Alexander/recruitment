string enemyName = "";

List<string> names = ["buster", "terry", "tom", "jerry"];
List<string> recruits = new List<string>();

while (names.Count > 2)
{
    for (int i = 0; i < names.Count; i++)
    {
        Console.WriteLine("choices");
        Console.WriteLine(names[i]);
    }
    Console.WriteLine();
    Console.WriteLine("choose 1");
   string choice = Console.ReadLine();
    for (int i = 0; i < recruits.Count; i++)
    {
        Console.WriteLine("gang");
        Console.WriteLine(recruits[i]);
    }
    Console.WriteLine();
    
}

//names.Add ("aaadd");
//names.Remove("crazy");
//names.RemoveAt(2);
//names[0]= "alexander";
//
//int i = Random.Shared.Next(names.Count);
//Console.WriteLine(names[i]);

Console.ReadLine();