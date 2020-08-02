using System;
using System.Collections.Generic;


namespace IterationAndLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a one - dimensional Array of strings.
            //Ask the user to input some text.
            //Create a loop that goes through each string in the Array, adding the user’s text to the string.
            //Then create a loop that prints off each string in the Array on a separate line.

            Console.WriteLine("Enter your First Name to see what it would look like with a list of possible new Last Names.");

            string fName = Console.ReadLine();

            string[] LNameList = { "Johnson", "Smith", "Greenberg", "Torrey", "Parker", "Lewis" };

            for (int j = 0; j < LNameList.Length; j++)

            {
                Console.WriteLine(fName + " " + LNameList[j]);
            }


            ////Create an infinite loop.
            ///it is commented out so the rest of the program will run.
            //while (true)
            //{
            //    Console.WriteLine("Here is an infinte loop.  Keep pressing ENTER and it will never end!");
            //    Console.ReadLine();
            //    break;
            //}



            //Create a loop where the comparison that’s used to determine whether to continue iterating the loop is a “<” operator.

            string[] names = { "Abby", "Brian", "Cara", "Denise", "Evan", "Farrah" };

            Console.WriteLine("Names that start with the first five letters of the alphabet...");
            for (int i = 0; i < 5; i++)
            {
                if (i <= 5)
                {
                    Console.WriteLine(names[i]);
                }
            }
            Console.ReadLine();
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();


            //Create a loop where the comparison that’s used to determine whether to continue iterating the loop is a “<=” operator.

            Console.WriteLine("Names that start with the first six letters of the alphabet...");
            for (int i = 0; i <= 5; i++)
            {
                if (i <= 5)
                {
                    Console.WriteLine(names[i]);
                }
            }
            Console.ReadLine();
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();



            //Create a List of strings where each item in the list is unique.Ask the user to input text to search for in the List.
            //Create a loop that iterates through the loop and then displays the index of the array that contains matching text on the screen.
            //Add code to that above loop that tells a user if they put in text that isn’t in the List.
            //Add code to that above loop that stops it from executing once a match has been found.

            List<string> fruits = new List<string>() { "apple", "peach", "banana", "strawberry", "lemon", "raspberry", "grapes", "watermelon" };

            Console.WriteLine("What is your favorite fruit of the following: apple, peach, banana, strawberry, lemon, raspberry, grapes, or watermelon");
            string choseFruit = Console.ReadLine();
            bool isPresent = false;

            foreach (string fruit in fruits)
            {
                if (fruit == choseFruit)
                {
                    Console.WriteLine("The index of that fruit is " + fruits.IndexOf(choseFruit));
                    isPresent = true;
                    break;
                }
            }
            if (!isPresent)
            {
                Console.WriteLine("You did not chose a fruit from the list.");
            }
                Console.ReadLine();
                Console.WriteLine("Press enter to continue");
                Console.ReadLine();

            //Create a List of strings that has at least two identical strings in the List. Ask the user to select 
            //text to search for in the List.Create a loop that iterates through the loop and then displays the 
            //indices of the array that contain matching text on the screen.

            List<string> animals = new List<string>() { "dog", "cat", "bear", "cheetah", "bear", "monkey", "rat", "buffalo" };
            Console.WriteLine("Please type an animal from the list: dog, cat, bear, cheetah, monkey, rat, buffalo");
            string choseAnimal = Console.ReadLine();
            bool isPres = false;

            for (int i = 0; i < animals.Count; i++)
            {
                if (animals[i] == choseAnimal)
                {
                    Console.WriteLine("The index(es) of that animal: " + i);
                    isPres = true;                 
                }
            }
            if (!isPres)
            {
                Console.WriteLine("You did not enter an animal on my list");
            }
                Console.ReadLine();
                Console.WriteLine("Press enter to continue");
                Console.ReadLine();

            //Create a List of strings that has at least two identical strings in the List. Create a foreach loop that evaluates 
            //each item in the list, and displays a message showing the string and whether or not it has already appeared in the list.

            List<string> clothing = new List<string>() {"pants", "shirt", "sweater", "pants", "socks", "tie", "jacket"};
            List<string> clothing2 = new List<string>();

            Console.WriteLine("Packing List: ");
            foreach (string clothes in clothing)
            {
                if (clothing2.Contains(clothes) == clothing.Contains(clothes))
                {
                    Console.WriteLine(clothes + " is a duplicate clothing item");
                }
                else
                {
                    clothing2.Add(clothes);
                    Console.WriteLine(clothes);
                }
            }
            Console.ReadLine();

        }
    }
}
