using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLog4net.Sqlite
{
    public class SqliteLogger : CommonLogger
    {
        Type logType;

        public SqliteLogger(Type type)
        {
            logType = type;
            log4netLog = LogManager.GetLogger(typeof(SqliteLogger));
        }

        public static SqliteLogger GetInstance(Type type)
        {
            return new SqliteLogger(type);
        }
    }
}
