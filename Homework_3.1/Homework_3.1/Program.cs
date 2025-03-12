
static void YasKategorisi(int age)
{
    if (age >= 0 && age < 18) // Bir insan 0 yaşında olabilir. Bu nedenle, methoda dahil ettim.
    {
        Console.WriteLine("Küçüksünüz.");
    }
    else if (age >= 18 && age < 35)
    {
        Console.WriteLine("Gençsiniz.");
    }
    else if (age >= 35 && age < 55)
    {
        Console.WriteLine("Yetişkinsiniz.");
    }
    else if (age >= 55 && age < 75)
    {
        Console.WriteLine("Yaşlısınız.");
    }
    else if (age >= 75 && age <= 99)
    {
        Console.WriteLine("Çok yaşlısınız.");
    }
    else if (age < 0 || age > 99)
    {
        Console.WriteLine("Ya hiç doğmadınız ya da çoktan öldünüz...");
    }
    else
    {                                                                  // Muhtemelen "Dead Zone" olarak nitelendirebiliriz.
        Console.WriteLine("Oops! Sanırım geçersiz bir yaş girdiniz."); // Fakat, ne olur ne olmaz girdiyi kontrol etmek istedim.
    }                                                                    
}
    
    // Araklıklar Kontrol Edildi.

YasKategorisi(-1); // Ya hiç doğmadınız ya da çoktan öldünüz...
YasKategorisi(0);  // Küçüksünüz.
YasKategorisi(1);  // Küçüksünüz.
YasKategorisi(17); // Küçüksünüz.
YasKategorisi(18); // Gençsiniz.
YasKategorisi(19); // Gençsiniz.
YasKategorisi(34); // Gençsiniz.
YasKategorisi(35); // Yetişkinsiniz.
YasKategorisi(36); // Yetişkinsiniz.
YasKategorisi(54); // Yetişkinsiniz.
YasKategorisi(55); // Yaşlısınız.
YasKategorisi(56); // Yaşlısınız.
YasKategorisi(74); // Yaşlısınız.
YasKategorisi(75); // Çok yaşlısınız.
YasKategorisi(76); // Çok yaşlısınız.
YasKategorisi(98); // Çok yaşlısınız.
YasKategorisi(99); // Çok yaşlısınız.
YasKategorisi(100); // Ya hiç doğmadınız ya da çoktan öldünüz...





