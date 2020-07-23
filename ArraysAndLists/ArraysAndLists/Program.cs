using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {

        string[] String1 = { "Snap", "Crackle", "Pop" };
        Console.WriteLine("Select an index of an array between 0 and 2");
        int indexSelect = Convert.ToInt32(Console.ReadLine());
        if (indexSelect > 2)
        {
            Console.WriteLine("Sorry, that index does not exist");
        }
        else
        {
            Console.WriteLine("You selected " + String1[indexSelect]);
        }
        
        Console.ReadLine();


        int[] selectNum = { 2, 4, 12, 42, 88, 244, 326, 488, 592, 698 };
        Console.WriteLine("Select an index of an array between 0 and 9");
        int selectedIndex = Convert.ToInt32(Console.ReadLine());
        if (selectedIndex > 9)
        {
            Console.WriteLine("Sorry, that index doesn't exist");
        }
        else
        {
            Console.WriteLine("You selected " + selectNum[selectedIndex]);
        }
        
        Console.ReadLine();


        List<string> cerealList = new List<string>() { "Rice Krispies", "Cinnamoon Toast Crunch", "Golden Grahams", "Cheerios", "Grape Nuts", "Kix" };
                Console.WriteLine("Select an index between 0 and 5.");
        int cerealSelection = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("You selected " + cerealList[cerealSelection]);
        Console.ReadLine();


    }
}

