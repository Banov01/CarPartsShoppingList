using CarPartsShoppingList.Core.Services;
using CarPartsShoppingList.Infrastructure.Data.Common;
using CarPartsShoppingList.Infrastructure.Data.Repositories;
using Moq;
using NUnit.Framework;
using System;

namespace CarPartsShoppingList.Test
{
    [TestFixture]
    public class ShoppingListTest
    {
        private ShoppingListService shoppingListService;
        private Mock<IRepository> iRepository;
        [SetUp]
        public void Setup()
        {
            var iRepository = new Mock<IApplicatioDbRepository>();

            shoppingListService = new ShoppingListService(iRepository.Object);
        }

        [Test]
        public void Get_Shopping_Lists_Is_Not_Null()
        {
            var result = shoppingListService.GetShoppingLists();
            Assert.IsNotNull(result, "The list is null.");
        }

        [Test]
        public void Get_Shopping_List_Items_Are_Not_Null()
        {
            var result = shoppingListService.GetShoppingListItems(1);
            Assert.IsNotNull(result, "Items are null.");
        }

        //[Test]
        //public void Save_Data_Should_Throw()
        //{
        //    Assert.Catch<ArgumentException>(() => shoppingListService.SaveData(), "It's not the exact exception.");
        //}
    }
}