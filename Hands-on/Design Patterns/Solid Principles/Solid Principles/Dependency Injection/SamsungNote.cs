namespace Solid_Principles.Dependency_Injection
{
    public class SamsungNote : IPhone
    {
        public double GetPart1Cost() => 500;
        public string GetPhonePart1() => "Display";
    }
}
