using System;

namespace AdapterDP
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            IMovable buggati = new BuggatiVeyron();
            IMovableAdapter adapter = new MovableAdapterImpl(buggati);
            Console.WriteLine(adapter.getSpeed());
            Console.WriteLine(adapter.getPrice());
            Console.ReadLine();
        }
    }

    public interface IMovable
    {
        double getSpeed();
        double getPrice();

    }


    public class BuggatiVeyron : IMovable
    {
        public double getSpeed()
        {
            return 268;
        }
        public double getPrice()
        {
            return 5;
        }
    }

    public interface IMovableAdapter
    {
        double getSpeed();
        double getPrice();
    }

    public class MovableAdapterImpl : IMovableAdapter
    {
        private IMovable _luxuryCars;

        public MovableAdapterImpl(IMovable luxuryCars)
        {
            _luxuryCars = luxuryCars;
        }

        public double getPrice()
        {
            return convertUSDToEuro(_luxuryCars.getPrice());
        }

        public double getSpeed()
        {
            return convertMPHToKMPH(_luxuryCars.getSpeed());
        }

        private double convertMPHToKMPH(double mph)
        {
            return mph * 1.60934;
        }
        private double convertUSDToEuro(double usd)
        {
            return usd * 0.84;
        }
    }
}
