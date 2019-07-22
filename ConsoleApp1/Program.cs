using PhoneBook_DbLayer;
using PhoneBook_DbLayer.Context;
using PhoneBook_DbLayer.Repositories;
using PhoneBook_DbLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ContextManager db = new ContextManager();
            var list = db.UserRepository.GetAllContacts();
            db.Dispose();



            //Contact_DBEntities db = new Contact_DBEntities();
            //IUserRepository userRepo = new UserRepository(db);
            //User user = new User()
            //{
            //    Name="علی",
            //    LastName="نقوی",
            //};
            ////userRepo.AddNewContact(user);
            ////userRepo.SaveChanges();


            //List<User> list = userRepo.GetAllContacts();
            //Console.WriteLine(list.Count);
            //Console.ReadKey();
        }
    }
}
