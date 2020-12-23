using AutoMapper;
using NoteManagementApp.Appliction.Notes.Commands;
using NoteManagementApp.Appliction.Notes.Dto;
using NoteManagementApp.Core.Entities;

namespace NoteManagementApp.Appliction.Notes.MappingProfiles
{
    public class NoteMappingProfile : Profile
    {
        public NoteMappingProfile()
        {
            CreateMap<CreateNoteCommand, Note>();
            CreateMap<UpdateNoteCommand, Note>();
            CreateMap<Note, NoteDto>();
        }
    }
}