
namespace GangOfFourDesignPatterns.FileStreamLogger
{
    public interface IWriter: IDisposable, IAsyncDisposable
    {
        void Write(string message, bool append = true);
        void Flush();
        void Close();
    }
    public class CustomStreamWriter : IWriter
    {
        private StreamWriter _writer;
        public CustomStreamWriter(string filePath, bool AppendExisting)
        {
            _writer = new StreamWriter(filePath, AppendExisting);
        }
        public void Write(string message, bool append = true)
        {
            try
            {
                _writer.WriteLine(message);
            }
            finally 
            {
                _writer.Dispose();
            }
        }
        public void Dispose()
        {
            if(_writer != null)
            {
                _writer.Dispose();
            }

            GC.SuppressFinalize(this);
        }
        public async ValueTask DisposeAsync()
        {
            if (_writer != null)
            {
               await _writer.DisposeAsync().ConfigureAwait(false);
            }

            GC.SuppressFinalize(this);
        }
        public void Flush()
        {
            _writer.Flush();
        }
        public void Close()
        {
            _writer.Close();
        }
    }
}
