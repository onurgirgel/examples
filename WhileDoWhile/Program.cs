#region WHILE DÖNGÜSÜ
//Console.Write("Kahveyi kim içiyor? :");
//string kahveIcen = Console.ReadLine();
//Console.Write($"{kahveIcen} kahvesini kaç yudumda içer? :");
//int yudumSayisi = int.Parse(Console.ReadLine());
//int yudumIndex = 0;

//while (yudumSayisi > 0)
//{
//    Console.WriteLine($"{kahveIcen} kahvesinin {yudumIndex + 1}. yudumunu içiyor :)");
//    Thread.Sleep(3000);
//    yudumSayisi--;
//    yudumIndex++;
//}
//Console.WriteLine($"{kahveIcen} kahvesini toplam {yudumIndex} yudumda içti.");
#endregion

#region DO WHILE DÖNGÜSÜ
int sayi = 1;
do
{
    Console.WriteLine($"Sayı: {sayi}");
    sayi++;
}
while (sayi <= 5);
#endregion