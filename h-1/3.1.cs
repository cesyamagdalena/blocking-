using System;

class Program;
{
  public static void Main(String[] args)
  {
  String nim, nama, nabsen, ntugas, nuts, nuas;
  double nakhir, n_absen, n_tugas, n_uts, n_uas;
  Console.Write("\n Nim : ");
  nim = Console.ReadLine();
  Console.Write(" Nama : ");
  nama = Console.ReadLine();
  Console.Write(" Nilai absen : ");
  nabsen = Console.ReadLine();
  Console.Write(" Nilai Tugas : ");
  ntugas = Console.ReadLine();
  Console.Write(" Nilai UTS : ");
  nuts = Console.ReadLine();
  Console.Write(" Nilai UAS : ");
  nuas = Console.ReadLine();
  n_absen = Convert.ToDouble(nabsen);
  n_tugas = Convert.ToDouble(ntugas);
  n_uts = Convert.ToDouble(nuts);
  n_uas = Convert.ToDouble(nuas);
  nakhir = (n_absen * 10 / 100)+(n_tugas* 20 / 100)+(n_uts*
  30/100) + (n_uas* 40 / 100);
  Console.WriteLine(" Nilai Akhir : {0}", nakhir);
  if (nakhir >= 80)
  {
  Console.WriteLine(" Grade : A");
  }
  else if (nakhir >= 70)
  {
  Console.WriteLine(" Grade : B");
  }
  else if(nakhir >= 60)
  {
  Console.WriteLine(" Grade : C");
  }
  else if (nakhir >= 50)
  {
  Console.WriteLine(" Grade : D");
  }
  else
  {
  Console.WriteLine(" Grade : E");
  }
  Console.Read();
  }
}
