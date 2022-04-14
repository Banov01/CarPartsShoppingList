using CarPartsShoppingList.Core.Contracts;
using CarPartsShoppingList.Core.Services;
using CarPartsShoppingList.Core.ViewModels;
using CarPartsShoppingList.Infrastructure.Data.Common;
using CarPartsShoppingList.Infrastructure.Data.Models;
using Moq;
using NUnit.Framework;
using System.Linq;
using System.Threading.Tasks;

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

        [Test]
        public void Get_Transmisions_Is_Empty()
        {
            IQueryable<TransmisionViewModel> result = transmisionService.GetTransmisions();
            Assert.IsEmpty(result, "Transmision list is not empty.");
        }

        //[Test]
        //public async Task Get_Engine_Match()
        //{
        //    Mock<ITransmisionService> transmisionService = new Mock<ITransmisionService>();
        //    transmisionService
        //        .Setup(x => x.GetTransmisions());

        //    Mock<IRepository> repository = new Mock<IRepository>();
        //    repository
        //        .Setup(y =>y.AllReadonly<Transmision>())
        //        .Returns(new List<TransmisionViewModel>()
        //        {
        //            new TransmisionViewModel()
        //            { 
        //                Id = 1,
        //                TransmisionName = "VW Golf transmision",
        //                TransmisionCode ="898765",
        //                TransmisionPrice =299,
        //            }
        //        });
        //}
    }
}