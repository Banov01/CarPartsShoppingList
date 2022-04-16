using CarPartsShoppingList.Core.Contracts;
using CarPartsShoppingList.Core.Services;
using CarPartsShoppingList.Core.ViewModels;
using CarPartsShoppingList.Data;
using CarPartsShoppingList.Infrastructure.Data.Common;
using CarPartsShoppingList.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarPartsShoppingList.Test
{
    [TestFixture]
    public class TransmisionServiceTest
    {
        private ApplicationDbContext dbContext;
        private TransmisionService transmisionService;
        private IRepository iRepository;

        [SetUp]
        public void Setup()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase("MemoryDB").Options;
            this.dbContext = new ApplicationDbContext(options);
            this.iRepository = new Repository(dbContext);
            transmisionService = new TransmisionService(iRepository);
        }

        [Test]
        public void Get_Transmision_Is_Not_Null()
        {
            var result = transmisionService.GetTransmisions();
            Assert.IsNotNull(result, "Transmision is null.");
        }

        [Test]
        public void Get_Transmisions_Is_Not_Empty()
        {
            IQueryable<TransmisionViewModel> result = transmisionService.GetTransmisions();
            Assert.IsNotEmpty(result, "Transmision list is not empty.");
        }

        [Test]
        public async Task Get_Transmision_Match()
        {
            await this.transmisionService.SaveData(new TransmisionViewModel()
            {
                Id = 1,
                TransmisionName = "Test",
                TransmisionPrice = 1M,
                TransmisionCode = "code"
            });

            var result = transmisionService.GetTransmisionModel(1);
            Assert.NotNull(result);
        }
    }
}