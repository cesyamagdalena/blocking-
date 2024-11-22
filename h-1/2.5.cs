using system;

class Program
{
  using static void Main(String[] args)
  {
    String a, b;
    int convert_a, convert_b;
    bool dan, atau, bukan_a, bukan_b, var_a, var_b;
    Console.WriteLine("\n Input nilai a dan b dengan 1 atau 0");
    Console.Write(" Masukkan nilai a : ");
    a = Console.ReadLine();
    Console.Write(" Masukkan nilai b : ");
    b = Console.ReadLine();
    convert_a = Convert.ToInt16(a);
    convert_b = Convert.ToInt16(b);
    var_a = Convert.ToBoolean(convert_a);
    var_b = Convert.ToBoolean(convert_b);
    dan = var_a && var_b;
    atau = var_a || var_b;
    bukan_a = !var_a;
    bukan_b = !var_b;
    Console.WriteLine("\n hasil dari a and b adalah {0}", dan);
    Console.WriteLine(" hasil dari a or b adalah {0}", atau);
    Console.WriteLine(" hasil dari not a adalah {0}",bukan_a);
    Console.WriteLine(" hasil dari not b adalah {0}", bukan_b);
    Console.Read();
    Console.Read();
  }
}
