namespace Data
{
    public class CityRepository : Base.Repository<Models.City> , ICityRepository
    {
        internal CityRepository(DatabaseContext databaseContext) : base(databaseContext)
        {
        }
    }
}