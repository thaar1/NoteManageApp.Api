using FluentValidation;
using NoteManagementApp.Appliction.Notes.Commands;

namespace NoteManagementApp.Appliction.Notes.Validators
{
    public class UpdateNoteCommandValidator : AbstractValidator<UpdateNoteCommand>
    {
        public UpdateNoteCommandValidator()
        {
            RuleFor(t => t.Name).NotEmpty();
            RuleFor(t => t.Description).NotEmpty();
            RuleFor(t => t.Status).NotNull();
            RuleFor(t => t.DueDate).NotNull();
        }
    }
}