int d, i, j, n, p, k,u;
string a, b;
Console.WriteLine("Podaj wysokosc choinki: ");
n = int.Parse(Console.ReadLine());
a = "#";
b = " ";
d = n;
u = n;
for (i = 1; i <= n; i++)
{
    for (j = 1; j < d; j++)
    {
        Console.Write(b);
    }
    for (p = 1; p <= i; p++)
    {
        Console.Write(a);
    }
    for (k = 1; k <= i - 1; k++)
    {
        Console.Write(a);
    }
    d--;
    Console.WriteLine();
}

int l = 0; 
for (int t= u-1; l < t; t--)
{
    Console.Write(" ");
}
Console.WriteLine("#");