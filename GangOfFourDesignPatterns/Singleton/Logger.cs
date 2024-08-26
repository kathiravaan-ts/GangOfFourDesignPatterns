using System;

namespace GangOfFourDesignPatterns.Singleton
{
    public sealed class Logger //Sealed to make sure, class cannot be inherited
    {
        private static Logger? _logger; // private constructor to make sure object creation is prohibited outside the current class
        private static readonly object _lock = new object(); // Thread safe during concurrent execution
        public static Logger? GetLogger {
            get
            {
                if(_logger == null) {
                    lock(_lock) {
                        if(_logger == null) {
                            _logger = new Logger();
                        }
                    }
                }
                return _logger;
            }
        }

        public void Log(string message){
            if(_logger == null) {return;}
            Console.WriteLine("Logger.Log() - "+message);
        }
    }
}
