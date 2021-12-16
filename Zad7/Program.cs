string[] lines = System.IO.File.ReadAllLines(@"E:\Iris.csv");

foreach (string line in lines)
{
    string a = line;
    string[] subs = a.Split(',');

    foreach (string sub in subs)
    {
        Console.Write(sub);
        Console.Write(" ");
    }
    Console.WriteLine();
}
