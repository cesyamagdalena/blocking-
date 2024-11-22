using System;

public class Robot
{
    public string Nama = "Astroboy"; // Nama robot
    private int JumlahKaki = 2;      // Jumlah kaki robot
    private int JumlahTangan = 2;    // Jumlah tangan robot
    private int JumlahRocket = 2;    // Jumlah roket robot
    private int JumlahSenjata = 8;   // Jumlah senjata robot

    // Method untuk melihat jumlah kaki
    public void LihatKaki()
    {
        Console.WriteLine($"Jumlah kaki {Nama} adalah {JumlahKaki}");
    }

    // Method untuk melihat jumlah tangan
    public void LihatTangan()
    {
        Console.WriteLine($"Jumlah tangan {Nama} adalah {JumlahTangan}");
    }

    // Method untuk melihat jumlah roket
    public void LihatRoket()
    {
        Console.WriteLine($"Jumlah roket {Nama} adalah {JumlahRocket}");
    }

    // Method untuk melihat jumlah senjata
    public void LihatSenjata()
    {
        Console.WriteLine($"Jumlah senjata {Nama} adalah {JumlahSenjata}");
    }

    // Fungsi untuk robot berjalan
    public void Berjalan()
    {
        Console.WriteLine($"{Nama} sedang berjalan");
    }

    // Fungsi untuk robot mengeluarkan senjata
    public void MengeluarkanSenjata()
    {
        Console.WriteLine($"{Nama} mengeluarkan senjata");
    }

    // Fungsi untuk robot mengeluarkan roket
    public void MengeluarkanRoket()
    {
        Console.WriteLine($"{Nama} mengeluarkan roket");
    }
}

public class HelloWorld
{
    static void Main(string[] args)
    {
        // Membuat objek dari kelas Robot
        Robot robot = new Robot();

        // Menampilkan nama robot
        Console.WriteLine($"Nama robot adalah {robot.Nama}");

        // Menampilkan jumlah kaki, tangan, roket, dan senjata
        robot.LihatKaki();
        robot.LihatTangan();
        robot.LihatRoket();
        robot.LihatSenjata();

        // Menampilkan output untuk aksi robot
        robot.Berjalan();
        robot.MengeluarkanSenjata();
        robot.MengeluarkanRoket();
    }
}
