static void AracMuayene(int aracYasi)
{
    if (aracYasi >= 0 && aracYasi < 10)
    {
        Console.WriteLine("Arabanız yeni.");
    }
    else if (aracYasi >= 10 && aracYasi < 20)
    {
        Console.WriteLine("Servise götürmeniz gerekebilir.");
    }
    else if (aracYasi >= 20 && aracYasi <= 30)
    {
        Console.WriteLine("Arabanız hurdaya çıkabilir.");
    }
    else
    {
        Console.WriteLine("Ya hiç üretilmedi ya da trafikten men edilmiştir.");

    }
}

// Aralıklar kontrol edildi.
AracMuayene(-1);  // Ya hiç üretilmedi ya da trafikten men edilmiştir.
AracMuayene(0);   // Arabanız yeni.
AracMuayene(1);   // Arabanız yeni.
AracMuayene(9);   // Arabanız yeni.
AracMuayene(10);  // Servise götürmeniz gerekebilir.
AracMuayene(11);  // Servise götürmeniz gerekebilir.
AracMuayene(19);  // Servise götürmeniz gerekebilir.
AracMuayene(20);  // Arabanız hurdaya çıkabilir.
AracMuayene(21);  // Arabanız hurdaya çıkabilir.
AracMuayene(29);  // Arabanız hurdaya çıkabilir.
AracMuayene(30);  // Arabanız hurdaya çıkabilir.
AracMuayene(31);  // Ya hiç üretilmedi ya da trafikten men edilmiştir.
