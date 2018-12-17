using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class UserContext: DbContext
    {
        public UserContext() :
        base("DbConnection")
        { }

        public DbSet<User> User { get; set; }

        public User GetUser(UserContext userContext,int id)
        {
            return userContext.User.FirstOrDefault(m => m.Id == id);
        }
        public void Insert(UserContext userContext,User user)
        {
            userContext.User.Add(user);
            userContext.SaveChanges();
        }
        public void Delete(UserContext userContext,int id)
        {
            User user = userContext.User.Find(id);
            userContext.User.Remove(user);
            userContext.SaveChanges();
        }
        public void Update(UserContext userContext,User user)
        {
            userContext.Entry(user).State = EntityState.Modified;
            userContext.SaveChanges();
        }
    }
}