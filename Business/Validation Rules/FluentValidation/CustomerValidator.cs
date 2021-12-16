﻿using Entites.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Validation_Rules.FluentValidation
{
    public class CustomerValidator:AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(c => c.CompanyName).NotEmpty();
            RuleFor(c => c.UserId).NotEmpty();
            RuleFor(c => c.CompanyName).MinimumLength(2);
        }
    }
}
