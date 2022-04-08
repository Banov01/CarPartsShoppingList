using CarPartsShoppingList.Core.Services;
using CarPartsShoppingList.Infrastructure.Data.Common;
using Moq;
using NUnit.Framework;

namespace CarPartsShoppingList.Test
{
    [TestFixture]
    public class TransmisionServiceTest
    {
        private TransmisionService transmisionService;
        private Mock<IRepository> iRepository;

        [SetUp]
        public void Setup()
        {
            var iRepository = new Mock<IRepository>();

            transmisionService = new TransmisionService(iRepository.Object);
        }

        [Test]
        public void Get_Transmision_Is_Not_Null()
        {
            var result = transmisionService.GetTransmisions();
            Assert.IsNotNull(result, "Transmision is null.");
        }
    }
}