using MediatR;
using NoteManagementApp.Appliction.Notes.Dto;

namespace NoteManagementApp.Appliction.Notes.Queries
{
    public class GetNoteByIdQuery : IRequest<NoteDto> 
    {
        public int Id { get; set; }
    }
}