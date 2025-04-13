namespace GangOfFourDesignPatterns.FileStreamLogger
{
    public enum LogType
    {
        File = 1,
        Console = 2,
        Database = 3,
        Cloud = 4,
        Unknown = 99
    }
    public interface ILoggerFactory
    {
        public ILogger CreateLogger(LogType logType, string filePath);
    }
    public sealed class LoggerFactory : ILoggerFactory
    {
        private static readonly Lazy<ILoggerFactory> _loggerFactory =
            new Lazy<ILoggerFactory>(() => new LoggerFactory());
        public static ILoggerFactory GetInstance { get {  return _loggerFactory.Value; } }
        public ILogger CreateLogger(LogType logType, string filePath)
        {
            ILogger logger = null!;
            switch (logType)
            {
                case LogType.File:
                    IWriter _writer = new CustomStreamWriter(filePath, true);
                    logger = new FileLogger(_writer);
                    break;
                default:
                    break;
            }

            return logger;
        }
    }
}