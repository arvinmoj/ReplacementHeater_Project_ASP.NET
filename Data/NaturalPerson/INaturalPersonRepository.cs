using System;
namespace Data
{
    public interface INaturalPersonRepository :  Base.IRepository<Models.NaturalPerson>
    {
        bool Any(Guid id);
    }
}
