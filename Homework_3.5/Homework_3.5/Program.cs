class Program
{
    static void Main(string[] args)
    {
        
        Araba[] arabalar = new Araba[3];
        
      
        arabalar[0] = new Araba("Mercedes", "G", 7, 200);  // 7L/100km tüketim, 200 km gidildi
        arabalar[1] = new Araba("Toyota", "Corolla", 7.5, 300); // 7.5L/100km tüketim, 300 km gidildi
        arabalar[2] = new Araba("BMW", "X5", 8, 120);       // 8L/100km tüketim, 120 km gidildi

        double toplamBenzinTuketimi = 0;

        
        foreach (Araba araba in arabalar) // Arabalar dizisinin kullanarak basit bir for döngüsü ile de yapabilirdik.
        {
            araba.BilgileriYazdir();  
            toplamBenzinTuketimi += araba.BenzenTuketimiHesapla();   
        }

        Console.WriteLine($"\nToplam benzin tüketimi: {toplamBenzinTuketimi} litre");
    }
}