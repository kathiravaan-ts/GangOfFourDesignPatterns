using System;
using System.ComponentModel.DataAnnotations;

namespace GangOfFourDesignPatterns.Factory
{
    public abstract class ExtractionFactory 
    {
        public abstract IFileExtraction CreateFileExtraction(FileType type);
    }
    public class FileExtractionFactory : ExtractionFactory
    {
        public override IFileExtraction CreateFileExtraction(FileType type)
        {
           switch (type)
           {
                case FileType.EXCEL:
                    return new ExcelFileExtraction();
                case FileType.TEXT:
                    return new TextFileExtraction();
                case FileType.CSV:
                    return new CSVFileExtraction();
                default:
                    throw new ValidationException("Invalid file type");
           }
        }
    }
}
