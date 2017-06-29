using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CntrlFlowPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problem #1

            Console.WriteLine("Enter two numbers to see if they are equal.");

            Console.WriteLine("First Number: ");
            int userNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Second Number: ");
            int userNumberTwo = int.Parse(Console.ReadLine());

            if (userNumber == userNumberTwo)
            {
                Console.WriteLine("These numbers are equal!");
            }
            else
            {
                Console.WriteLine("These numbers are not equal.");
            }
            Console.ReadLine();

            //Problem #2

            Console.WriteLine("Please enter a number to see if it is even or odd.");
            int userValue = int.Parse(Console.ReadLine());

            if (userValue % 2 == 0)
            {
                Console.WriteLine("This number is even.");
            }
            else
            {
                Console.WriteLine("This number is odd.");
            }
            Console.ReadLine();

            //Problem #3

            Console.WriteLine("Enter a number to see if it is positive or negative");
            int enteredNumber = int.Parse(Console.ReadLine());

            if (enteredNumber <= 0)
            {
                Console.WriteLine("Number is negative");
            }
            else
            {
                Console.WriteLine("Number is positive");
            }
            Console.ReadLine();

            //Problem #4

            Console.Write("Enter any letter of the alphabet to see if it is a vowel or a consonant: ");
            string letter = Console.ReadLine();

            if (letter == "a")
            {
                Console.WriteLine("This letter is a vowel.");
            }
            else if (letter == "e")
            {
                Console.WriteLine("This letter is a vowel.");
            }
            else if (letter == "i")
            {
                Console.WriteLine("This letter is a vowel.");
            }
            else if (letter == "o")
            {
                Console.WriteLine("This letter is a vowel.");
            }
            else if (letter == "u")
            {
                Console.WriteLine("This letter is a vowel.");
            }
            else if (letter == "y")
            {
                Console.WriteLine("This letter is a vowel.");
            }
            else
            {
                Console.WriteLine("This letter is a consonant");
            }
            Console.ReadLine();

            //Problem #5

            Console.WriteLine("Enter any two numbers to find out which is greater");            

            Console.Write("First Number: ");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Second Number: ");
            int secondNumber = int.Parse(Console.ReadLine());

            if (firstNumber > secondNumber)
            {
                Console.WriteLine(firstNumber + " is greater");
            }
            else if (secondNumber > firstNumber)
            {
                Console.WriteLine(secondNumber + " is greater");
            }
            Console.ReadLine();

            //Bonus
            Console.WriteLine("Enter any three numbers to find out which is greater");

            Console.Write("First Number: ");
            int numberOne = int.Parse(Console.ReadLine());
            Console.Write("Second Number: ");
            int numberTwo = int.Parse(Console.ReadLine());
            Console.Write("Third Number: ");
            int numberThree = int.Parse(Console.ReadLine());

            if (numberOne > numberTwo)
            {
                Console.WriteLine(numberOne + " is greater");
            }
            if (numberOne > numberThree)
            {
                Console.WriteLine(numberOne + " is greater");
            }
            else if (numberTwo > numberOne)
            {
                Console.WriteLine(numberTwo + " is greater");
            }
            else if (numberTwo > numberThree)
            {
                Console.WriteLine(numberTwo + " is greater");
            }
            else if (numberThree > numberOne)
            {
                Console.WriteLine(numberThree + " is greater");
            }
            else if (numberThree > numberTwo)
            {
                Console.WriteLine(numberThree + " is greater");
            }
            Console.ReadLine();

            //Problem #6
            
            Console.WriteLine("Enter four numbers to find out the mean");

            Console.Write("First Number: ");
            int numeroUno = int.Parse(Console.ReadLine());
            Console.Write("Second Number: ");
            int numeroDos = int.Parse(Console.ReadLine());
            Console.Write("Third Number: ");
            int numeroTres = int.Parse(Console.ReadLine());
            Console.Write("Fourth Number: ");
            int numeroQuatro = int.Parse(Console.ReadLine());

            int total = (numeroUno + numeroDos + numeroTres + numeroQuatro);
                Console.WriteLine("The mean of these four numbers is " + total / 4);

            Console.ReadLine();     

        }
    }
}
