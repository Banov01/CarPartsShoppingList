using System.ComponentModel;

namespace CarPartsShoppingList.ViewModels
{
    public class TransmissionViewModel
    {
        public int Id { get; set; }

        [DisplayName("Transmission name")]
        public string Name { get; set; }

        [DisplayName("Transmission price")]
        public decimal Price { get; set; } 

        [DisplayName("Transmission code")]
        public string Code { get; set; }

    }
}
