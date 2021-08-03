using System;
using System.Collections.Generic;

namespace Classes_ToyBox
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<Toy>> toyboxes = new Dictionary<string, List<Toy>>();
            ToyBox tb = new ToyBox();
            
            do
            {
                Console.WriteLine("Who is the owner of this toybox?");
                tb.Owner = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Where is the location of this toybox?");
                tb.Location = Console.ReadLine();
                Console.WriteLine();

                toyboxes.Add(tb.Owner + " " + tb.Location, new List<Toy>());
                Console.WriteLine($"Do you have another ToyBox to enter? yes or no >>");
            } while (Console.ReadLine().ToLower()[0] == 'y');

            for (int i = 0; i < toyboxes.; i++)
            {
                Console.WriteLine($"Time to fill {toyboxes[i].Owner}'s ToyBox!");

                do
                {
                    Toy toy1 = new Toy();
                    Console.WriteLine("Enter Manufacturer of the Toy >>");
                    toy1.Manufacturer = Console.ReadLine();
                    Console.WriteLine("Enter the Name of the Toy >>");
                    toy1.Name = Console.ReadLine();
                    Console.WriteLine("Enter the price of the Toy >>");
                    toy1.Price = Convert.ToDouble(Console.ReadLine());
                    //Console.WriteLine("Do you want to add more notes to this toy?");
                    //toy1.GettingNotes("Crazy fun for the whole family!");
                    //toy1.GettingNotes("Ages 5+");


                    Console.WriteLine($"Do you have another toy to enter for {tb.Owner}'s ToyBox? yes or no >>");
                } while (Console.ReadLine().ToLower()[0] == 'y');
            }


        }
    }
}
