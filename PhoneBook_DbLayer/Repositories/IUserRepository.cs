using PhoneBook_ViewModels.User;
using System.Collections.Generic;

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

        bool DeleteNumber(int userId);

        bool DeleteNumber(Numbers number);

        List<Numbers> GetNumbersByUserId(int userId);

        void SendSMS();

        IEnumerable<User> getUserByFilter(string pparam);

        IEnumerable<ListUserViewModel> GetNumbersByUser(int userId);

    }
}
