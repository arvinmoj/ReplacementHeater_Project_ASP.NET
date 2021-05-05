﻿using System;
using FluentValidation;
using Models;

namespace Validator
{
    public class LegalPersonValidation : AbstractValidator<LegalPerson>
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
                .MaximumLength(60).WithMessage(errorMessage: nameof(Resources.ErrorMessages.MaxLength));
            // *****

            // *****
            RuleFor(c => c.PhoneNumber)
                .NotNull().WithMessage(errorMessage: nameof(Resources.ErrorMessages.Required))
                .NotEmpty();
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
            RuleFor(c => c.NationalCode)
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
