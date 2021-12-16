// See https://aka.ms/new-console-template for more information
int userInput;
Console.WriteLine("Podaj liczbę: ");
userInput = int.Parse(Console.ReadLine());

int userInt;
Console.WriteLine(userInput.GetType());
userInt = userInput;

if (userInput % 2 == 0 && userInput>0)
{
    Console.WriteLine("Liczba jest parzysta i dodatnia");
}
else if(userInput % 2 != 0 && userInput < 0)
{
    Console.WriteLine("Liczba jest nieparzysta i ujemna");
}
else if(userInput % 2 == 0 && userInput < 0)
{
    Console.WriteLine("Liczba jest parzysta i ujemna");
}
else if (userInput % 2 != 0 && userInput > 0)
{
    Console.WriteLine("Liczba jest nieparzysta i dodatnia");
}