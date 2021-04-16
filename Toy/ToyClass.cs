using System;
using System.Collections.Generic;
using System.Text;

namespace Toy
{
    class ToyClass
    {
        public string Manufactuer { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        private string Notes { get; set; }
        public ToyClass()
        {
            Manufactuer = string.Empty;
            Name = string.Empty;
            Price = 0;
            Notes = string.Empty;
        
        }
        public ToyClass(string man, string name, double price, string notes)
        {
            Manufactuer = man;
            Name = name;
            Price = price;
            Notes = notes;
        }

        public string GetAisle()
        {
            Random rand = new Random();
            int randNum = rand.Next(1, 25);
            string temp = Manufactuer.ToUpper();
            temp = temp[0] + randNum.ToString();
            return temp;
        
        }
        public override string ToString()
        {
            return "Manufacurer: "+ Manufactuer+" Name: "+Name+" Price: "+Price+" Notes: "+Notes;
        }
    }
}
