using System;

namespace Business.CCS
{
    public class Database : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Veritabanına Loglandı");
        }
    }
}
