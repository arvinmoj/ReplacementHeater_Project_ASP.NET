using System;
namespace Data
{
    public interface IReplacementHeaterRepository : Base.IRepository<Models.ReplacementHeater> 
    {
        bool Any(Guid id);
    }
}
