using System;
using System.Collections.Generic;
using System.Text;

namespace ToyBox
{
    class Toy
    {
        public string Manufacturer { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        private string Notes;
        public Toy()
        {
            Manufacturer = string.Empty;
            Name = string.Empty;
            Price = 0;
        }
        public Toy(string notes)
        {
            Notes = notes;
        }
        public void GettingNotes(string note)
        {
            Notes += note;
        }
        public string ReturningNotes()
        {
            return Notes;
        }
        public string GetAisle()
        {
            Random rand = new Random();
            int randomNum = rand.Next(1, 25);

            string aisleNumber = $"{Manufacturer[0]}{randomNum}";
            return aisleNumber;
        }
    }
}
