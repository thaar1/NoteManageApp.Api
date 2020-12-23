namespace NoteManagementApp.Appliction.Interfaces
{
    public interface IUnitOfWork
    {
        INoteRepository Notes { get; } 

    }
}
