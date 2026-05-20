
using System;
using SystemCollection;
abstract class TiketBioskop
{
    private String namaPenonton;
    private String idBooking;
    private String judulFilm;

    public TiketBioskop(String namaPenonton, String idBooking, String judulFilm)
    {
        this.namaPenonton = namaPenonton;
        this.idBooking = idBooking;
        this.judulFilm = judulFilm;
    }

    public String getNamaPenonton()
    {
        return namaPenonton;
    }

    public void setNamaPenonton(String namaPenonton)
    {
        this.namaPenonton = namaPenonton;
    }

    public String getIdBooking()
    {
        return idBooking;
    }

    public void setIdBooking(String idBooking)
    {
        this.idBooking = idBooking;
    }

    public String getJudulFilm()
    {
        return judulFilm;
    }

    public void setJudulFilm(String judulFilm)
    {
        this.judulFilm = judulFilm;
    }

    public void tampilInfo()
    {
        System.out.println("Nama Penonton : " + namaPenonton);
        System.out.println("ID Booking    : " + idBooking);
        System.out.println("Judul Film    : " + judulFilm);
    }

    abstract double hitungTotalHarga(int jumlahTiket);
}

class TiketReguler extends TiketBioskop
{

    private double hargaTiket;


public TiketReguler(String namaPenonton, String idBooking,
                     String judulFilm, double hargaTiket)
{

    super(namaPenonton, idBooking, judulFilm);
    this.hargaTiket = hargaTiket;
}


@Override
    double hitungTotalHarga(int jumlahTiket)
{
    return jumlahTiket * hargaTiket;
}
}


class TiketPremiere extends TiketBioskop
{

    private double hargaTiket;
private double biayaLounge;

public TiketPremiere(String namaPenonton, String idBooking,
                     String judulFilm, double hargaTiket,
                     double biayaLounge)
{

    super(namaPenonton, idBooking, judulFilm);
    this.hargaTiket = hargaTiket;
    this.biayaLounge = biayaLounge;
}

@Override
    double hitungTotalHarga(int jumlahTiket) {
        return (jumlahTiket * hargaTiket) + biayaLounge;
    }
}


public class Main
{
    public static void main(String[] args)
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

        
        System.out.println("=== TIKET REGULER ===");
        reguler.tampilInfo();
        System.out.println("Total Harga : Rp " +
                reguler.hitungTotalHarga(2));

        System.out.println();

        
        System.out.println("=== TIKET PREMIERE ===");
        premiere.tampilInfo();
        System.out.println("Total Harga : Rp " +
                premiere.hitungTotalHarga(2));
    }
}