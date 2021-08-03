using System;
using System.Collections.Generic;

namespace Classes_ToyBox
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ToyBox> toyboxes = new List<ToyBox>();

            do
            {
                ToyBox tb1 = new ToyBox();
                Console.WriteLine("Who is the owner of this toy box?>>");
                tb1.Owner = Console.ReadLine();
                Console.WriteLine("Where is the location of this toy box?>>");
                tb1.Location = Console.ReadLine();
               
                toyboxes.Add(tb1);
                Console.WriteLine($"Do you have another ToyBox to enter? yes or no >>");
            } while (Console.ReadLine().ToLower()[0] == 'y');

            for (int i = 0; i < toyboxes.Count; i++)
            {
                Console.WriteLine($"Time to fill {toyboxes[i].Owner}'s ToyBox!");

                do
                {
                    Toy toy1 = new Toy();
                    Console.WriteLine("Enter Manufacturer of the Toy >>");
                    toy1.Manufacturer = Console.ReadLine();
                    Console.WriteLine("Enter the Name of the Toy >>");
                    toy1.Name = Console.ReadLine();
                    Console.WriteLine("Enter the Price of the Toy >>");
                    toy1.Price = Convert.ToDouble(Console.ReadLine());
                    do
                    {
                        Console.WriteLine("Please enter a note");
                        toy1.GettingNotes(Console.ReadLine());

                        Console.WriteLine($"Do you have another note?");
                    } while (Console.ReadLine().ToLower()[0] == 'y');
                    //toy1.GettingNotes("Crazy fun for the whole family!");
                    //toy1.GettingNotes("Ages 5+");

                    toyboxes[i].Toys.Add(toy1);

                    Console.WriteLine($"Do you have another toy to enter for {toyboxes[i].Owner}'s ToyBox? yes or no >>");
                } while (Console.ReadLine().ToLower()[0] == 'y');
            }

            foreach (ToyBox currentToyBox in toyboxes)
            {
                Console.WriteLine($"{currentToyBox.Owner}'s ToyBox is located @ {currentToyBox.Location}.  The ToyBox has {currentToyBox.Toys.Count} toys inside of it:");
                foreach (Toy toyInCurrentBox in currentToyBox.Toys)
                {
                    Console.WriteLine(toyInCurrentBox);
                }
            }

            foreach (ToyBox randomToy in toyboxes)
            {
                Console.WriteLine($"A random toy from {randomToy.Owner}'s toybox is: {randomToy.GetRandomToy().Name}");
            }


                /*Dictionary<string, List<Toy>> toyboxes = new Dictionary<string, List<Toy>>();
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

                    do
                    {
                        Toy newToy = new Toy();
                        Console.WriteLine("Enter Manufacturer of the Toy >>");
                        newToy.Manufacturer = Console.ReadLine();
                        Console.WriteLine("Enter the Name of the Toy >>");
                        newToy.Name = Console.ReadLine();
                        Console.WriteLine("Enter the price of the Toy >>");
                        newToy.Price = Convert.ToDouble(Console.ReadLine());
                        //Console.WriteLine("Do you want to add more notes to this toy?");
                        //toy1.GettingNotes("Crazy fun for the whole family!");
                        //toy1.GettingNotes("Ages 5+");

                        toyboxes[tb.Owner + " " + tb.Location].Add(newToy);

                        Console.WriteLine($"Do you have another toy to enter for {tb.Owner}'s ToyBox? yes or no >>");
                        newToy = new Toy();
                    } while (Console.ReadLine().ToLower()[0] == 'y');

                Console.WriteLine($"Do you have another ToyBox to enter? yes or no >>");
                } while (Console.ReadLine().ToLower()[0] == 'y');



                foreach (var item in toyboxes)
                {
                    string[] split = item.Key.Split(' ');
                    for (int i = 0; i < item.Value.Count; i++)
                    {
                        //tb.Toys.Add(item.Value[i]);
                        Console.WriteLine($"A random toy in {split[i]}'s toy box is: {tb.GetRandomToy()}");
                    }

                }*/


            }
    }
}
