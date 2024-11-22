using System;

class Program
{
  public static void Main(String[] args)
  {
  Console.WriteLine("Password yang anda masukkan salah, coba lagi");
  Console.Write(" Masukkan Password : ");
  String pass = Console.ReadLine();
  switch (pass)
  {
  case "P4ssw0rd":
  Console.Clear();
  Console.WriteLine("Selamat datang di ruang administrator ");
  Console.WriteLine("======================================");
  break; default:
  Console.Clear();
  Console.WriteLine("Anda tidak berhak masuk kedalam sistem ini");
  break;
  }
Console.Read();
  }
}
