using log4net;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestLog4net.ColorConsole;
using TestLog4net.MSSql;
using TestLog4net.Sqlite;

namespace TestLog4net
{
    class Program
    {
        static void Main(string[] args)
        {
            InitLog4Net();
            Program program = new Program();
            program.Start();
            Console.ReadLine();
        }

        void Start()
        {
            TestConsoleLog();
        }

        void TestConsoleLog()
        {
            ColorConsoleLogger logger = ColorConsoleLogger.GetInstance(typeof(Program));
            WriteLog(logger);
        }

        void TestMSSqlLog()
        {
            MSSqlLogger logger = MSSqlLogger.GetInstance(typeof(Program));

            for (int i = 0; i < 50; i++)
            {
                logger.WriteEntry(string.Format("Debug {0}", i), LogLevel.DEBUG);
                logger.WriteEntry(string.Format("Information {0}", i), LogLevel.INFO, null, "Test Info");
                logger.WriteEntry(string.Format("Warning {0}", i), LogLevel.WARN, new Exception("Warn Exception"), "Test Warn");
                logger.WriteEntry(string.Format("Error {0}", i), LogLevel.ERROR, new Exception("Error Exception"), "Test Error");
                logger.WriteEntry(string.Format("Fatal {0}", i), LogLevel.FATAL, new Exception("Fatal Exception"), "Test Fatal");
            }

        }

        void TestSqliteLog()
        {
            SqliteLogger logger = SqliteLogger.GetInstance(typeof(Program));
            WriteLog(logger);
        }

        void WriteLog(CommonLogger logger)
        {
            for (int i = 0; i < 50; i++)
            {
                logger.Info("Information");
                logger.Warn("Warning");
                logger.Error("Error");
                logger.Fatal("Failed");
            }
        }

        private static void InitLog4Net()
        {
            var logCfg = new FileInfo(AppDomain.CurrentDomain.BaseDirectory + "log4net.config");
            XmlConfigurator.ConfigureAndWatch(logCfg);
        }
    }
}
