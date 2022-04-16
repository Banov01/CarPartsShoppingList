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
    public class EngineServiceTest
    {
        private ApplicationDbContext dbContext;
        private EngineService engineService;
        private IRepository iRepository;

        [SetUp]
        public void Setup()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
            .UseInMemoryDatabase("MemoryDB").Options;
            this.dbContext = new ApplicationDbContext(options);
            this.iRepository = new Repository(dbContext);
            engineService = new EngineService(iRepository);
        }

        [Test]
        public void Get_Engines_Is_Not_Null()
        {
            var result = engineService.GetEngines();
            Assert.IsNotNull(result, "Engine is null.");
        }

        [Test]
        public void Get_Engines_Is_Not_Empty()
        {
            IQueryable<EngineViewModel> result = engineService.GetEngines();
            Assert.IsNotEmpty(result, "Engine list is not empty.");
        }

        [Test]
        public async Task Get_Engine_Match()
        {
            await this.engineService.SaveData(new EngineViewModel()
            {
                Id = 1,
                EngineName="test name",
                EngineCategory="test category",
                Cilinders=5,
                Cubature=2,
                EngineCode="test code",
                EnginePrice=8M,
            });

            var result = engineService.GetEngineModel(1);
            Assert.NotNull(result);
        }
    }
}