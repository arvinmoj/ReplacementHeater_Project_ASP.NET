using System;

namespace Data
{
    public interface IStateRepository : Base.IRepository<Models.State>
    {
        System.Collections.Generic.List<Models.State> States(Guid id);
    }
}