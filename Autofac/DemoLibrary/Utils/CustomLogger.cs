using System;

namespace DemoLibrary.Utils
{
    public class CustomLogger : ICustomLogger
    {
        public void  Log(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}