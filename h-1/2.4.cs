using system;

class Program
{
  public static void Main(String[] args)
  {
    String a, b;
    bool lb, lk, lbs, lks, smd, tsm;
    int var_a, var_b;
    Console.Write("\n Masukkan Nilai a : ");
    a = Console.ReadLine();
    Console.Write(" Masukkan Nilai b : ");
    b = Console.ReadLine();
    var_a = Convert.ToInt16(a);
    var_b = Convert.ToInt16(b);
    lb = var_a > var_b;// lebih besar
    lk = var_a < var_b;// lebih keci
    lbs = var_a >= var_b;// lebih besar sama dengan
    lks = var_a <= var_b;// lebih kecil sama dengan
    smd = var_a == var_b;// sama dengan
    tsm = var_a != var_b;// tidak sama dengan
    Console.WriteLine("\n apakah a lebih besar dari b? {0}",lb);
    Console.WriteLine(" apakah a lebih kecil dari b? {0}", lk);
    Console.WriteLine(" apakah a lebih besar sama dengan b? {0}", lbs);
    Console.WriteLine(" apakah a lebih kecil sama dengan b? {0}", lks);
    Console.WriteLine(" apakah a sama dengan b? {0}", smd);
    Console.WriteLine(" apakah a tidak sama dengan b? {0}", tsm);
    Console.Read();
  }
