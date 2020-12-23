using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NoteManagementApp.Appliction.Interfaces;
using NoteManagementApp.Appliction.Notes.Dto;
using NoteManagementApp.Appliction.Notes.Queries;

namespace NoteManagementApp.Appliction.Notes.Handlers 
{
    public class GetNoteByIdQueryHandler : IRequestHandler<GetNoteByIdQuery, NoteDto>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetNoteByIdQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<NoteDto> Handle(GetNoteByIdQuery request, CancellationToken cancellationToken)
        {
            var result = await _unitOfWork.Notes.Get(request.Id);
            return _mapper.Map<NoteDto>(result);
        }
    }
}