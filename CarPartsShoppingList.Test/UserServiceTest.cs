using CarPartsShoppingList.Core.Services;
using CarPartsShoppingList.Infrastructure.Data.Repositories;
using Moq;
using NUnit.Framework;

namespace CarPartsShoppingList.Test
{
    [TestFixture]
    public class UserServiceTest
    {
        private UserService userService;
        private Mock<IApplicatioDbRepository> repo;
        [SetUp]
        public void Setup()
        {
            var repo = new Mock<IApplicatioDbRepository>();

            userService = new UserService(repo.Object);
        }

        [Test]
        public void Get_User_By_Id_Is_Not_NUll()
        {
            var result = userService.GetUserById("");
            Assert.That(result, Is.Not.Null, "User id is null.");
        }

        [Test]
        public void Get_User_By_Id_Is_Complete()
        {
            var result = userService.GetUserById("");
            Assert.That(result.IsCompleted, "Get user by id is'n completed.");
        }
    }
}