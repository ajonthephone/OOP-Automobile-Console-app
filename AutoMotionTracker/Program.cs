using System;

namespace AutoMotionTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            Automobile myAuto = new Automobile();
            string CarType = "";
            Console.WriteLine("Type a vehicle manufacture, then enter");
            CarType = Convert.ToString(Console.ReadLine());

            if (CarType == "")
            {
                
                myAuto.Car = "No Vehicle Selected";
                myAuto.Motion = "Nothing is driving";
            }
            else {
                myAuto.Car = CarType.ToString();
                myAuto.Motion = "is driving";
            }

            //Automobile myAuto = new Automobile();
            //myAuto.Car = "Honda";
            //myAuto.Motion = "is driving";

            Console.WriteLine(myAuto.Car.ToString() + " " + myAuto.Motion.ToString());

           
        }
    }
}
