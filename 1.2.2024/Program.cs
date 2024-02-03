using System;
using System.Reflection;

//* rn = Register Number

namespace STO_AVTOHIRURG
{
    class Car
    {
        public string model { get; set;}
        public string rn {get; set;}
    }
    class CarBox
    {
        private Car parkedCar;
        private bool iss = false;
        public void ParkCarfirst(Car car)
        {
            if(!iss)
            {
                iss = true;
                Console.WriteLine(car.model + " with register number " + car.rn + " parked");
            }else
            {
                Console.WriteLine("The box is already busy by another car.");
                iss = false;
                ParkCarsecond(car);
            }
        }
        private void ParkCarsecond(Car car)
        {
            if(!iss)
            {
                iss = true;
                Console.WriteLine(car.model + " with register number " + car.rn + " parked");
            }else
            {
                Console.WriteLine("The box is already busy by another car.");
                ParkCarthird(car);
            }
        }
        private void ParkCarthird(Car car)
        {
            if(!iss)
            {
                iss = true;
                Console.WriteLine(car.model + " with register number " + car.rn + " parked");
            }else
            {
                Console.WriteLine("The box is already busy by another car.");
            }
        }
    }
    class Heart
    {
        static void Main()
        {
            CarBox carBox = new CarBox();
            Car BMW = new Car { model = "M5", rn = "1"};
            Car AUDI = new Car { model = "RS6", rn = "2"};
            Car MERCEDES = new Car { model = "E-63", rn = "3"};
            carBox.ParkCarfirst(BMW);
            carBox.ParkCarfirst(AUDI);
            carBox.ParkCarfirst(MERCEDES);
        }
    }
}  