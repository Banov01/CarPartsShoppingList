using CarPartsShoppingList.Core.Services;
using CarPartsShoppingList.Core.ViewModels;
using CarPartsShoppingList.Data;
using CarPartsShoppingList.Infrastructure.Data.Common;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System.Linq;
using System.Threading.Tasks;

namespace CarPartsShoppingList.Test
{
    [TestFixture]
    public class SuspensionServiceTest
    {
        private ApplicationDbContext dbContext;
        private SuspensionService suspensionService;
        private IRepository iRepository;

        [SetUp]
        public void Setup()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
            .UseInMemoryDatabase("MemoryDB").Options;
            this.dbContext = new ApplicationDbContext(options);
            this.iRepository = new Repository(dbContext);
            suspensionService = new SuspensionService(iRepository);
        }

        [Test]
        public void Get_Suspension_Is_Not_Null()
        {
            var result = suspensionService.GetSuspensions();
            Assert.IsNotNull(result, "Suspension is null.");
        }

        [Test]
        public void Get_Suspensions_Is_Not_Empty()
        {
            IQueryable<SuspensionViewModel> result = suspensionService.GetSuspensions();
            Assert.IsNotEmpty(result, "Suspension list is not empty.");
        }

        [Test]
        public async Task Get_Suspension_Match()
        {
            await this.suspensionService.SaveData(new SuspensionViewModel()
            {
                Id = 1,
                SuspensionName="test name",
                SuspensionCode="test code",
                SuspensionPrice =8M,
            });
            var result = suspensionService.GetSuspensionModel(1);
            Assert.NotNull(result);
        }
    }
}