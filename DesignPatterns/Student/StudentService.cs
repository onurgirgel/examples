using DesignPatterns.Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Student
{
    public class StudentService : IStudentService
    {
        private Logger _logger;
        public StudentService(Logger? log) => _logger = log;
        public void Add()
        {
            Console.WriteLine("Öğrenci sisteme eklendi");
            _logger.Log("Kullanıcı sisteme öğrenci eklendi");
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void List()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
