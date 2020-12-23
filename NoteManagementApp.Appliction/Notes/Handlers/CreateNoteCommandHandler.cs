using AutoMapper;
using MediatR;
using NoteManagementApp.Appliction.Interfaces;
using System.Threading;
using System.Threading.Tasks;
using NoteManagementApp.Appliction.Notes.Commands;

namespace NoteManagementApp.Appliction.Notes.Handlers
{
    public class CreateNoteCommandHandler : IRequestHandler<CreateNoteCommand, int>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreateNoteCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<int> Handle(CreateNoteCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var result = await _unitOfWork.Notes.Add(_mapper.Map<NoteManagementApp.Core.Entities.Note>(request));
                return 1;
            }
            catch (System.Exception ex)
            {

                return 2;
            }
            
        }
    }
}