using System;
class Araba
{
    
    public string marka;
    public string model;
    public double benzinTuketimi; 
    public double gidilenMesafe;

    
    public Araba(string marka, string model, double benzinTuketimi, double gidilenMesafe)
    {
        this.marka = marka;
        this.model = model;
        this.benzinTuketimi = benzinTuketimi;
        this.gidilenMesafe = gidilenMesafe;
    }

   
    public double BenzenTuketimiHesapla()
    {
       double x= (benzinTuketimi / 100) * gidilenMesafe ;
        return x ; 
    }

    // Bilgileri ekrana yazdıran metod
    public void BilgileriYazdir()
    {
       Console.WriteLine($"Marka: {marka}, Model: {model}, Benzin Tüketimi: {benzinTuketimi} L/100km, Gidilen Mesafe: {gidilenMesafe} km");
    }
}