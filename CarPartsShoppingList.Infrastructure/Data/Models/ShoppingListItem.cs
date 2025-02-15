﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarPartsShoppingList.Infrastructure.Data.Models
{
    [Table("shopping_list_items")]
    [DisplayName("ShoppingListItems")]
    public class ShoppingListItem : BaseModel
    {
        public int? ShoppingListId { get; set; }
        public int? EngineId { get; set;}
        public int? TransmisionId { get; set;}
        public int? SuspensionId { get; set;}

        [ForeignKey(nameof(ShoppingListId))]
        public ShoppingList ShoppingList { get; set; }

        [ForeignKey(nameof(EngineId))]
        public Engine Engine { get; set;}

        [ForeignKey(nameof(TransmisionId))]
        public Transmision Transmision { get; set;}

        [ForeignKey(nameof(SuspensionId))]
        public Suspension Suspension { get; set;}
    }
}
