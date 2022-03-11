using System.ComponentModel;

namespace CarPartsShoppingList.ViewModels
{
    public class TransmissionViewModel
    {
        public int Id { get; set; }

        [DisplayName("Скорости")]
        public string TransmisionName { get; set; }

        [DisplayName("Цена на скоростите")]
        public decimal TransmisionPrice { get; set; } 

        [DisplayName("Код на скоростите")]
        public string TransmisionCode { get; set; }

    }
}
