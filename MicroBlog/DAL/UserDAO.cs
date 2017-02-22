using MicroBlog.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MicroBlog.DAL
{
    public static class UserDAO
    {
        private static List<UserViewModel> users;
        
        public static UserViewModel AddUser(UserViewModel user)
        {
            if (users == null)
            {
                users = new List<UserViewModel>();
            }

            user.UserId = Guid.NewGuid();
            users.Add(user);

            return user;
        }

        public static UserViewModel Login(string login, string password)
        {
            return users.Find(u => u.UserName == login && u.Password == password);
        }

        public static UserViewModel GetById(Guid id)
        {
            return users.Find(u => u.UserId == id);
            //for(int i = 0; i< users.Count; i++)
            //{
            //    if(users[i].UserId == id)
            //    {
            //        return users[i];
            //    }
            //}
            //return null;
        }
    }
}