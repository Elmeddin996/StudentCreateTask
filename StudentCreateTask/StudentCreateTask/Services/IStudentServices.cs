using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCreateTask.Services
{
    internal interface IStudentServices
    {
        public void Create(string name, string surname);
        public void Delete(int id);
        public void Edit(int id, string name, string surname);
        public void GetAll();
        public void GetById(int id);
    }
}
