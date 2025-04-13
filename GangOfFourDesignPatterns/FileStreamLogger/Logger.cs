namespace GangOfFourDesignPatterns.FileStreamLogger
{
    public interface ILogger
    {
        void Log(string message);
    }
    public class FileLogger : ILogger
    {
        private readonly IWriter _writer;
        public  FileLogger(IWriter writer)
        {
            _writer = writer;
        }
        public void Log(string message)
        {
            _writer.Write(message);
        }
    }
}
