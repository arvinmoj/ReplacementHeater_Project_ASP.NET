using System;
namespace Data
{
    public interface ILegalPersonRepository : Base.IRepository<Models.LegalPerson>
    {
        bool Any(Guid id);
    }
}
