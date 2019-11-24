using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectLifetime
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();

            /*
            myCar.Make = "Oldsmobile";
            myCar.Model = "Cutlass Supreme";
            myCar.Year = 1986;
            myCar.Color = "Silver";
            */

            // Second reference to the same Object
            Car myOtherCar;
            // copy address of myCar into myOtherCar, point to it
            myOtherCar = myCar;

            Console.WriteLine("{0} {1} {2} {3}", 
                myOtherCar.Make,
                myOtherCar.Model,
                myOtherCar.Year,
                myOtherCar.Color
                );

            myOtherCar.Model = "98";

            Console.WriteLine("{0} {1} {2} {3}",
                myCar.Make,
                myCar.Model,
                myCar.Year,
                myCar.Color
                );

            // null (indeteriment) example
            //removing reference to Object intetionally

            //myOtherCar = null;

            ////Console.WriteLine("{0} {1} {2} {3}",
            ////    myOtherCar.Make,
            ////    myOtherCar.Model,
            ////    myOtherCar.Year,
            ////    myOtherCar.Color
            ////    );

            //myCar = null;


            #region Constructor exmpl
            //3. example, Overloaded constructor
            Car myThirdCar = new Car("Ford", "Escape", 2005, "White");

            Console.WriteLine("{0} {1} {2} {3}",
                myThirdCar.Make,
                myThirdCar.Model,
                myThirdCar.Year,
                myThirdCar.Color
                );
            #endregion

            Car.MyMethod();

            Console.ReadLine();
        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public Car()
        {
            // this = getting a member of this class
            this.Make = "Nissan";
        }

        public Car(string make, string model, int year, string color)
        {
            Make = make;
            Model = model;
            Year = year;
            Color = color;
        }

        public  static void MyMethod()
        {
            Console.WriteLine("Called the static MyMethod");
        }
    }
}
