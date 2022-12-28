using StudentCreateTask.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCreateTask.Models
{
    public class Student:Group,IStudentServices
    {

        public static int Id;
        private string _name;
        private string _sureName;
        private int _avarage;



       
        public string Name 
        {
           get => _name;

           set
            {
                if (value.Length>3&&value.Length<15)
                {
                _name = value;
                }
                else
                {
                    Console.WriteLine("Duzgun Ad Daxil Edin");
                }
                
            }
         }
        public string SureName
        {
            get => _sureName;

            set
            {
                if (value.Length > 3 && value.Length < 15)
                {
                    _sureName = value;
                }
                else
                {
                    Console.WriteLine("Duzgun Soyad Daxil Edin");
                }

            }
        }
        public int Avarage 
        {
            get => _avarage;

            set
            {
                if (value>=0&&value<=100)
                {
                    _avarage = value;

                }
                else
                {
                    Console.WriteLine("Yanlishdir!");
                }
            }
        }

         public  Student(int num)
         {
            int secim = num;

            while (secim!=0)
            {
                
                switch (secim)
                {
                    case 1:
                        Console.WriteLine("Zehmet Olmasa Ad ve Soyad Daxil Edin");
                        Create(Console.ReadLine(), Console.ReadLine());
                        Id++;
                        break;
                    case 2:
                        Console.WriteLine("Silmek Istediyiniz Id-ni Daxil Edin");
                        Delete(int.Parse(Console.ReadLine()));
                        break;

                    case 3:
                        Console.WriteLine("Zehmet Olmasa Id, Ad ve Soyad Daxil Edin");
                        Edit(int.Parse(Console.ReadLine()), Console.ReadLine(), Console.ReadLine());
                        break;

                    case 4:
                        GetAll();
                        break;

                    case 5:
                        GetById(int.Parse(Console.ReadLine()));
                        break; 
                   
                       
                         
                    default:
                        Console.WriteLine("Duzgun Reqem Daxil Edin!!!");
                        break;
                }

            }

        }

            public void GetAll()
            {
            Console.WriteLine("Butun Telebelerin Melumatlari");
                foreach (var item in Students)
                {
                    Console.WriteLine(item);
                }

            }
      
          public void Create(string name,string surename)
           {
            int id = Id;
            id++;
                Array.Resize(ref Students, Students.Length + 1);
            Students[Students.Length - 1] = $"Id: {id}  Ad: {name}   Soyad: {surename}";
            
        }
           

        



        public void Delete(int id)
        {
           
            try
            {
             if (id == int.Parse(Students[id]))
             {
                    Students[id]= null;
                 Console.WriteLine("Bu Id Silindi");
             }
            else
            {
                Console.WriteLine("Bu Id Movcud Deyil");
            }
            }
            catch 
            {
                Console.WriteLine("Bu Id Movcud Deyil");

            }
            
        }

        public void Edit(int id, string name, string surename)
        {
            if (id != int.Parse(Students[id]))
            {
                Console.WriteLine("Bu Id-de Telebe Yoxdur");
            }
            else if (name.Length<=3&& name.Length>=15&& surename.Length <= 3 && surename.Length >= 15)
            {
                Console.WriteLine("Duzgun Ad Daxil Edin");
            }
            else
            {
                name = Students[id];
                surename = Students[id];

            }
        }

       
        
        public void GetById(int id)
        {
            if (id == int.Parse(Students[id]))
            {
                Console.WriteLine(Students[id]);
            }
            else
            {
                Console.WriteLine("Bu Id-de Telebe Yoxdur");
            }
        }

    }
}
