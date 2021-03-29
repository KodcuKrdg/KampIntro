using System;

namespace OOP3
{
    class FileLoggerSevise : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya loglandı");
        }
    }
}
