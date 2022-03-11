using System.ComponentModel;

namespace CarPartsShoppingList.ViewModels
{
    public class SuspensionViewModel
    {
        public int Id { get; set; }

        [DisplayName("Име на окачване")]
        public string SuspensionName { get; set; }

        [DisplayName("Цена на окачване")]
        public decimal SuspensionPrice { get; set; }

        [DisplayName("Код на окачване")]
        public string SuspensionCode { get; set; }

    }
}
