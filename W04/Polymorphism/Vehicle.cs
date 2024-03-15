namespace W04.Polymorphism
{
    public abstract class Vehicle
    {
        public abstract void Drive();

        public void Start()
        {
            Console.WriteLine("Vehicle is starting.");
        }
    }

    public class Car : Vehicle
    {
        public override void Drive()
        {
            Console.WriteLine("Car is driving.");
        }
    }

    public class Truck : Vehicle
    {
        public override void Drive()
        {
            Console.WriteLine("Truck is hauling.");
        }
    }

 

}
