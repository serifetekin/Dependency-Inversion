using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion
{

    interface ILogger
    {
        void Yaz(string yazi);
    }
    class SQLeLogla : ILogger
    {
        public void Yaz(string yazi)
        {
            Console.WriteLine("Sqle Logla " + yazi);
        }
    }
    class FileLogla : ILogger
    {
        public void Yaz(string yazi)
        {
            Console.WriteLine("File Logla " + yazi);
        }
    }
    class KullaniciDb
    {
        ILogger log;


        public KullaniciDb(ILogger _log)
        {
            log = _log;
        }
        public void Kaydet()
        {
            log.Yaz("Kaydet");
        }

        public void Sil()
        {
            log.Yaz("Sil");
        }
    }
}
