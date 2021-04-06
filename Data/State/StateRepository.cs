using System;
using System.Collections.Generic;
using System.Linq;


namespace Data
{
    public class StateRepository : Base.Repository<Models.State> , IStateRepository
    {
        public StateRepository(DatabaseContext databaseContext) : base(databaseContext)
        {
        }

        public List<Models.State> States(Guid id)
        {
            var result =
                DbSet
                .Where(current => current.City.IdCity == id)
                .ToList()
                ;

            return result;
        }
    }
}