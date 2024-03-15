using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W04.Abstraction
{
    public abstract class PaymentProcessor //cannot be created by new keyword, only can be inherited
    {
        public abstract void ProcessPayment(decimal amount); //abstract member

        public void LogTransaction(decimal amount)  //concrete members
        {
            Console.WriteLine($"Transaction for {amount} has been processed.");
        }
    }

    public class CreditCardProcessor : PaymentProcessor //inherit
    {
        public override void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing credit card payment for {amount}");

            LogTransaction(amount);
        }
    }

    public class CreditCardProcessor3D : CreditCardProcessor //inherit
    {
        public sealed override void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing 3D credit card payment for {amount}");

            LogTransaction(amount);
        }
    }

    public class CreditCardProcessor3DPhone : CreditCardProcessor3D //inherit
    {
        public CreditCardProcessor3DPhone()
        {
            ProcessPayment(100);
        }
        //public override void ProcessPayment(decimal amount)
        //{
        //    Console.WriteLine($"Processing 3D credit card payment for {amount}");

        //    LogTransaction(amount);
        //}
    }

    public class PayPalProcessor : PaymentProcessor
    {
        public override void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing PayPal payment for {amount}");

            LogTransaction(amount);
        }
    }

}
