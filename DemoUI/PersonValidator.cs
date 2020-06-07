using DemoUILibrary;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoUI
{
    public class PersonValidator : AbstractValidator<PersonModel>
    {
        public PersonValidator()
        {
            RuleFor(p => p.FirstName)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("{PropertyName} is Empty")
                .Length(2, 50).WithMessage("Length ({TotalLength}) of {PropertyName} is Invalid")
                .Must(BeValidName).WithMessage("{PropertyName} contains Invalid Characters");

            RuleFor(p => p.LastName)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("{PropertyName} is Empty")
                .Length(2, 50).WithMessage("Length ({TotalLength}) of {PropertyName} is Invalid")
                .Must(BeValidName).WithMessage("{PropertyName} contains Invalid Characters");

            RuleFor(p => p.DateOfBirth)
                .Must(BeValidAge).WithMessage("Invalid {PropertyName}");
        }


        private bool BeValidName(string name)
        {
            name = name.Replace(" ", "");
            name = name.Replace("-", "");
            return name.All(Char.IsLetter);
        }


        private bool BeValidAge(DateTime dob)
        {
            int currentYear = DateTime.Now.Year;
            int dobYear = dob.Year;
            if (dobYear <= currentYear && dobYear > (currentYear - 125))
            {
                return true;
            }

            return false;
        }
    }
}
