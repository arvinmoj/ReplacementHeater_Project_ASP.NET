namespace Data
{
    public class ShokatHeaterRepository : Base.Repository<Models.ShokatHeater> , IShokatHeaterRepository
    {
        public ShokatHeaterRepository(DatabaseContext databaseContext) : base(databaseContext)
        {
        }
    }
}
