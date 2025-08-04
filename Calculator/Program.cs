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
            int number1 = 9999;
            number1 = 123;
            // Console.WriteLine(number1);
            double number2 = 123.456;
            decimal amount = 31.12m;
            bool isReady = false;
            string name = "Programista";
            char letter = 'A';
            /* DateTime today = new DateTime(2025, 8, 8, 12, 0, 0);
            Robot robot = new Robot(); */
            List<int> numbersList = new List<int>() { 1, 2, 3 };
            numbersList.Add(4);
            numbersList.Remove(2);
            Console.WriteLine(numbersList[1]);
            List<string> namesList = new List<string>() { "Jan", "Adam", "Ewa" };
            int age = 20;
            string myAge = "30";
            // age = myAge; / błąd kompilacji, ponieważ typy są różne
            age = int.Parse(myAge); // konwersja string na int
            myAge = age.ToString(); // konwersja int na string




        }
    }
}
