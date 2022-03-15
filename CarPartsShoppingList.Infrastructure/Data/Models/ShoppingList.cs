using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarPartsShoppingList.Infrastructure.Data.Models
{
    [Table("shopping_list")]
    [DisplayName("ShoppingList")]
    public class ShoppingList : BaseModel
    {
        public List<ShoppingListItem> ShoppingListItems { get; set; }
    }
}
