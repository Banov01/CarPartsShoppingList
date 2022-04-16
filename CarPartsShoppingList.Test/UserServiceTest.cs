using CarPartsShoppingList.Core.Services;
using CarPartsShoppingList.Data;
using CarPartsShoppingList.Infrastructure.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System.Threading.Tasks;

namespace CarPartsShoppingList.Test
{
    [TestFixture]
    public class UserServiceTest
    {
        private ApplicationDbContext dbContext;
        private UserService userService;
        private IApplicatioDbRepository iRepository;
        [SetUp]
        public void Setup()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
               .UseInMemoryDatabase("MemoryDB").Options;
            this.dbContext = new ApplicationDbContext(options);
            this.iRepository = new ApplicatioDbRepository(dbContext);
            userService = new UserService(iRepository);
        }

        [Test]
        public async Task Get_User_By_Id_Is_Not_NUll()
        {
            await userService.AddAsync(new Core.ViewModels.UserEditViewModel()
            {
                Id = "first user id",
                FirstName = "First name",
                LastName = "Last name",

            });
            var result = await userService.GetUserById("first user id");
            Assert.NotNull(result);
        }

        [Test]
        public void Get_User_By_Id_Is_Complete()
        {
            var result = userService.GetUserById("");
            Assert.That(result.IsCompleted, "Get user by id is not completed.");
        }
    }
}