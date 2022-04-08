using CarPartsShoppingList.Core.Services;
using CarPartsShoppingList.Infrastructure.Data.Common;
using Moq;
using NUnit.Framework;

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
    }
}