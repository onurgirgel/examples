#region 1. Kısım

DortIslem(4, 2, global::DortIslem.Toplama);
DortIslem(4, 2, global::DortIslem.Cikartma);
DortIslem(4, 2, global::DortIslem.Carpma);
DortIslem(4, 2, global::DortIslem.Bolme);

static void DortIslem(double sayi1, double sayi2, DortIslem islemTipi)
{
    switch (islemTipi)
    {
        case global::DortIslem.Toplama:
            Console.WriteLine($"Toplama işlemnin sonucu: {sayi1 + sayi2}");

            break;
        case global::DortIslem.Cikartma:
            Console.WriteLine($"Çıkartma işlemnin sonucu: {sayi1 - sayi2}");

            break;
        case global::DortIslem.Carpma:
            Console.WriteLine($"Çarpma işlemnin sonucu: {sayi1 * sayi2}");

            break;
        case global::DortIslem.Bolme:
            Console.WriteLine($"Bölme işlemnin sonucu: {sayi1 / sayi2}");

            break;
        default:
            break;
    }
}

 enum DortIslem
{
    Toplama,
    Cikartma,
    Carpma,
    Bolme
}
#endregion
