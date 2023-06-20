using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_1
{
    public class AirConditioner : AirConditionerFactory
    {
        public string Model { get; set; }
        public double Price { get; set; }
        public int YearOfManifacture { get; set; }
        public int Power { get; set; }

        public AirConditioner(string model, double price, int yearOfManifacture, int power) 
        {
            Model = model;
            Price = price;
            YearOfManifacture = yearOfManifacture;
            Power = power;
        }
    }
}
