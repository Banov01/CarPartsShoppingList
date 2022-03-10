using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CarPartsShoppingList.Infrastructure.Models
{
    public class BaseModel
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Name")]
        public string Name { get; set; }

        [DisplayName("Price")]
        public decimal Price { get; set; }

        [DisplayName("Code")]
        public string Code { get; set; }

        public bool IsActive { get; set; }

    }
}
