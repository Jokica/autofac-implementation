namespace DemoLibrary.Utils
{
    public interface IDataAccess
    {
        void LoadData();
        void SaveData(string v);
    }
}