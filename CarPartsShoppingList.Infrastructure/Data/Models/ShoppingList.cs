using CarPartsShoppingList.Infrastructure.Data.Identity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarPartsShoppingList.Infrastructure.Data.Models
{
    [Table("shopping_list")]
    [DisplayName("ShoppingList")]
    public class ShoppingList : BaseModel
    {
        public string ApplicationUserId {get;set;}

        [ForeignKey (nameof(ApplicationUserId))]
        public ApplicationUser ApplicationUser {get;set;}
        public List<ShoppingListItem> ShoppingListItems { get; set; }
    }
}
