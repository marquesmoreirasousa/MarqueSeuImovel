using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarqueSeuImovel.Model
{
    internal class Property
    {
        public int CodProperty { get; set; }
        public string Objective { get; set; }
        public string City { get; set; }
        public float Price { get; set; }

        public Property(string objective, 
            string city, float price)
        {
            Objective = objective;
            City = city;
            Price = price;
        }
    }
}
