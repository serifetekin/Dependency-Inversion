using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion
{
    class Program
    {
        // bir class başka bir class kullanıyor. kullanılan classa alt sınıf kullanan sınıfa üst sınıf deniyor.
        static void Main(string[] args)
        {
            KullaniciDb kd = new KullaniciDb(new SQLeLogla());

            kd.Kaydet();

            KullaniciDb kd2 = new KullaniciDb(new FileLogla());

            kd2.Kaydet();

            Console.ReadLine();

        }
    }
}
