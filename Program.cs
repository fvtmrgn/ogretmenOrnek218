using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ogretmenOrnek218
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi, a , sayi1;
            string[] il = { "Muş", "Ağrı", "Bolu", "Mersin", "Ankara", "Sivas", "Kayseri" };
            string[] isim = { "Asuman", "İclal", "Emin", "Bekir", "Ahmet", "Can", "Esma" };
            bool[] D = new bool[7];
            bool[] E = new bool[7];

            
            Random rastgele = new Random();
            for (a = 0; a <= 6; a++)
            {
                do
                {
                    sayi = rastgele.Next(0, 7);
                } while (D[sayi] == true);
                D[sayi] = true;
                //Console.WriteLine(isim[a] + "\t= " + il[sayi]);

                do
                {
                    sayi1 = rastgele.Next(0, 7);
                } while (E[sayi1] == true);
                E[sayi1] = true;

                Console.WriteLine(isim[sayi1] + "\t= " + il[sayi]);

            }

           
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
