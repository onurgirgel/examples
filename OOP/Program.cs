#region Constructor / Desctructor
// ÖDEV
#endregion

#region Encapsulation (Kapsülleme)
// ÖDEV
#endregion

#region Inheritance (Kalıtım)
// ÖDEV
#endregion

#region Polymorphism (Çok Biçimlilik)
//using OOP.Polymorphism;

//Dog dog = new Dog();
//dog.Sound();

#endregion

#region Kim milyoner olmak ister yarışması
//TODO: Sunucu karşılama yapar

using OOP;

YarismaMesajlari.YarismaBaslangicMesajiVer();
YarismaSesleri.AlkisSesiCikar(5, 2000);
string[] yarismacilar = {  "Hilal", };
Random rnd = new Random();
//TODO: Gündelik hayattan sohbet edilir
Baslangic:
Console.ForegroundColor = ConsoleColor.Green;
Console.Write($"(Sunucu) Merhaba {yarismacilar[rnd.Next(0, 1)]} yarışmamıza hoş geldiniz. Heyecanlı mısınız? (E/H) :");
string heyecanCevap = Console.ReadLine();
switch (heyecanCevap.ToUpper())
{
    case "E":
        Console.ForegroundColor = ConsoleColor.Green;
        Thread.Sleep(1000);
        Console.WriteLine("(Sunucu) Heyecanlı olmanıza gerek yok. Sakin olmanız size yarışmada başarılı olma şansınızı artırır. Bol şans diliyorum");
        break;
    case "H":
        Console.ForegroundColor = ConsoleColor.Green;
        Thread.Sleep(1000);
        Console.WriteLine("(Sunucu) Süper. Sakin olmanız size yarışmada başarılı olma şansınızı artırır. Bol şans diliyorum");
        break;
    default:
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("(Sunucu) Yanlış cevap verdiniz. Ben size heyecanlı mısınız diye soru sordum ?");
        goto Baslangic;
}
Thread.Sleep(2000);
Console.ForegroundColor = ConsoleColor.Magenta;
//TODO: Hazır olma mesajı verilir
Console.Write("(Sunucu) Şimdi !!! Yarışmaya başlayalım mı ? (E/H) :");
string yarismaBaslangicCevap = Console.ReadLine();
if (yarismaBaslangicCevap.ToUpper().Equals("E"))
{
    int kazanc = 500;
    YarismaMesajlari.YarismaBasliyorMesajiVer();
    SoruCevap soruCevap = new SoruCevap();
    for (int i = 0; i < 15; i++)
    {
    SoruyuTekrarla:
        Console.WriteLine(soruCevap.SoruSor(i));
        Console.Write("Cevabınız: ");
        string cevap = Console.ReadLine();
        Thread.Sleep(2000);
        if (cevap.ToUpper() == "A" || cevap.ToUpper() == "B" || cevap.ToUpper() == "C" || cevap.ToUpper() == "D")
        {
            bool cevapDonus = soruCevap.CevapKontrol(i, cevap.ToUpper());
            if (!cevapDonus)
            {
                Console.WriteLine("Tühhh !! Elendiniz !!. Yarışmacımıza kocaman bir alkış !!!!!!!");
                YarismaSesleri.AlkisSesiCikar(20, 0);
                Console.WriteLine($"Kazancınız: {kazanc} TL");
                break;
            }
            else
            {
                kazanc *= 2;
                YarismaSesleri.AlkisSesiCikar(5, 0);
                Console.WriteLine("Tebrikler !! Cevabınız doğru !!  ");
            }
            Console.WriteLine($"Kazancınız: {kazanc} TL");

        }
        else
        {
            Console.Write("(Sunucu) Sen kafayı mı yedin? Şıklar belli sen ne seçtin ? Soruyu tekrarlıyorum. İyi dinle.....");
            Thread.Sleep(1000);
            goto SoruyuTekrarla;
        }

    }
}
else
{
    Thread.Sleep(1000);
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("(Sunucu) Anladım! Hazır olduğunuzda lütfen tekrar yarışmamıza katılın. Size yol parası hediye ediyoruz !!! Alkışlar yarışmacımız için !!!");
    YarismaSesleri.AlkisSesiCikar(10, 2000);

}

Console.ReadKey();




#endregion