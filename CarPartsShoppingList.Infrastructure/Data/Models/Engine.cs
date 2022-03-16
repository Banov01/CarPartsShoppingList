using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarPartsShoppingList.Infrastructure.Data.Models
{
    [Table("engines")]
    [DisplayName("Engine")]
    public class Engine : BaseModel
    {
        [DisplayName("Cubature")]
        public double Cubature { get; set; }

        [DisplayName("Cilinders")]
        public int Cilinders { get; set; }

        [DisplayName("Category")]
        public string EngineCategory { get; set; }
    }
}
