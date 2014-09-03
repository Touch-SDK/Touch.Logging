using System;

namespace Touch.Logging
{
    sealed public class Log4NetLoggerProvider : ILoggerProvider
    {
        public ILogger Get<T>() where T : class
        {
            var logger = log4net.LogManager.GetLogger(typeof(T));
            return new Log4NetLogger(logger);
        }

        public ILogger Get(Type type)
        {
            if (type == null) throw new ArgumentNullException("type");
            var logger = log4net.LogManager.GetLogger(type);

            return new Log4NetLogger(logger);
        }
    }
}
