using System;

namespace GangOfFourDesignPatterns.Singleton
{
    public sealed class LazyLogger
    {
        private static readonly Lazy<LazyLogger> _lazyLogger = new Lazy<LazyLogger>(() => new LazyLogger());
        private LazyLogger(){}

        public static LazyLogger GetLogger
        {
            get {
                return _lazyLogger.Value;
            }
        }

        public void Log(string message){
            if(_lazyLogger == null) {return;}
            Console.WriteLine("LazyLogger.Log() - "+message);
        }
        
    }
}
