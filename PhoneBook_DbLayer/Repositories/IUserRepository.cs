using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook_DbLayer.Repositories
{
    public interface IUserRepository
    {
        List<User> GetAllContacts();

        User GetContactById(int userId);

        bool AddNewContact(User user);

        bool UpdateContact(User user);

        bool DeleteContact(User user);

        bool DeleteContact(int userId);

        void SaveChanges();

        void SendSMS();
    }
}
