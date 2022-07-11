using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //Veritabanına loglama yapacak servis
    class DatabaseLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Veri tabanına loglandı");
        }
    }
}



//class FileLoggerService : ILoggerService    //FileLoggerService tek tıklayıp move type to ... basınca onu yeni bir dosyaya aktar demektir.
//{
//    public void Log()
//    {
//        Console.WriteLine("Dosyaya loglandı");
//    }
//}
