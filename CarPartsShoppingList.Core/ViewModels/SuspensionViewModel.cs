using System.ComponentModel;

namespace CarPartsShoppingList.ViewModels
{
    public class SuspensionViewModel
    {
        public int Id { get; set; }

        [DisplayName("Suspension name")]
        public string Name { get; set; }

        [DisplayName("Suspension price")]
        public decimal Price { get; set; }

        [DisplayName("Suspension Code")]
        public string Code { get; set; }

    }
}
