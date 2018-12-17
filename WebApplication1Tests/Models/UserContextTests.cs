using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.Models.Tests
{
    [TestClass()]
    public class UserContextTests
    {
        UserContext userContext = new UserContext();
        [TestMethod()]
        public void GetUserTest()
        {
           User user1 = userContext.User.Find(0);
            User user2 = new User()
            {
                Id = 0,
                Name = "Test",
                Age = 9
            };
            Assert.AreEqual(user1, user2);
        }

        [TestMethod()]
        public void InsertTest()
        {
            User user = new User();
            user.Id = 1;
            user.Name = "Test";
            user.Age = 10;
            userContext.Insert(userContext, user);
            Assert.AreEqual(userContext.User.Find(1),user);
        }

        [TestMethod()]
        public void DeleteTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void UpdateTest()
        {
            Assert.Fail();
        }
    }
}