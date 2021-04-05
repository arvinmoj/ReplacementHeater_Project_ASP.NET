namespace Data
{
    public class UnitOfWork : Base.UnitOfWork, IUnitOfWork
    {
        public UnitOfWork(Tools.Options options) : base(options)
        {
        }

        // **************************************************
        //private IXXXXXRepository _xXXXXRepository;

        //public IXXXXXRepository XXXXXRepository
        //{
        //	get
        //	{
        //		if (_xXXXXRepository == null)
        //		{
        //			_xXXXXRepository =
        //				new XXXXXRepository(DatabaseContext);
        //		}

        //		return _xXXXXRepository;
        //	}
        //}
        // **************************************************

        // *****
        private ICityRepository _cityRepository;

        public ICityRepository CityRepository
        {
            get
            {
                if (_cityRepository == null)
                {
                    _cityRepository =
                       new CityRepository(DatabaseContext);
                }

                return _cityRepository;
            }
        }
        // *****

        // *****
        private IStateRepository _stateRepository;

        public IStateRepository StateRepository
        {
            get
            {
                if (_stateRepository == null)
                {
                    _stateRepository =
                       new StateRepository(DatabaseContext);
                }

                return _stateRepository;
            }
        }
        // *****

        // *****
        private IInstallerRepository _installerRepository;

        public IInstallerRepository InstallerRepository
        {
            get
            {
                if (_installerRepository == null)
                {
                    _installerRepository =
                        new InstallerRepository(DatabaseContext);
                }

                return _installerRepository;
            }
        }
        // *****

        // *****
        private ILegalPersonRepository _legalPersonRepository;

        public ILegalPersonRepository LegalPersonRepository
        {
            get
            {
                if (_legalPersonRepository == null)
                {
                    _legalPersonRepository =
                        new LegalPersonRepository(DatabaseContext);
                }

                return _legalPersonRepository;
            }
        }
        // *****

        // *****
        private INaturalPersonRepository _naturalPersonRepository;

        public INaturalPersonRepository NaturalPersonRepository
        {
            get
            {
                if (_naturalPersonRepository == null)
                {
                    _naturalPersonRepository =
                       new NaturalPersonRepository(DatabaseContext);
                }

                return _naturalPersonRepository;
            }
        }
        // *****

        // *****
        private IReplacementHeaterRepository _replacementHeaterRepository;

        public IReplacementHeaterRepository ReplacementHeaterRepository
        {
            get
            {
                if (_replacementHeaterRepository == null)
                {
                    _replacementHeaterRepository =
                       new ReplacementHeaterRepository(DatabaseContext);
                }

                return _replacementHeaterRepository;
            }
        }
        // *****

        // *****
        private IShokatHeaterRepository _shokatHeaterRepository;

        public IShokatHeaterRepository ShokatHeaterRepository
        {
            get
            {
                if (_shokatHeaterRepository == null)
                {
                    _shokatHeaterRepository =
                       new ShokatHeaterRepository(DatabaseContext);
                }

                return _shokatHeaterRepository;
            }
        }
        // *****
    }
}