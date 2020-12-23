using System;
using NoteManagementApp.Core.Enums;

namespace NoteManagementApp.Appliction.Notes.Dto
{
    public class NoteDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public NoteStatus Status { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
    }
}