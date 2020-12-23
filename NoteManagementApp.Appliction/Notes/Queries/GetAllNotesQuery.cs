using MediatR;
using System.Collections.Generic;
using NoteManagementApp.Appliction.Notes.Dto;

namespace NoteManagementApp.Api.Controllers 
{
    public class GetAllNotes : IRequest<IEnumerable<NoteDto>>
    {
        public int MyProperty { get; set; }
    }
}