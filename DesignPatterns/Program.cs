
#region SINGLETON PATTERN
//using DesignPatterns.Singleton;
//using DesignPatterns.Student;

//var logger = Logger.GetInstance();
//logger.Log("Sistem sağlıklı çalıştı");

//StudentService studentService = new StudentService(logger);
//studentService.Add();
#endregion

#region FACTORY PATTERN
//using DesignPatterns.Factory;
//using DesignPatterns.Singleton;

//ISekil sekilDaire = SekilFactory.GetSekil("daire");
//ISekil sekilKare = SekilFactory.GetSekil("kare");
//sekilDaire.Ciz();
//sekilKare.Ciz();
#endregion

#region STRATEGY PATTERN
using DesignPatterns.Strategy;

var cebimdekipara = 1000;
double anlikfiyat = 0;
Console.Write("Lütfen ürün kodunu söyle:");
string kod = Console.ReadLine();
if (kod == "adidas")
    anlikfiyat = 1100;
else if (kod == "zara")
    anlikfiyat = 1300;
else
    anlikfiyat = 1000;

if (anlikfiyat > cebimdekipara)
{
    //KREDİ KARTI
    var f = new FiyatStrategy { strateji = new Yuzde10() };
    Console.WriteLine($"Ödeme yöntemi kredi kartı --> ürün satış fiyati {anlikfiyat}, indirimli fiyatı {f.Hesapla(anlikfiyat)} ");
}
else
{
    // NAKİT
    var f = new FiyatStrategy { strateji = new Yuzde20() };
    Console.WriteLine($"Ödeme yöntemi nakit --> ürün satış fiyati {anlikfiyat}, indirimli fiyatı {f.Hesapla(anlikfiyat)} ");
}

#endregion
