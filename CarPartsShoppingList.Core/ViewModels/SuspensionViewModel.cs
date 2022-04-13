using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CarPartsShoppingList.Core.ViewModels
{
    public class SuspensionViewModel
    {
        public int Id { get; set; }

        [Required]
        [DisplayName("Suspension name")]
        [StringLength(20)]
        public string SuspensionName { get; set; }

        [DisplayName("Suspension price")]
        public decimal SuspensionPrice { get; set; }

        [Required]
        [DisplayName("Suspension code")]
        [StringLength(10)]
        public string SuspensionCode { get; set; }

    }
}
