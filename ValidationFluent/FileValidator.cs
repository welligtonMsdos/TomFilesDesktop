using FluentValidation;
using TomFilesDesktop.Dto;

namespace TomFilesDesktop.ValidationFluent;

public class FileValidator : AbstractValidator<FilesCreateUpdateDto>
{
    public FileValidator()
    {
        RuleFor(x => x.Name).NotEmpty().WithMessage("Name cannot be empty");

        RuleFor(c => c.Name).MinimumLength(3).WithMessage("Name is required at least 3 characters.");

        RuleFor(c => c.Name).MaximumLength(15).WithMessage("Name is no longer than 15 characters.");

        RuleFor(x => x.Path).NotEmpty().WithMessage("Path cannot be empty");

        RuleFor(c => c.Path).MinimumLength(3).WithMessage("Path is required at least 3 characters.");

        RuleFor(c => c.Path).MaximumLength(300).WithMessage("Path is no longer than 300 characters.");
    }
}
