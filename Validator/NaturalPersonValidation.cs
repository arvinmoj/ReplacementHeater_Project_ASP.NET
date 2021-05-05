using Models;
using System;
using FluentValidation;

namespace Validator
{
    public class NaturalPersonValidation : AbstractValidator<NaturalPerson>
    {
        [Obsolete]
        public NaturalPersonValidation()
        {
            // *****
            RuleFor(c => c.InstallerUserName)
                .NotNull().WithMessage(errorMessage: nameof(Resources.ErrorMessages.Required))
                .NotEmpty();
            // *****

            // *****
            RuleFor(c => c.FullName)
                .NotNull().WithMessage(errorMessage: nameof(Resources.ErrorMessages.Required))
                .NotEmpty()
                .MinimumLength(3).WithMessage(errorMessage: nameof(Resources.ErrorMessages.MinLength))
                .MaximumLength(20).WithMessage(errorMessage: nameof(Resources.ErrorMessages.MaxLength));
            // *****

            // *****
            RuleFor(c => c.NationalCode)
                .NotNull().WithMessage(errorMessage: nameof(Resources.ErrorMessages.Required))
                .NotEmpty()
                .MinimumLength(3).WithMessage(errorMessage: nameof(Resources.ErrorMessages.MinLength))
                .MaximumLength(20).WithMessage(errorMessage: nameof(Resources.ErrorMessages.MaxLength));
            // *****

            // *****
            RuleFor(c => c.EmailAddress)
                .NotNull().WithMessage(errorMessage: nameof(Resources.ErrorMessages.Required))
                .NotEmpty()
                .MinimumLength(3).WithMessage(errorMessage: nameof(Resources.ErrorMessages.MinLength))
                .MaximumLength(60).WithMessage(errorMessage: nameof(Resources.ErrorMessages.MaxLength));
            // *****

            // *****
            RuleFor(c => c.PhoneNumber)
                .NotNull().WithMessage(errorMessage: nameof(Resources.ErrorMessages.Required))
                .NotEmpty()
                .MinimumLength(3).WithMessage(errorMessage: nameof(Resources.ErrorMessages.MinLength))
                .MaximumLength(20).WithMessage(errorMessage: nameof(Resources.ErrorMessages.MaxLength));
            // *****

            // *****
            RuleFor(c => c.MobileNumber)
                .NotNull().WithMessage(errorMessage: nameof(Resources.ErrorMessages.Required))
                .NotEmpty()
                .MinimumLength(3).WithMessage(errorMessage: nameof(Resources.ErrorMessages.MinLength))
                .MaximumLength(20).WithMessage(errorMessage: nameof(Resources.ErrorMessages.MaxLength));
            // *****

            // *****
            RuleFor(c => c.City)
                .NotNull().WithMessage(errorMessage: nameof(Resources.ErrorMessages.Required))
                .NotEmpty();
            // *****

            // *****
            RuleFor(c => c.State)
                .NotNull().WithMessage(errorMessage: nameof(Resources.ErrorMessages.Required))
                .NotEmpty();
            // *****

            // *****
            RuleFor(c => c.Region)
                .NotNull().WithMessage(errorMessage: nameof(Resources.ErrorMessages.Required))
                .NotEmpty()
                .MinimumLength(1).WithMessage(errorMessage: nameof(Resources.ErrorMessages.MinLength))
                .MaximumLength(20).WithMessage(errorMessage: nameof(Resources.ErrorMessages.MaxLength));
            // *****

            // *****
            RuleFor(c => c.Address)
                .NotNull().WithMessage(errorMessage: nameof(Resources.ErrorMessages.Required))
                .NotEmpty()
                .MinimumLength(3).WithMessage(errorMessage: nameof(Resources.ErrorMessages.MinLength))
                .MaximumLength(100).WithMessage(errorMessage: nameof(Resources.ErrorMessages.MaxLength));
            // *****

            // *****
            RuleFor(c => c.InstallationLocation)
                .NotNull().WithMessage(errorMessage: nameof(Resources.ErrorMessages.Required))
                .NotEmpty()
                .MinimumLength(3).WithMessage(errorMessage: nameof(Resources.ErrorMessages.MinLength))
                .MaximumLength(100).WithMessage(errorMessage: nameof(Resources.ErrorMessages.MaxLength));
            // *****

            // *****
            RuleFor(c => c.GasometerType)
                .NotNull().WithMessage(errorMessage: nameof(Resources.ErrorMessages.Required))
                .NotEmpty()
                .MinimumLength(3).WithMessage(errorMessage: nameof(Resources.ErrorMessages.MinLength))
                .MaximumLength(20).WithMessage(errorMessage: nameof(Resources.ErrorMessages.MaxLength));
            // *****

            // *****
            RuleFor(c => c.GasometerNumber)
                .NotNull().WithMessage(errorMessage: nameof(Resources.ErrorMessages.Required))
                .NotEmpty();
            // *****

            // *****
            RuleFor(c => c.PersonNumber)
                .NotNull().WithMessage(errorMessage: nameof(Resources.ErrorMessages.Required))
                .NotEmpty();
            // *****
        }
    }
}
