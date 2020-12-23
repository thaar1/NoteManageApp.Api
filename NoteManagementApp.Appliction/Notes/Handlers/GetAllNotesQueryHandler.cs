using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using NoteManagementApp.Appliction.Interfaces;
using NoteManagementApp.Appliction.Notes.Dto;
using NoteManagementApp.Api.Controllers;

namespace NoteManagementApp.Appliction.Notes.Handlers
{
    public class GetAllNotesQueryHandler : IRequestHandler<GetAllNotes,IEnumerable<NoteDto>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetAllNotesQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<IEnumerable<NoteDto>> Handle(GetAllNotes request, CancellationToken cancellationToken)
        {
            var list = new List<NoteDto>();
            var result = await _unitOfWork.Notes.GetAll();
            try
            {
                 list= _mapper.Map<List<NoteDto>>(result.ToList()); 
            }
            catch (System.Exception ex)
            {

            }
            return list;
        }
    }
}