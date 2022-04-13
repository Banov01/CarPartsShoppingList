using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CarPartsShoppingList.Core.ViewModels
{
    public class EngineViewModel
    {
        public int Id { get; set; }

        [Required]
        [DisplayName("Engine name")]
        [StringLength(20)]
        public string EngineName { get; set; }

        [Required]
        [DisplayName("Engine category")]
        [StringLength(10)]
        public string EngineCategory { get; set; }

        [Required]
        [DisplayName("Cubature")]
        public double Cubature { get; set; }

        [Required]
        [DisplayName("Cilinders")]
        public int Cilinders { get; set; }

        [DisplayName("Engine price")]
        public decimal EnginePrice { get; set; }

        [Required]
        [DisplayName("Engine code")]
        [StringLength(12)]
        public string EngineCode { get; set; }

    }
}
