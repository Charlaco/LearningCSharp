using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStudies.Driver
{
    class Driver
    {
        // Class members 
        private string name;
        private double heigth;
        private Car car;

        // Class constructor
        public Driver(string name, double heigth, Car car)
        {
            this.name = name;
            this.heigth = heigth;
            this.car = car;
        }

        // Getters and setters

        public string getName()
            { return this.name; }
        public void setName(string name)
            { this.name = name; }

        public double getHeigth() 
            { return this.heigth; }
        public void setHeight(double height)
            { this.heigth = height; }   

        public Car getCar()
            { return this.car; }
        public void setCar(Car car)
            { this.car = car; }


        // To String 
        public override string ToString()
        {
            return this.name + ", " +
                this.heigth + ", " + this.car;
        }
    }
}
