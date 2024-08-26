using System;

namespace GangOfFourDesignPatterns.Factory
{
    public interface IFileExtraction 
    {
        void Extract(string message);
    }
    public class ExcelFileExtraction : IFileExtraction
    {
        public void Extract(string message)
        {
            Console.WriteLine("Factory.ExcelFileExtraction.Extract() - "+ message);
        }
    }

    public class TextFileExtraction : IFileExtraction
    {
        public void Extract(string message)
        {
            Console.WriteLine("Factory.TextFileExtraction.Extract() - "+ message);
        }
    }

    public class CSVFileExtraction : IFileExtraction
    {
        public void Extract(string message)
        {
            Console.WriteLine("Factory.CSVFileExtraction.Extract() - "+ message);
        }
    }
}
