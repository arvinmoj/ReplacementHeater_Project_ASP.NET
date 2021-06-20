using System;
using FluentValidation;
using ViewModels.LegalPerson;

namespace Validator
{
    public class LegalPersonValidation : AbstractValidator<LegalPersonViewModel>
    {
        [Obsolete]
        public LegalPersonValidation()
        {
            
            // *****
            RuleFor(c => c.InstallerUserName)
                .NotNull().WithMessage(errorMessage: nameof(Resources.ErrorMessages.Required))
                .NotEmpty();
            // *****

            // *****
            RuleFor(c => c.CompanyName)
                .NotNull().WithMessage(errorMessage: nameof(Resources.ErrorMessages.Required))
                .NotEmpty()
                .MinimumLength(3).WithMessage(errorMessage: nameof(Resources.ErrorMessages.MinLength))
                .MaximumLength(20).WithMessage(errorMessage: nameof(Resources.ErrorMessages.MaxLength));
            // *****

            // *****
            RuleFor(c => c.NameCEO)
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
                .MaximumLength(60).WithMessage(errorMessage: nameof(Resources.ErrorMessages.MaxLength))
                .EmailAddress().WithMessage(errorMessage: nameof(Resources.ErrorMessages.InvalidEmailAddress));
            // *****

            // *****
            RuleFor(c => c.PhoneNumber)
                .NotNull().WithMessage(errorMessage: nameof(Resources.ErrorMessages.Required))
                .NotEmpty()
                .MinimumLength(11).WithMessage(errorMessage: nameof(Resources.ErrorMessages.MinLength))
                .MaximumLength(11).WithMessage(errorMessage: nameof(Resources.ErrorMessages.MaxLength));
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
            RuleFor(c => c.Address)
                .NotNull().WithMessage(errorMessage: nameof(Resources.ErrorMessages.Required))
                .NotEmpty()
                .MinimumLength(10).WithMessage(errorMessage: nameof(Resources.ErrorMessages.MinLength))
                .MaximumLength(100).WithMessage(errorMessage: nameof(Resources.ErrorMessages.MaxLength));
            // *****

            // *****
            RuleFor(c => c.PostalCode)
                .NotNull().WithMessage(errorMessage: nameof(Resources.ErrorMessages.Required))
                .NotEmpty();
            // *****

            // *****
            RuleFor(c => c.RegistrationNumber)
                .NotNull().WithMessage(errorMessage: nameof(Resources.ErrorMessages.Required))
                .NotEmpty();
            // *****

            // *****
            RuleFor(c => c.EconomicCode)
                .NotNull().WithMessage(errorMessage: nameof(Resources.ErrorMessages.Required))
                .NotEmpty();
            // *****

            // *****
            RuleFor(c => c.RecipientName)
                .NotNull().WithMessage(errorMessage: nameof(Resources.ErrorMessages.Required))
                .NotEmpty()
                .MinimumLength(3).WithMessage(errorMessage: nameof(Resources.ErrorMessages.MinLength))
                .MaximumLength(20).WithMessage(errorMessage: nameof(Resources.ErrorMessages.MaxLength));
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
                .NotEmpty();
            // *****

            // *****
            RuleFor(c => c.GasometerNumber)
                .NotNull().WithMessage(errorMessage: nameof(Resources.ErrorMessages.Required))
                .NotEmpty()
                .MinimumLength(5).WithMessage(errorMessage: nameof(Resources.ErrorMessages.MinLength))
                .MaximumLength(20).WithMessage(errorMessage: nameof(Resources.ErrorMessages.MaxLength));
            // *****

            // *****
            RuleFor(c => c.PersonNumber)
                .NotNull().WithMessage(errorMessage: nameof(Resources.ErrorMessages.Required))
                .NotEmpty()
                .MinimumLength(5).WithMessage(errorMessage: nameof(Resources.ErrorMessages.MinLength))
                .MaximumLength(20).WithMessage(errorMessage: nameof(Resources.ErrorMessages.MaxLength));
            // *****

        }
    }
}
