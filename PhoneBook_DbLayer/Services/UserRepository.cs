﻿using PhoneBook_DbLayer.Repositories;
using PhoneBook_ViewModels.User;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace PhoneBook_DbLayer.Services
{
    public class UserRepository : IUserRepository
    {
        private Contact_DBEntities db; // :O  :| Constructor Injection  -- will be initilized in constructor

        public UserRepository(Contact_DBEntities context)
        {
            db = context;
        }

        public bool AddNewContact(User user)
        {

            try
            {
                db.User.Add(user);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool DeleteContact(User user)
        {
            try
            {
                db.Entry(user).State = EntityState.Deleted;
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }


        public bool DeleteContact(int userId)
        {
            try
            {
                User user = GetContactById(userId);
                DeleteContact(user);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool DeleteNumber(int userId)
        {
            throw new NotImplementedException();
        }

        public bool DeleteNumber(Numbers number)
        {
            db.Entry(number).State = EntityState.Deleted;
            return true;
        }

        public List<User> GetAllContacts()
        {
            return db.User.ToList();
        }

        public User GetContactById(int userId)
        {
            return db.User.Find(userId);
        }

        public IEnumerable<ListUserViewModel> GetNumbersByUser(int userId)
        {

           
            return db.Numbers.Where(u => u.userId.Equals(userId)).Select(u => new ListUserViewModel
            {
                Numbers = u.number
            }).ToList();
        }

        public List<Numbers> GetNumbersByUserId(int userId)
        {
            return db.Numbers.Select(u => u).Where(u => u.userId.Equals(userId)).ToList();
        }

        public IEnumerable<User> getUserByFilter(string pparam)
        {
            return db.User.Where(u => u.Name.Contains(pparam) || u.LastName.Contains(pparam) || u.NationalCode.Contains(pparam)).ToList();
        }



        public void SendSMS()
        {
            throw new NotImplementedException();
        }

        public bool UpdateContact(User user)
        {
            try
            {
                User local = db.Set<User>()
                            .Local
                            .FirstOrDefault(f => f.UserId == user.UserId);
                if (local != null)
                {
                    db.Entry(local).State = EntityState.Detached;
                }
                db.Entry(user).State = EntityState.Modified;
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
