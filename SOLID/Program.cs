#region SINGLE RESPONSIBILITY PRINCIPLE (Tek Sorumluluk)
// Bir sınıf yalnızca bir sorumluluğa sahip olmalıdır. Değişiklik gereksinimi yalnızca bu sorumluluğa göre olmalıdır
//using SOLID.SingleResponsibilty;

//StudentService studentService = new StudentService();
//studentService.CreateStudent();

//MailService mailService = new MailService();
//mailService.SendMail("Mail konusu", "Mail içeriği");
#endregion

#region OPEN/CLOSED PRINCIPLE (Açık/Kapalı)
// Sınıflar genişlemeye açık, değişikliklere kapalı olmalıdır.
//using SOLID.OpenClose;

//Daire daire = new Daire(5);
//Console.WriteLine($"Dairenin Alanı: {daire.Alan()}");

//Kare kare = new Kare(5);
//Console.WriteLine($"Karenin Alanı: {kare.Alan()}");

#endregion

#region LISKOV SUBSTİTUTION PRICIPLE
// Alt sınıflar, üst sınıfların yerine geçmeli ve sistem doğru şekilde çalışmaya devam etmelidir.
using SOLID.LiskovSubstitution;

Eagle eagle = new Eagle();
eagle.Fly();

Penguen penguen = new Penguen();
penguen.Fly();
#endregion
