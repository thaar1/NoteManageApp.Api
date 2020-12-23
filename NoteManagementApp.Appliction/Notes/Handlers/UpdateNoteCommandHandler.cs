using AutoMapper;
using MediatR;
using NoteManagementApp.Appliction.Interfaces;
using System.Threading;
using System.Threading.Tasks;
using NoteManagementApp.Appliction.Notes.Commands;

namespace NoteManagementApp.Appliction.Notes.Handlers 
{
    public class UpdateNoteCommandHandler : IRequestHandler<UpdateNoteCommand, int>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UpdateNoteCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<int> Handle(UpdateNoteCommand request, CancellationToken cancellationToken)
        {
            var result = await _unitOfWork.Notes.Update(_mapper.Map<NoteManagementApp.Core.Entities.Note>(request));
            return result;
        }
    }
}