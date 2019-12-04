using DemoLibrary.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class BusinessLogic : IBusinessLogic
    {
        private readonly IDataAccess data;
        private readonly ICustomLogger logger;

        public BusinessLogic(IDataAccess data,ICustomLogger logger)
        {
            this.data = data;
            this.logger = logger;
        }
        public void ProcessData()
        { 
            logger.Log("Start procces data");
            Console.WriteLine("Proccesing");
            data.LoadData();
            data.SaveData("ProcessInfo");
            logger.Log("Finished processing of the data");
        }
      
    }
}
