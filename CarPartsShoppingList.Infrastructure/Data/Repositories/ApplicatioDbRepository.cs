using CarPartsShoppingList.Data;
using CarPartsShoppingList.Infrastructure.Data.Common;

namespace CarPartsShoppingList.Infrastructure.Data.Repositories
{
    public class ApplicatioDbRepository : Repository, IApplicatioDbRepository
    {
        public ApplicatioDbRepository(ApplicationDbContext context)
        {
            this.Context = context;
        }
    }
}
