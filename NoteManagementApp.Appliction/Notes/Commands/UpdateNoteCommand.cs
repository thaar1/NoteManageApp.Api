using MediatR;
using NoteManagementApp.Core.Enums;
using System;

namespace NoteManagementApp.Appliction.Notes.Commands
{
    public class UpdateNoteCommand : IRequest<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public NoteStatus Status { get; set; }
        public DateTime DueDate { get; set; }
    }
}