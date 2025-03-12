/* 
   Öncelikle While ve Do-While döngülerine bir bakış atalım.

    While   --> Önceden belirlenmiş bir koşul bozulana kadar devam eder. Koşulun her kontrolünden sonra döngü içerisindeki işlemler
                                                bir kez yapılır. Koşul true olduğu sürece çalışır.
                Basic sample:  While (koşul)
                    {
                        yapılacak işlemler
                    }
--------------------------------------------
    Do-while  --> Do while döngüsü koşul yanlış olsa bile en az bir kere dener. Bu durum yanlış anlaşılmaya musait bu nedenle bir örnek yapalım.
    
                Basic sample: do{
                
                 Bu kısım, her zaman en az bir kez çalışır
                
                }while(koşul)
*/


int i = 1;
do                                                 // Bu örnekte temel amacımız i 'nin son değerini açıklamak. Böylece döngünü son aşamalarında ne olduğunu anlayabiliriz.
{
    Console.WriteLine(i);
    i++;  // i'yi bir artırır
} while (i <= 3);  // i 3'ten büyük olduğunda döngü sonlanır


/*Başlangıç:

i = 1 olarak başlıyoruz.
1. Adım:
Döngü ilk kez çalıştırılır.
i değeri 1 yazdırılır.
i bir artırılır, yani i = 2 olur.

2. Adım:
Döngü tekrar çalıştırılır.
i değeri 2 yazdırılır.
i bir artırılır, yani i = 3 olur.

3. Adım:
Döngü bir kez daha çalıştırılır.
i değeri 3 yazdırılır.
i bir artırılır, yani i = 4 olur.
Koşul Kontrolü:

Şimdi, koşul (i <= 3) kontrol edilir.
i = 4 olduğunda koşul 4 <= 3 false olur.
Bu durumda döngü sona erer.
Sonuç:
Döngü sonlanmadan önce i = 4 olmuştur.
Bu nedenle, döngü tamamlandıktan sonra i'nin son değeri 4 olacaktır.

Koşul false olduktan sonra tekrar do kısmı çalışmadı döngü sona erdi. Bu kısım önemliydi.

*/