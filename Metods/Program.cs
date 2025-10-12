#region 1. Kısım

//DortIslemParametreli(4, 2, global::DortIslem.Toplama);
//DortIslemParametreli(4, 2, global::DortIslem.Cikartma);
//DortIslemParametreli(4, 2, global::DortIslem.Carpma);
//DortIslemParametreli(4, 2, global::DortIslem.Bolme);

//static void DortIslemParametreli(double sayi1, double sayi2, DortIslem islemTipi)
//{
//    switch (islemTipi)
//    {
//        case global::DortIslem.Toplama:
//            Console.WriteLine($"Toplama işlemnin sonucu: {sayi1 + sayi2}");

//            break;
//        case global::DortIslem.Cikartma:
//            Console.WriteLine($"Çıkartma işlemnin sonucu: {sayi1 - sayi2}");

//            break;
//        case global::DortIslem.Carpma:
//            Console.WriteLine($"Çarpma işlemnin sonucu: {sayi1 * sayi2}");

//            break;
//        case global::DortIslem.Bolme:
//            Console.WriteLine($"Bölme işlemnin sonucu: {sayi1 / sayi2}");

//            break;
//        default:
//            break;
//    }
//}


#endregion

#region 2. Kısım 
static double DortIslemGeriDonuslu(int sayi1, int sayi2, DortIslem islemTipi)
{
    switch (islemTipi)
    {
        case DortIslem.Toplama:
            return sayi1 + sayi2;
        case DortIslem.Cikartma:
            return sayi1 - sayi2;
        case DortIslem.Carpma:
            return sayi1 * sayi2;
        case DortIslem.Bolme:
            return sayi1 / sayi2;
        default:
            return 0;
    }
}
double sonuc = DortIslemGeriDonuslu(4, 2, DortIslem.Toplama);
Console.WriteLine($"Toplama işleminin sonucu: {sonuc}");
#endregion



enum DortIslem
{
    Toplama,
    Cikartma,
    Carpma,
    Bolme
}