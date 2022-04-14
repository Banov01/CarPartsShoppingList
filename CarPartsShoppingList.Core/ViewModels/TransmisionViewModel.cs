using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CarPartsShoppingList.Core.ViewModels
{
    public class TransmisionViewModel
    {
        public int Id { get; set; }

        [Required]
        [DisplayName("Transmision")]
        [StringLength(35)]
        public string TransmisionName { get; set; }

        [DisplayName("Transmision price")]
        public decimal TransmisionPrice { get; set; }

        [Required]
        [DisplayName("Transmision code")]
        [StringLength(13)]
        public string TransmisionCode { get; set; }

    }
}
