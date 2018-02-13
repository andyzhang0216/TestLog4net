using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLog4net.RollingFile
{
    public class RollingFileLog : CommonLogger
    {
        Type logType;

        public RollingFileLog(Type type)
        {
            logType = type;
            log4netLog = LogManager.GetLogger(typeof(RollingFileLog));
        }

        public static RollingFileLog GetInstance(Type type)
        {
            return new RollingFileLog(type);
        }
    }
}
