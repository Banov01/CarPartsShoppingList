﻿using CarPartsShoppingList.Core.Contracts;
using CarPartsShoppingList.Core.ViewModels;
using CarPartsShoppingList.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace CarPartsShoppingList.Areas.Admin.Controllers
{
    public class SuspensionController : BaseController
    {
        private readonly ISuspensionService suspensionService;

        public SuspensionController(ISuspensionService suspensionService)
        {
            this.suspensionService = suspensionService;
        }
        public IActionResult Index()
        {
            var tableViewModel = suspensionService.GetSuspensions().ToList();

            return View(tableViewModel);
        }

        public IActionResult Add()
        {
            var viewModel = new SuspensionViewModel();

            return View("Edit", viewModel);
        }

        public IActionResult Edit(int id)
        {
            var model = suspensionService.GetSuspensionModel(id);

            return View("Edit", model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(SuspensionViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }
            var result = await suspensionService.SaveData(viewModel);

            this.ShowNotificationMessageOnUI(result);

            return RedirectToAction("Index", "Suspension");
        }
    }
}
