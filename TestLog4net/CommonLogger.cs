using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLog4net
{
    public abstract class CommonLogger
    {
        internal ILog log4netLog;
        public CommonLogger()
        {
            log4netLog = LogManager.GetLogger(typeof(CommonLogger));
        }

        public bool IsDebugEnabled { get { return log4netLog.IsDebugEnabled; } }
        public bool IsErrorEnabled { get { return log4netLog.IsErrorEnabled; } }
        public bool IsFatalEnabled { get { return log4netLog.IsFatalEnabled; } }
        public bool IsInfoEnabled { get { return log4netLog.IsInfoEnabled; } }
        public bool IsWarnEnabled { get { return log4netLog.IsWarnEnabled; } }
        public void Debug(object message)
        {
            log4netLog.Debug(message);
        }

        public void Debug(object message, Exception exception)
        {
            log4netLog.Debug(message, exception);
        }

        public void DebugFormat(string format, params object[] args)
        {
            log4netLog.DebugFormat(format, args);
        }

        public void DebugFormat(string format, object arg0)
        {
            log4netLog.DebugFormat(format, arg0);
        }

        public void DebugFormat(IFormatProvider provider, string format, params object[] args)
        {
            log4netLog.DebugFormat(provider, format, args);
        }

        public void DebugFormat(string format, object arg0, object arg1)
        {
            log4netLog.DebugFormat(format, arg0, arg1);
        }

        public void DebugFormat(string format, object arg0, object arg1, object arg2)
        {
            log4netLog.DebugFormat(format, arg0, arg1, arg2);
        }

        public void Error(object message)
        {
            log4netLog.Error(message);
        }

        public void Error(object message, Exception exception)
        {
            log4netLog.Error(message, exception);
        }

        public void ErrorFormat(string format, params object[] args)
        {
            log4netLog.ErrorFormat(format, args);
        }

        public void ErrorFormat(string format, object arg0)
        {
            log4netLog.ErrorFormat(format, arg0);
        }

        public void ErrorFormat(IFormatProvider provider, string format, params object[] args)
        {
            log4netLog.ErrorFormat(provider, format, args);
        }

        public void ErrorFormat(string format, object arg0, object arg1)
        {
            log4netLog.ErrorFormat(format, arg0, arg1);
        }

        public void ErrorFormat(string format, object arg0, object arg1, object arg2)
        {
            log4netLog.ErrorFormat(format, arg0, arg1, arg2);
        }

        public void Fatal(object message)
        {
            log4netLog.Fatal(message);
        }

        public void Fatal(object message, Exception exception)
        {
            log4netLog.Fatal(message, exception);
        }

        public void FatalFormat(string format, params object[] args)
        {
            log4netLog.FatalFormat(format, args);
        }

        public void FatalFormat(string format, object arg0)
        {
            log4netLog.FatalFormat(format, arg0);
        }

        public void FatalFormat(IFormatProvider provider, string format, params object[] args)
        {
            log4netLog.FatalFormat(provider, format, args);
        }

        public void FatalFormat(string format, object arg0, object arg1)
        {
            log4netLog.FatalFormat(format, arg0, arg1);
        }

        public void FatalFormat(string format, object arg0, object arg1, object arg2)
        {
            log4netLog.FatalFormat(format, arg0, arg1, arg2);
        }

        public void Info(object message)
        {
            log4netLog.Info(message);
        }

        public void Info(object message, Exception exception)
        {
            log4netLog.Info(message, exception);
        }

        public void InfoFormat(string format, params object[] args)
        {
            log4netLog.InfoFormat(format, args);
        }

        public void InfoFormat(string format, object arg0)
        {
            log4netLog.InfoFormat(format, arg0);
        }

        public void InfoFormat(IFormatProvider provider, string format, params object[] args)
        {
            log4netLog.InfoFormat(provider, format, args);
        }

        public void InfoFormat(string format, object arg0, object arg1)
        {
            log4netLog.InfoFormat(format, arg0, arg1);
        }

        public void InfoFormat(string format, object arg0, object arg1, object arg2)
        {
            log4netLog.InfoFormat(format, arg0, arg1, arg2);
        }

        public void Warn(object message)
        {
            log4netLog.Warn(message);
        }

        public void Warn(object message, Exception exception)
        {
            log4netLog.Warn(message, exception);
        }

        public void WarnFormat(string format, params object[] args)
        {
            log4netLog.WarnFormat(format, args);
        }

        public void WarnFormat(string format, object arg0)
        {
            log4netLog.WarnFormat(format, arg0);
        }

        public void WarnFormat(IFormatProvider provider, string format, params object[] args)
        {
            log4netLog.WarnFormat(provider, format, args);
        }

        public void WarnFormat(string format, object arg0, object arg1)
        {
            log4netLog.WarnFormat(format, arg0, arg1);
        }

        public void WarnFormat(string format, object arg0, object arg1, object arg2)
        {
            log4netLog.WarnFormat(format, arg0, arg1, arg2);
        }
    }
}
