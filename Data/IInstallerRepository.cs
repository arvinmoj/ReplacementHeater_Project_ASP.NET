using System;

namespace Data
{
    public interface IInstallerRepository : Base.IRepository<Models.Installer>
    {
        bool Any(Guid id);
    }
}
