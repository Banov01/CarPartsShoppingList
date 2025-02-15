﻿using CarPartsShoppingList.Core.Contracts;
using CarPartsShoppingList.Core.ViewModels;
using CarPartsShoppingList.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace CarPartsShoppingList.Areas.Admin.Controllers
{
    public class TransmisionController : BaseController
    {
        private readonly ITransmisionService transmisionService;

        public TransmisionController(ITransmisionService transmisionService)
        {
            this.transmisionService = transmisionService;
        }
        public IActionResult Index()
        {
            var tableViewModel = transmisionService.GetTransmisions().ToList();

            return View(tableViewModel);
        }
        public IActionResult Add()
        {
            var viewModel = new TransmisionViewModel();

            return View("Edit", viewModel);
        }
        public IActionResult Edit(int id)
        {
            var model = transmisionService.GetTransmisionModel(id);

            return View("Edit", model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(TransmisionViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }
            var result = await transmisionService.SaveData(viewModel);

            this.ShowNotificationMessageOnUI(result);

            return RedirectToAction("Index", "Transmision");
        }
    }
}
