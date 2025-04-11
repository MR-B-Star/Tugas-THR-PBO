using System;

class Karyawan
{
    private string nama;
    private string id;
    private double gajiPokok;

    public Karyawan(string nama, string id, double gajiPokok)
    {
        this.nama = nama;
        this.id = id;
        this.gajiPokok = gajiPokok;
    }

    public string GetNama() => nama;
    public void SetNama(string value) => nama = value;

    public string GetID() => id;
    public void SetID(string value) => id = value;

    public double GetGajiPokok() => gajiPokok;
    public void SetGajiPokok(double value) => gajiPokok = value;

    public virtual double HitungGaji()
    {
        return gajiPokok;
    }
}

class KaryawanTetap : Karyawan
{
    public KaryawanTetap(string nama, string id, double gajiPokok)
        : base(nama, id, gajiPokok) { }

    public override double HitungGaji()
    {
        return GetGajiPokok() + 500000;
    }
}

class KaryawanKontrak : Karyawan
{
    public KaryawanKontrak(string nama, string id, double gajiPokok)
        : base(nama, id, gajiPokok) { }

    public override double HitungGaji()
    {
        return GetGajiPokok() - 200000;
    }
}

class KaryawanMagang : Karyawan
{
    public KaryawanMagang(string nama, string id, double gajiPokok)
        : base(nama, id, gajiPokok) { }

    public override double HitungGaji()
    {
        return GetGajiPokok();
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("=========================");
        Console.WriteLine("Sistem Manajemen Karyawan");
        Console.WriteLine("=========================");
        Console.WriteLine("Pilih jenis karyawan:");
        Console.WriteLine("1. Karyawan Tetap");
        Console.WriteLine("2. Karyawan Kontrak");
        Console.WriteLine("3. Karyawan Magang");
        Console.WriteLine("=========================");
        Console.Write("Masukkan pilihan (1/2/3): ");
        string pilihan = Console.ReadLine();

        Console.Write("Masukkan nama karyawan: ");
        string nama = Console.ReadLine();
        Console.Write("Masukkan ID karyawan: ");
        string id = Console.ReadLine();
        Console.Write("Masukkan gaji pokok: ");
        double gajiPokok = Convert.ToDouble(Console.ReadLine());

        Karyawan karyawan;

        switch (pilihan)
        {
            case "1":
                karyawan = new KaryawanTetap(nama, id, gajiPokok);
                break;
            case "2":
                karyawan = new KaryawanKontrak(nama, id, gajiPokok);
                break;
            case "3":
                karyawan = new KaryawanMagang(nama, id, gajiPokok);
                break;
            default:
                Console.WriteLine("Pilihan tidak valid.");
                return;
        }

        Console.WriteLine("\n===================================");
        Console.WriteLine("           Data Karyawan        ");
        Console.WriteLine("===================================");
        Console.WriteLine($"Nama       : {karyawan.GetNama()}");
        Console.WriteLine($"ID         : {karyawan.GetID()}");
        Console.WriteLine($"Gaji Akhir : Rp {karyawan.HitungGaji():N0}");
        Console.WriteLine("===================================");
    }
}
