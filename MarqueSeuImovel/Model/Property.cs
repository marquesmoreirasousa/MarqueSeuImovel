﻿using System;
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

        public Property(int codProperty, string objective, 
            string city, float price): this (objective, city, price)
        {
            CodProperty = codProperty;
        }

        public Property(string objective, string city, float price)
        {
            Objective = objective;
            City = city;
            Price = price;
        }

        public Property(int codProperty, string city)
        {
            CodProperty = codProperty;
            City = city;
        }
    }
}
