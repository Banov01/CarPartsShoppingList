using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CarPartsShoppingList.Core.ViewModels
{
    public class SuspensionViewModel
    {
        public int Id { get; set; }

        [Required]
        [DisplayName("Име на окачване")]
        [StringLength(40)]
        public string SuspensionName { get; set; }

        [DisplayName("Цена на окачване")]
        public decimal SuspensionPrice { get; set; }

        [Required]
        [DisplayName("Код на окачване")]
        [StringLength(30)]
        public string SuspensionCode { get; set; }

    }
}
