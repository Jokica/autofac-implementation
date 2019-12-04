using System;

namespace DemoLibrary.Utils
{
    public class DataAccess : IDataAccess
    {
        public void LoadData()
        {
            Console.WriteLine("Loading data...");
        }

        public void SaveData(string v)
        {
            Console.WriteLine("Saving " + v);
        }
    }
}