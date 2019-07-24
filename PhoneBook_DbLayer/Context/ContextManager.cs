using PhoneBook_DbLayer.Repositories;
using PhoneBook_DbLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook_DbLayer.Context
{
    public class ContextManager : IDisposable
    {
        Contact_DBEntities db = new Contact_DBEntities();

        private IUserRepository _userRepository;

        public IUserRepository UserRepository
        {
            get
            {
                if (_userRepository == null)
                {
                    _userRepository = new UserRepository(db);
                }
                return _userRepository;

            }
        }


        public void saveChanges()
        {
            db.SaveChanges();
        }
        public void Dispose()
        {
            db.Dispose();
        }
    }
}
