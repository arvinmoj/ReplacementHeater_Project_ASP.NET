using System;
using System.Linq;

namespace Data
{
    public class LegalPersonRepository : Base.Repository<Models.LegalPerson> , ILegalPersonRepository
    {
        internal LegalPersonRepository(DatabaseContext databaseContext) : base(databaseContext)
        {
        }

        public bool Any(Guid id)
        {
            var result =
                DbSet.Any(e => e.LegalPersonId == id);

            return result;
        }
    }
}