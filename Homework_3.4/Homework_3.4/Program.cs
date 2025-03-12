using System;
using System.Collections;
class Program
{
    static void Main(string[] args)
    { 
        /* Arrayleri kullanarak da yapabilirdik. Arraylist'leri de anlamak için array kullanmadım.
           
        
         Calisan[] calisanlar = new Calisan[3];
        
         calisanlar[0] = new Calisan("Mehmet", "Akçalı", "Genel Müdür", 100000, "İnsan Kaynakları");
         calisanlar[1] = new Calisan("Emre", "Demir", "Müdür", 75000, "Pazarlama");
         calisanlar[2] = new Calisan("Emir", "Barış", "Programcı", 200000, "Yazılım");
         calisanlar[3] = new Calisan("Onur", "Yılmaz", "Stajyer", 30000, "Stajyer");*/
        

 ArrayList calisanlar = new ArrayList();
        
        
        Calisan gm = new Calisan("Ahmet", "Yılmaz", "Genel Müdür", 100000, "İnsan Kaynakları");
        Calisan mu = new Calisan("Ayşe", "Demir", "Müdür", 75000, "Pazarlama");
        Calisan pr = new Calisan("Murat", "Kara", "Programcı", 200000, "Yazılım");
        Calisan s = new Calisan("Fatma", "Beyaz", "Stajyer", 30000, "Stajyer");

        
        calisanlar.Add(gm);
        calisanlar.Add(mu);
        calisanlar.Add(pr);
        calisanlar.Add(s);

      
        double toplamMaas = 0;

       
        foreach (Calisan calisan in calisanlar)
        {   calisan.BilgileriYazdir();
            toplamMaas += calisan.Maas();  
        }

        Console.WriteLine("Toplam maaş:"+ toplamMaas);
    }
}