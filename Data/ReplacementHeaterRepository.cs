using System;
using System.Linq;

namespace Data
{
    public class ReplacementHeaterRepository : Base.Repository<Models.ReplacementHeater> , IReplacementHeaterRepository
    {
        public ReplacementHeaterRepository(DatabaseContext databaseContext) : base(databaseContext)
        {
        }

        public bool Any(Guid id)
        {
            var result =
                DbSet.Any(e => e.ReplacementHeaterId == id);

            return result;
        }
    }
}
