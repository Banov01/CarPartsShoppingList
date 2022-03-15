using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CarPartsShoppingList.Core.ViewModels
{
    public class EngineViewModel
    {
        public int Id { get; set; }

        [Required]
        [DisplayName("Име на двигател")]
        [StringLength(40)]
        public string EngineName { get; set; }

        [Required]
        [DisplayName("Категория двигател")]
        [StringLength(30)]
        public string EngineCategory { get; set; }

        [Required]
        [DisplayName("Кубатура на днигател")]
        public double Cubature { get; set; }

        [Required]
        [DisplayName("Цилиндри на двигател")]
        public int Cilinders { get; set; }

        [DisplayName("Цена на двигател")]
        public decimal EnginePrice { get; set; }

        [Required]
        [DisplayName("Код на двигател")]
        [StringLength(30)]
        public string EngineCode { get; set; }

    }
}
