using log4net;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLog4net
{
    class Program
    {
        static void Main(string[] args)
        {
            InitLog4Net();

            var logger = LogManager.GetLogger(typeof(Program));

            for (int i = 0; i < 50; i++)
            {
                logger.Info("Information");
                logger.Warn("Warning");
                logger.Error("Error");
                logger.Fatal("Failed");
            }

            Console.ReadLine();
        }

        private static void InitLog4Net()
        {
            var logCfg = new FileInfo(AppDomain.CurrentDomain.BaseDirectory + "log4net.config");
            XmlConfigurator.ConfigureAndWatch(logCfg);
        }
    }
}
