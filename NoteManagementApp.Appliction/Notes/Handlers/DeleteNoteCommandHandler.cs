using MediatR;
using System.Threading;
using System.Threading.Tasks;
using NoteManagementApp.Appliction.Interfaces;
using NoteManagementApp.Appliction.Notes.Commands;

namespace NoteManagementApp.Appliction.Notes.Handlers
{
    public class DeleteNoteCommandHandler : IRequestHandler<DeleteNoteCommand, int>
    {
        private readonly IUnitOfWork _unitOfWork;

        public DeleteNoteCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<int> Handle(DeleteNoteCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var result = await _unitOfWork.Notes.Delete(request.Id);
                return result;
            }
            catch (System.Exception ex)
            {

                return 2;
            }
            
        }
    }
}