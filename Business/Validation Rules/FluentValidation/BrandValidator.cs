using Entites.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Validation_Rules.FluentValidation
{
    public class BrandValidator:AbstractValidator<Brand>
    {
        public BrandValidator()
        {
            RuleFor(p => p.BrandName).NotEmpty();
            RuleFor(p => p.BrandName).MinimumLength(2);
            RuleFor(p => p.BrandName).Must(StartWithA).WithMessage("Ürünler A Harfi ile başlamak zorunda.");

        }
        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
