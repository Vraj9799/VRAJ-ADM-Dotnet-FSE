using System;

namespace Solid_Principles.Dependency_Injection
{
    public class ProcessPhoneRepair
    {
        ///<summary>
        ///Method that list the steps in phone repair
        ///Any phone model that IMPLEMENTS all the methods of tyhe interfaces IPhone can be inserted as dependencies to this method.
        ///This would be the common set of steps in the repair.
        ///</summary>
        ///<param name="phone">Any class that implements the IPhone interfaces</param>
        public void RepairSteps(IPhone phone)
        {
            string part1 = phone.GetPhonePart1();
            Console.WriteLine($"{part1} repaired");

            double partCost = phone.GetPart1Cost();
            Console.WriteLine($"Repair Cost: {partCost * 0.5}");
        }
    }
}
