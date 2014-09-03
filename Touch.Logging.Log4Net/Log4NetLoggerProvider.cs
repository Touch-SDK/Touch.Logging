namespace Touch.Logging
{
    sealed public class Log4NetLoggerProvider : ILoggerProvider
    {
        public ILogger Get<T>() where T : class
        {
            return new Log4NetLogger { OwnerType = typeof(T) };
        }
    }
}
