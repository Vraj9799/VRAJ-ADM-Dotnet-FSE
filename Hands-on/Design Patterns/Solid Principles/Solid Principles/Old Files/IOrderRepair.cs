namespace Solid_Principles
{
    public interface IOrderRepair
    {
        void ProcessOrder(string modelName);
        void ProcessPhoneRepair(string modelName);
        void ProcessAccessoryRepair(string accessoryType);
    }
}
