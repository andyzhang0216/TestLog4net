using log4net;
using log4net.Core;
using log4net.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLog4net.MSSql
{
    public class MSSqlLogger : CommonLogger
    {
        Type logType;

        public MSSqlLogger(Type type)
        {
            logType = type;
            log4netLog = LogManager.GetLogger(typeof(MSSqlLogger));
        }

        public static MSSqlLogger GetInstance(Type type)
        {
            return new MSSqlLogger(type);
        }

        public void WriteEntry(string msg, LogLevel level, Exception ex = null, string comment = null)
        {
            ILoggerRepository repository = log4netLog.Logger.Repository;
            string loggerName = log4netLog.Logger.Name;
            Level log4netLevel = new Level((int)level, level.ToString());
            LoggingEvent loggingEntry = new LoggingEvent(logType, repository, loggerName, log4netLevel, msg, ex);
            loggingEntry.Properties["Comment"] = comment;

            log4netLog.Logger.Log(loggingEntry);
        }
    }

    public enum LogLevel
    {
        FATAL = 0x1adb0,//110000
        ERROR = 0x11170, //70000
        WARN = 0xea60, //60000
        INFO = 0x9c40, //40000
        DEBUG = 0x7530, //30000
    }
}
