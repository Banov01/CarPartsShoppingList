using CarPartsShoppingList.Core.Contracts;
using CarPartsShoppingList.Core.Services;
using CarPartsShoppingList.Core.ViewModels;
using CarPartsShoppingList.Infrastructure.Data.Common;
using Moq;
using NUnit.Framework;
using System.Linq;

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
            iRepository = new Mock<IRepository>();
            engineService = new EngineService(iRepository.Object);
        }

        [Test]
        public void Get_Engines_Is_Not_Null()
        {
            var result = engineService.GetEngines();
            Assert.IsNotNull(result, "Engine is null.");
        }

        [Test]
        public void Get_Engines_Is_Empty()
        {
            IQueryable<EngineViewModel> result = engineService.GetEngines();
            Assert.IsEmpty(result, "Engine list is not empty.");
        }
    }
}