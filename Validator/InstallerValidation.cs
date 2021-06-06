using System;
using Models;
using FluentValidation;

namespace Validator
{
    public class InstallerValidation : AbstractValidator<Installer>
    {
        [Obsolete]
        public InstallerValidation()
        {
            // *****
            RuleFor(c => c.FullName)
                .NotNull().WithMessage(errorMessage: nameof(Resources.ErrorMessages.Required))
                .MinimumLength(3).WithMessage(errorMessage: nameof(Resources.ErrorMessages.MinLength))
                .MaximumLength(20).WithMessage(errorMessage: nameof(Resources.ErrorMessages.MaxLength));
            // *****

            // *****
            RuleFor(c => c.InstallerUserName)
                .NotNull().WithMessage(errorMessage: nameof(Resources.ErrorMessages.Required))
                .MinimumLength(3).WithMessage(errorMessage: nameof(Resources.ErrorMessages.MinLength))
                .MaximumLength(20).WithMessage(errorMessage: nameof(Resources.ErrorMessages.MaxLength));
            // *****

            // *****
            RuleFor(c => c.UserNumber)
                .NotNull().WithMessage(errorMessage: nameof(Resources.ErrorMessages.Required))
                .MinimumLength(3).WithMessage(errorMessage: nameof(Resources.ErrorMessages.MinLength))
                .MaximumLength(20).WithMessage(errorMessage: nameof(Resources.ErrorMessages.MaxLength));
            // *****

            // *****
            RuleFor(c => c.NationalCode)
                .NotNull().WithMessage(errorMessage: nameof(Resources.ErrorMessages.Required))
                .MinimumLength(10).WithMessage(errorMessage: nameof(Resources.ErrorMessages.MinLength))
                .MaximumLength(10).WithMessage(errorMessage: nameof(Resources.ErrorMessages.MaxLength));
            // *****

            // *****
            RuleFor(c => c.PhoneNumber)
                .NotNull().WithMessage(errorMessage: nameof(Resources.ErrorMessages.Required))
                .MinimumLength(11).WithMessage(errorMessage: nameof(Resources.ErrorMessages.MinLength))
                .MaximumLength(11).WithMessage(errorMessage: nameof(Resources.ErrorMessages.MaxLength));
            // *****

            // *****
            RuleFor(c => c.MobileNumber)
                .NotNull().WithMessage(errorMessage: nameof(Resources.ErrorMessages.Required))
                .MinimumLength(11).WithMessage(errorMessage: nameof(Resources.ErrorMessages.MinLength))
                .MaximumLength(11).WithMessage(errorMessage: nameof(Resources.ErrorMessages.MaxLength));
            // *****

            // *****
            RuleFor(c => c.Address)
                .NotNull().WithMessage(errorMessage: nameof(Resources.ErrorMessages.Required))
                .MinimumLength(3).WithMessage(errorMessage: nameof(Resources.ErrorMessages.MinLength))
                .MaximumLength(100).WithMessage(errorMessage: nameof(Resources.ErrorMessages.MaxLength));
            // *****

        }
    }
}
