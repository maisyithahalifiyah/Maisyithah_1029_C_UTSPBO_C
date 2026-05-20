using System;

abstract class TiketBioskop
{
    private string namaPenonton;
    private string idBooking;
    private string judulFilm;

    public TiketBioskop(string namaPenonton, string idBooking, string judulFilm)
    {
        this.namaPenonton = namaPenonton;
        this.idBooking = idBooking;
        this.judulFilm = judulFilm;
    }

    public string NamaPenonton
    {
        get { return namaPenonton; }
        set { namaPenonton = value; }
    }

    public string IdBooking
    {
        get { return idBooking; }
        set { idBooking = value; }
    }

    public string JudulFilm
    {
        get { return judulFilm; }
        set { judulFilm = value; }
    }

    public void TampilInfo()
    {
        Console.WriteLine("Nama Penonton : " + namaPenonton);
        Console.WriteLine("ID Booking    : " + idBooking);
        Console.WriteLine("Judul Film    : " + judulFilm);
    }

    public abstract double HitungTotalHarga(int jumlahTiket);
}

class TiketReguler : TiketBioskop
{
    private double hargaTiket;

    public TiketReguler(string namaPenonton, string idBooking,
                        string judulFilm, double hargaTiket)
        : base(namaPenonton, idBooking, judulFilm)
    {
        this.hargaTiket = hargaTiket;
    }

    public override double HitungTotalHarga(int jumlahTiket)
    {
        return jumlahTiket * hargaTiket;
    }
}

class TiketPremiere : TiketBioskop
{
    private double hargaTiket;
    private double biayaLounge;

    public TiketPremiere(string namaPenonton, string idBooking,
                         string judulFilm, double hargaTiket,
                         double biayaLounge)
        : base(namaPenonton, idBooking, judulFilm)
    {
        this.hargaTiket = hargaTiket;
        this.biayaLounge = biayaLounge;
    }

    public override double HitungTotalHarga(int jumlahTiket)
    {
        return (jumlahTiket * hargaTiket) + biayaLounge;
    }
}

class Program
{
    static void Main(string[] args)
    {
        TiketReguler reguler = new TiketReguler(
            "Mayshita",
            "REG001",
            "Avengers Endgame",
            50000
        );

        TiketPremiere premiere = new TiketPremiere(
            "Alifia",
            "PRE001",
            "Doctor Strange",
            100000,
            50000
        );

        Console.WriteLine("=== TIKET REGULER ===");
        reguler.TampilInfo();
        Console.WriteLine("Total Harga : Rp " +
            reguler.HitungTotalHarga(2));

        Console.WriteLine();

        Console.WriteLine("=== TIKET PREMIERE ===");
        premiere.TampilInfo();
        Console.WriteLine("Total Harga : Rp " +
            premiere.HitungTotalHarga(2));

        Console.ReadLine();
    }
}