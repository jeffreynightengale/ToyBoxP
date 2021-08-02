using System;
using System.Collections.Generic;
using System.Text;

namespace ToyBox
{
    class ToyBox
    {
        public List<string> Toys { get; set; }
        public string Owner { get; set; }
        public string Location { get; set; }
        public ToyBox()
        {
            Toys = new List<string>();
            Owner = string.Empty;
            Location = string.Empty;
        }
        
    }
}
