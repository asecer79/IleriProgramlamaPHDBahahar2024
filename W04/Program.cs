using W04.Polymorphism;

namespace W04
{
    class Program
    {
        static void Main(string[] args)
        {
            //    Car car1 = new Car();

            //    DerivedClass derivedClass1 = new DerivedClass();

            //    DerivedClass derivedClass2 = new DerivedClass(2);

            //    DerivedClass derivedClass3 = new DerivedClass(2, 2);

            //    DerivedClass derivedClass4 = new DerivedClass(2, 3, 4);

            //PaymentProcessor  paymentProcessor = new PaymentProcessor(); // error

            //PaymentProcessor paymentProcessor1 = new PayPalProcessor();
            //var paymentProcessor2 = new PayPalProcessor();
            //PayPalProcessor paymentProcessor3 = new PayPalProcessor();

            List<Animal> animals = new List<Animal> { new Animal(), new Dog(), new Cat() };

            foreach (var animal in animals)
            {
                animal.MakeSound();
            }


            List<Vehicle> vehicles = new List<Vehicle> { new Car(), new Truck() };
            foreach (var vehicle in vehicles)
            {
                vehicle.Start();
                vehicle.Drive();
            }



            List<IShape> shapes = new List<IShape> { new Circle(), new Square() };
            foreach (var shape in shapes)
            {
                shape.Draw();
            }
        }
    }
}

