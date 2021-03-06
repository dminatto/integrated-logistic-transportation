﻿using admin.domain.Entities;
using FluentValidation;
using System;

namespace admin.service.Validator
{
    public class CountryValidator : AbstractValidator<Country>
    {
        public CountryValidator()
        {
            RuleFor(c => c)
                .NotNull()
                .OnAnyFailure(x =>
                {
                    throw new ArgumentNullException("Não foi possivel encontrar o objeto!");
                });

            RuleFor(c => c.NameCountry)
                .NotEmpty().WithMessage("É necessário informar o nome do pais!")
                .NotNull().WithMessage("É necessário informar o nome do pais!");
        }
    }
}
