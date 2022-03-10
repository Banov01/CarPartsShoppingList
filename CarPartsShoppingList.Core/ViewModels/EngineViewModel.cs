using System.ComponentModel;

namespace CarPartsShoppingList.ViewModels
{
    public class EngineViewModel
    {
        public int Id { get; set; }

        [DisplayName("Engine name")]
        public string EngineName { get; set; }

        [DisplayName("Engine category")]
        public string EngineCategory { get; set; }

        [DisplayName("Engine cubature")]
        public double Cubature { get; set; }

        [DisplayName("Engine cilinders")]
        public int Cilinders { get; set; }

        [DisplayName("Engine price")]
        public decimal Price { get; set; }

        [DisplayName("Engine code")]
        public string Code { get; set; }

    }
}
