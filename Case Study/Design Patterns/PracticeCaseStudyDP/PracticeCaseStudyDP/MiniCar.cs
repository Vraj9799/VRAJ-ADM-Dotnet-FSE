using System;

namespace PracticeCaseStudyDP
{
    public class MiniCar : Car
    {
        public MiniCar(CarType carType, Location location) : base(CarType.MINI, location)
        {
            Construct();
        }
        public override void Construct()
        {
            Console.WriteLine("Connecting to MINI Car");
            Console.WriteLine(base.ToString());
        }
    }
}
