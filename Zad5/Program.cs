using System;

// Zaimportowanie przestrzeni nazw zawierającej implementacje struktur danych

using System.Collections.Generic;

namespace Zadanie5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // Utworzenie obiektu Tab
            var x = new Tab();
            // Wywołanie metody Add
            x.Add(5);
        }
    }

    class Tab
    {
        // Pole klasy
        private List<int> _lista = new List<int>();
        // Konstruktor bezparametrowy
        public Tab() { }
        public void Add(int number)
        {
            _lista.Add(number);
        }
        public bool Contains(int number)
        {
            return _lista.Contains(number);
        }
    }
}