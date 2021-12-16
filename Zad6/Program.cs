
string[] lines = System.IO.File.ReadAllLines(@"E:\Iris.csv");
foreach (string line in lines)
{
    Console.WriteLine(line);
}