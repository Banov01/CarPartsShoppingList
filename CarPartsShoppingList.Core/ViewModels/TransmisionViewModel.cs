using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CarPartsShoppingList.Core.ViewModels
{
    public class TransmisionViewModel
    {
        public int Id { get; set; }

        [Required]
        [DisplayName("Скорости")]
        [StringLength(40)]
        public string TransmisionName { get; set; }

        [DisplayName("Цена на скоростите")]
        public decimal TransmisionPrice { get; set; }

        [Required]
        [DisplayName("Код на скоростите")]
        [StringLength(30)]
        public string TransmisionCode { get; set; }

    }
}
