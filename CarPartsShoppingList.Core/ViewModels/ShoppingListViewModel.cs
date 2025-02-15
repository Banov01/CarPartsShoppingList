﻿using CarPartsShoppingList.Infrastructure.Data.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CarPartsShoppingList.Core.ViewModels
{
    public class ShoppingListViewModel
    {
        public int Id { get; set; }

        [Required]
        [DisplayName("Shopping list name")]
        [StringLength(25)]
        public string ShoppingListName { get; set; }

        [DisplayName("Shopping list items")]
        public List<ShoppingListItem> ShoppingListItems { get; set; }
    }
}
