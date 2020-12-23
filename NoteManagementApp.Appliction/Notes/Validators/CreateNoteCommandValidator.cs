using FluentValidation;
using NoteManagementApp.Appliction.Notes.Commands;

namespace NoteManagementApp.Appliction.Notes.Validators
{
    public class CreateNoteCommandValidator : AbstractValidator<CreateNoteCommand>
    {
        public CreateNoteCommandValidator()
        {
            RuleFor(t => t.Name).NotEmpty();
            RuleFor(t => t.Description).NotEmpty();
            RuleFor(t => t.Status).NotNull();
            RuleFor(t => t.DueDate).NotNull();
        }
    }
}