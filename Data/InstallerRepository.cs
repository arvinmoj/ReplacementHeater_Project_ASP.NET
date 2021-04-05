using System;
using System.Linq;

namespace Data
{
    public class InstallerRepository : Base.Repository<Models.Installer>, IInstallerRepository
    {
        internal InstallerRepository(DatabaseContext databaseContext) : base(databaseContext)
        {
        }

		public bool Any(Guid id)
		{
			var result =
				DbSet.Any(e => e.InstallerId == id) ;

			return result;
		}
	}
}