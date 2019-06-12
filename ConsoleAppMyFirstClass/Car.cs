using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppMyFirstClass
{
    class Car
    {
        static int carsCreated = 0;
        public static int CarsCreated
        {
            get
            {
                return carsCreated;
            }

            private set
            {
                carsCreated = value;
            }
        }

        //Any method or field will be private by defualt
        public string brand;
        public string modelName;
        public string color;
        public int year;
        public int miles;
        public int speed;

        public Car( string brand,
                    string modelName, 
                    string color, 
                    int year, 
                    int miles, 
                    int currentSpeed)
        {
            this.brand = brand;
            this.modelName = modelName;
            this.color = color;
            this.year = year;
            this.miles = miles;
            speed = currentSpeed;

            CarsCreated++;
        }

        public override string ToString()
        {
            return $"Car:\nBrand - {brand}\nModel - {modelName}\nColor - {color}\nYear - {year}\nMiles - {miles}\nCurrent speed = {speed}";
        }
    }
}
