using System;
using System.Collections.Generic;
using System.Text;

namespace ShouldIPizza
{
    public class Topping
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salt { get; set; }
        public int Sweet { get; set; }
        public int Bite { get; set; }
        public int Rich { get; set; }
        public int Umami { get; set; }
        public int Spicy { get; set; }

        public Topping(int id, string name, int salt, int sweet, int bite, int rich, int umami, int spicy)
        {
            Id = id;
            Name = name;
            Salt = salt;
            Sweet = sweet;
            Bite = bite;
            Rich = rich;
            Umami = umami;
            Spicy = spicy;
        }

        public override string ToString()
        {
            return $"Don't you just love {Name}?!";
           
        }
    }
}
