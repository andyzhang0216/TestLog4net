using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLog4net.ColorConsole
{
    public class ColorConsoleLogger : CommonLogger
    {
        Type logType;

        public ColorConsoleLogger(Type type)
        {
            logType = type;
            log4netLog = LogManager.GetLogger(typeof(ColorConsoleLogger));
        }

        public static ColorConsoleLogger GetInstance(Type type)
        {
            return new ColorConsoleLogger(type);
        }
    }
}
