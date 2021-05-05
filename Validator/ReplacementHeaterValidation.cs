using System;
using Models;
using FluentValidation;

namespace Validator
{
    public class ReplacementHeaterValidation : AbstractValidator<ReplacementHeater>
    {
        [Obsolete]
        public ReplacementHeaterValidation()
        {
            // *****
            RuleFor(c => c.HeaterInstalledType)
                .NotNull().WithMessage(errorMessage: nameof(Resources.ErrorMessages.Required))
                .NotEmpty()
                .MinimumLength(3).WithMessage(errorMessage: nameof(Resources.ErrorMessages.MinLength))
                .MaximumLength(20).WithMessage(errorMessage: nameof(Resources.ErrorMessages.MaxLength));
            // *****

            // *****
            RuleFor(c => c.NameCEO)
                .NotNull().WithMessage(errorMessage: nameof(Resources.ErrorMessages.Required))
                .NotEmpty();
            // *****

            // *****
            RuleFor(c => c.FullName)
                .NotNull().WithMessage(errorMessage: nameof(Resources.ErrorMessages.Required))
                .NotEmpty();
            // *****

            // *****
            RuleFor(c => c.HeaterScrapType)
                .NotNull().WithMessage(errorMessage: nameof(Resources.ErrorMessages.Required))
                .NotEmpty()
                .MinimumLength(3).WithMessage(errorMessage: nameof(Resources.ErrorMessages.MinLength))
                .MaximumLength(20).WithMessage(errorMessage: nameof(Resources.ErrorMessages.MaxLength));
            // *****

            // *****
            RuleFor(c => c.Model)
                .NotNull().WithMessage(errorMessage: nameof(Resources.ErrorMessages.Required))
                .NotEmpty()
                .MinimumLength(3).WithMessage(errorMessage: nameof(Resources.ErrorMessages.MinLength))
                .MaximumLength(20).WithMessage(errorMessage: nameof(Resources.ErrorMessages.MaxLength));
            // *****

            // *****
            RuleFor(c => c.Capacity)
                .NotNull().WithMessage(errorMessage: nameof(Resources.ErrorMessages.Required))
                .NotEmpty();
            // *****

            // *****
            RuleFor(c => c.HeaterScrapSerialNumber)
                .NotNull().WithMessage(errorMessage: nameof(Resources.ErrorMessages.Required))
                .NotEmpty();
            // *****

            // *****
            RuleFor(c => c.HeaterInstalledSerialNumber)
                .NotNull().WithMessage(errorMessage: nameof(Resources.ErrorMessages.Required))
                .NotEmpty();
            // *****

            // *****
            RuleFor(c => c.InstallationDate)
                .NotNull().WithMessage(errorMessage: nameof(Resources.ErrorMessages.Required))
                .NotEmpty()
                .MinimumLength(3).WithMessage(errorMessage: nameof(Resources.ErrorMessages.MinLength))
                .MaximumLength(20).WithMessage(errorMessage: nameof(Resources.ErrorMessages.MaxLength));
            // *****

            // *****
            RuleFor(c => c.InstallationTime)
                .NotNull().WithMessage(errorMessage: nameof(Resources.ErrorMessages.Required))
                .NotEmpty()
                .MinimumLength(3).WithMessage(errorMessage: nameof(Resources.ErrorMessages.MinLength))
                .MaximumLength(20).WithMessage(errorMessage: nameof(Resources.ErrorMessages.MaxLength));
            // *****

        }
    }
}
