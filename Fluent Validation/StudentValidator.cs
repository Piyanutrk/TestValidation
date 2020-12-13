using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fluent_Validation
{
    public class StudentValidator : AbstractValidator<Student>
    {
        public StudentValidator()
        {
            RuleFor(x => x.StudentId).NotEmpty();
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("Please enter a First Name.");
            RuleFor(x => x.Lastname).NotEmpty().WithMessage("Please enter a Last Name.");
            RuleFor(x => x.Address).Length(20, 255);
            RuleFor(x => x.Email).EmailAddress();
        }
    }
}
