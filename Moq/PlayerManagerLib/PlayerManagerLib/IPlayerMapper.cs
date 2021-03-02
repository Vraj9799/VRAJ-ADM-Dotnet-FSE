namespace PlayerManagerLib
{
    public interface IPlayerMapper
    {
        void AddNewPlayerIntoDb(string name);
        bool IsPlayerNameExistsInDb(string name);
    }
}