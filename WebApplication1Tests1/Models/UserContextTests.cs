using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace WebApplication1.Models.Tests
{
    [TestClass()]
    public class UserContextTests
    {
        [TestMethod()]
        public void UserContextTest()
        {
            Assert.Fail();
        }
        UserContext userContext = new UserContext();
        [TestMethod()]
        public void GetUserTest()
        {
            User user1 = userContext.GetUser(userContext,0);
            User user2 = new User()
            {
                Id = 0,
                Name = "Test",
                Age = 9
            };
            Assert.AreEqual(user1.Id,user2.Id);
        }

        [TestMethod()]
        public void InsertTest()
        {
            User user = new User()
            {
                Name = "Test1",
                Age = 10
            };
            userContext.User.Add(user);
            userContext.SaveChanges();
            Assert.AreEqual(userContext.User.Find(1).Id,user.Id);
        }
        [TestMethod()]
        public void UpdateTest()
        {
            User user = userContext.User.Find(1);
            user.Name = "Test2";
            userContext.Entry(user).State = EntityState.Modified;
            userContext.SaveChanges();
            Assert.AreEqual(userContext.User.Find(1).Name,user.Name);
        }
        [TestMethod()]
        public void DeleteTest()
        {
            User user = userContext.User.Find(1);
            userContext.User.Remove(user);
            userContext.SaveChanges();
            Assert.AreEqual(null,userContext.GetUser(userContext,1));
        }
    }
}