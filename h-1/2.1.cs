using system;

using namespace ConsoleApplication7
{
    class Program
    {
        public static void Main(String[] args)
        {
            String nama;
            Console.Write("\n Masukkan Nama Anda: ");
            nama = Console.ReadLine();
            Console.WriteLine("\n Selamat belajar C# {0}", nama);
            Console.Read();
        }
    }
}
