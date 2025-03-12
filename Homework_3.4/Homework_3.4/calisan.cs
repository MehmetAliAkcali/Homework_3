class Calisan
{
    
    public string ad;
    public string soyad;
    public string meslek;
    public double maas;
    public string departman;

    
    public Calisan(string ad, string soyad, string meslek, double maas, string departman)
    {
        this.ad = ad;
        this.soyad = soyad;
        this.meslek = meslek;
        this.maas = maas;
        this.departman = departman;
    }

    
    public void BilgileriYazdir()
    {
        Console.WriteLine($"Ad: {ad}, Soyad: {soyad}, Meslek: {meslek}, Maaş: {maas}, Departman: {departman}");
    }
      public double Maas()
    {
        return maas;
    }
}