//using DesignPatterns.Singleton;
//using DesignPatterns.Student;

//var logger = Logger.GetInstance();
//logger.Log("Sistem sağlıklı çalıştı");

//StudentService studentService = new StudentService(logger);
//studentService.Add();

using DesignPatterns.Factory;
using DesignPatterns.Singleton;

ISekil sekilDaire = SekilFactory.GetSekil("daire");
ISekil sekilKare = SekilFactory.GetSekil("kare");
sekilDaire.Ciz();
sekilKare.Ciz();