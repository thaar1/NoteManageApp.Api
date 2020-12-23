using MediatR;

namespace NoteManagementApp.Appliction.Notes.Commands
{
    public class DeleteNoteCommand : IRequest<int>
    {
        public int Id { get; set; }
    }
}