using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH10_3
{
    internal class Car
    {       
        private double price;
        public string Name { get; set; }
               
        public Car(string name, double price)
        {
            this.Name = name;
            this.price = price;
        }
                
        public double GetPrice()
        {
            return price;
        }
                
        public string GetName()
        {
            return Name;
        }
    }

}
