using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCheckDesignPrinciplesProject
{
    class Program
    {
        static void Main(string[] args)
        {
            CarFactory carFactory = new ConcreteCarFactory();
            CarClient carClient = new CarClient(carFactory);
            carClient.BuildMicroCar(Location.USA);
            carClient.BuildMiniCar(Location.INDIA);
            carClient.BuildLuxuryCar(Location.DEFAULT);

            Console.ReadKey();
        }
        abstract class CarFactory
        {
            public abstract void BuildMicroCar(Location location);
            public abstract void BuildMiniCar(Location location);
            public abstract void BuildLuxuryCar(Location location);
        }

        class ConcreteCarFactory : CarFactory
        {
            Car car;

            public override void BuildMicroCar(Location location)
            {
                car= new MicroCar(CarType.MICRO, location);
            }

            public override void BuildMiniCar(Location location)
            {
                car= new MiniCar(CarType.MINI, location);
            }

            public override void BuildLuxuryCar(Location location)
            {
                car= new LuxuryCar(CarType.LUXURY, location);
            }
        }

        class CarClient
        {
            CarFactory _carFactory;
            public CarClient(CarFactory carFactory)
            {
                _carFactory = carFactory;
            }

            public void BuildMicroCar(Location location)
            {
                _carFactory.BuildMicroCar(location);
            }
            public void BuildMiniCar(Location location)
            {
                _carFactory.BuildMiniCar(location);
            }
            public void BuildLuxuryCar(Location location)
            {
                _carFactory.BuildLuxuryCar(location);
            }
        }
        public enum CarType
        {
            MICRO, MINI, LUXURY
        }
        public enum Location
        {
            DEFAULT,USA,INDIA
        }

        abstract class Car
        {
            public Car(CarType model, Location location)
            {
                this.CarType = model;
                this.Location = location;
            }
            public abstract void Construct();
            public CarType CarType{get;set;}
            public Location Location { get; set; }
            public override string ToString()
            {
                return "CarModel - " + CarType.ToString() + " Located in " + Location.ToString();
            }
        }

        class LuxuryCar : Car
        {
            public LuxuryCar(CarType carType,Location location):base(CarType.LUXURY,location)
            {
                Construct();
            }
            public override void Construct()
            {
                Console.WriteLine("Connecting to luxury car");
                Console.WriteLine(base.ToString());
            }
        }

        class MicroCar : Car
        {
            public MicroCar(CarType carType, Location location) : base(CarType.MICRO, location)
            {
                Construct();
            }
            public override void Construct()
            {
                Console.WriteLine("Connecting to MicroCar");
                Console.WriteLine(base.ToString());
            }
        }

        class MiniCar : Car
        {
            public MiniCar(CarType carType, Location location) : base(CarType.MINI, location)
            {
                Construct();
            }
            public override void Construct()
            {
                Console.WriteLine("Connecting to MiniCar");
                Console.WriteLine(base.ToString());
            }
        }
    }
}
