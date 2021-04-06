namespace Data
{
    public interface IUnitOfWork : Base.IUnitOfWork
    {
        // *****
        ICityRepository CityRepository { get; }
        // *****

        // *****
        IStateRepository StateRepository { get; }
        // *****

        // *****
        IInstallerRepository InstallerRepository { get; }
        // *****

        // *****
        ILegalPersonRepository LegalPersonRepository { get; }
        // *****

        // *****
        IShokatHeaterRepository ShokatHeaterRepository { get; }
        // *****

        // *****
        INaturalPersonRepository NaturalPersonRepository { get; }
        // *****

        // *****
        IReplacementHeaterRepository ReplacementHeaterRepository { get; }
        // *****
    }
}