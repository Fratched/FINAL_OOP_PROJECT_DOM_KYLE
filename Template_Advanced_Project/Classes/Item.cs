using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Advanced_Project.Classes
{
    public class Item
    {
        private string name;
        private string price;


        public string Name { get => name; set => name = value; }
        public string Price { get => price; set => price = value; }


        public Item(string name, string price)
        {
            this.name = name;
            this.price = price;
        }

        public override string ToString()
        {

            return "Item: " + Name + ", Price: " + Price;


        }

     
    }
}
