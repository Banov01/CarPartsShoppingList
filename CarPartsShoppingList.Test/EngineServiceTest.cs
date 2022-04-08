using CarPartsShoppingList.Core.Services;
using CarPartsShoppingList.Infrastructure.Data.Common;
using Moq;
using NUnit.Framework;

namespace CarPartsShoppingList.Test
{
    [TestFixture]
    public class EngineServiceTest
    {
        private EngineService engineService;
        private Mock<IRepository> iRepository;

        [SetUp]
        public void Setup()
        {
            var iRepository = new Mock<IRepository>();

            engineService = new EngineService(iRepository.Object);
        }

        [Test]
        public void Get_Engine_Is_Not_Null()
        {
            var result = engineService.GetEngines();
            Assert.IsNotNull(result, "Engine is null.");
        }
    }
}