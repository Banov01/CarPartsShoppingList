using CarPartsShoppingList.Core.Services;
using CarPartsShoppingList.Data;
using CarPartsShoppingList.Infrastructure.Data.Common;
using CarPartsShoppingList.Infrastructure.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System.Threading.Tasks;

namespace CarPartsShoppingList.Test
{
    [TestFixture]
    public class ShoppingListTest
    {
        private ApplicationDbContext dbContext;
        private ShoppingListService shoppingListService;
        private UserService usersService;
        private EngineService engineService;
        private TransmisionService transmisionService;
        private SuspensionService suspensionService;

        private IRepository iRepository;
        private IRepository shoppingRepo;

        private IApplicatioDbRepository userRepository;
        [SetUp]
        public void Setup()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
              .UseInMemoryDatabase("MemoryDB").Options;
            dbContext = new ApplicationDbContext(options);

            iRepository = new ApplicatioDbRepository(dbContext);
            shoppingRepo = new ApplicatioDbRepository(dbContext);

            userRepository = new ApplicatioDbRepository(dbContext);

            shoppingListService = new ShoppingListService(iRepository);
            engineService = new EngineService(iRepository);
            transmisionService = new TransmisionService(iRepository);
            suspensionService = new SuspensionService(iRepository);
            usersService = new UserService(userRepository);
        }

        [Test]
        public async Task Test_Add_ShoppingList()
        {
            await usersService.AddAsync(new Core.ViewModels.UserEditViewModel()
            {
                Id = "first user id",
                FirstName = "First name",
                LastName = "Last name",
            });

            await engineService.SaveData(new Core.ViewModels.EngineViewModel()
            {
                Id = 1,
                EngineName = "Test",
                Cilinders = 5,
                Cubature = 3,
                EngineCategory = "Test category",
                EngineCode = "test code",
                EnginePrice = 8M,
            });

            await transmisionService.SaveData(new Core.ViewModels.TransmisionViewModel()
            {
                Id = 1,
                TransmisionCode = "test coe",
                TransmisionPrice = 8M,
                TransmisionName = "Test",
            });

            await suspensionService.SaveData(new Core.ViewModels.SuspensionViewModel
            {
                Id=1,
                SuspensionCode ="test code",
                SuspensionPrice =8M,
                SuspensionName = "Test",
            });

            var response = await this.shoppingListService.Add(new Core.ViewModels.ShoppingListItemViewModel()
            {
                ApplicationUserId = "first user id",
                ShoppingListName = "Test shopping list name",
                Engine = 1,
                Transmision = 1,
                Suspension = 1,
            });

            Assert.True(response);
        }

        [Test]
        public void Get_Shopping_Lists_Is_Not_Null()
        {
            var result = shoppingListService.GetShoppingLists();
            Assert.IsNotNull(result, "The list is null.");
        }
    }
}