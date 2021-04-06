using System;
using System.Linq;

namespace Data
{
    public class NaturalPersonRepository : Base.Repository<Models.NaturalPerson> , INaturalPersonRepository
    {
        internal NaturalPersonRepository(DatabaseContext databaseContext) : base(databaseContext)
        {
        }

        public bool Any(Guid id)
        {
            var result =
                DbSet.Any(e => e.NaturalPersonId == id);

            return result;
        }
    }
}