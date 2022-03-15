using System.ComponentModel;

namespace CarPartsShoppingList.Core.ViewModels
{
    public class EngineViewModel
    {
        public int Id { get; set; }

        [DisplayName("Име на двигател")]
        public string EngineName { get; set; }

        [DisplayName("Категория двигател")]
        public string EngineCategory { get; set; }

        [DisplayName("Кубатура на днигател")]
        public double Cubature { get; set; }

        [DisplayName("Цилиндри на двигател")]
        public int Cilinders { get; set; }

        [DisplayName("Цена на двигател")]
        public decimal EnginePrice { get; set; }

        [DisplayName("Код на двигател")]
        public string EngineCode { get; set; }

    }
}
