using CarPartsShoppingList.Core.Services;
using CarPartsShoppingList.Core.ViewModels;
using CarPartsShoppingList.Infrastructure.Data.Common;
using Moq;
using NUnit.Framework;
using System.Linq;

namespace CarPartsShoppingList.Test
{
    [TestFixture]
    public class SuspensionServiceTest
    {
        private SuspensionService suspensionService;
        private Mock<IRepository> iRepository;

        [SetUp]
        public void Setup()
        {
            var iRepository = new Mock<IRepository>();

            suspensionService = new SuspensionService(iRepository.Object);
        }

        [Test]
        public void Get_Suspension_Is_Not_Null()
        {
            var result = suspensionService.GetSuspensions();
            Assert.IsNotNull(result, "Suspension is null.");
        }

        [Test]
        public void Get_Suspensions_Is_Empty()
        {
            IQueryable<SuspensionViewModel> result = suspensionService.GetSuspensions();
            Assert.IsEmpty(result, "Suspension list is not empty.");
        }
    }
}