using System;
namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            const double Main(string[] args)
            string jari_jari;
            double konversi,luas,keliling;
            Console.Write("Masukan Jari-jari: ");
            jari_jari = Console.ReadLine();
            konversi = Convert.ToDouble(jari_jari);
            
            luas = PI *konversi*konversi;
            keliling = 2 * PI * konversi;
            
            Console.WriteLine("Luas Lingkaran Adalah : {0}", luas);
            Console.WriteLine("Keliling Lingkaran adalah ; {0}", keliling);
            Console.Read();
        }
    }
}
