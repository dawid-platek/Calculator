using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            byte number;
            number = 255;
            var number1 = 9999;

            number1 = 123;
            // Console.WriteLine(number1);
            var number2 = 123.456;
            var amount = 31.12m;
            var isReady = false;
            var name = "Programista";
            var letter = 'A';
            /* DateTime today = new DateTime(2025, 8, 8, 12, 0, 0);
            Robot robot = new Robot(); */
            var numbersList = new List<int>() { 1, 2, 3 };
            numbersList.Add(4);
            numbersList.Remove(2);
            Console.WriteLine(numbersList[1]);
            var namesList = new List<string>() { "Jan", "Adam", "Ewa" };
            var age = 20;
            var myAge = "30";
            // age = myAge; / błąd kompilacji, ponieważ typy są różne
            age = int.Parse(myAge); // konwersja string na int
            myAge = age.ToString(); // konwersja int na string




        }
    }
}
