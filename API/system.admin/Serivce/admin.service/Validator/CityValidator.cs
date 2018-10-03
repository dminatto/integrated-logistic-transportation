using admin.domain.Entities;
using FluentValidation;
using System;

namespace admin.service.Validator
{
    public class CityValidator : AbstractValidator<City>
    {
        public CityValidator()
        {
            RuleFor(c => c)
                .NotNull()
                .OnAnyFailure(x =>
                {
                    throw new ArgumentNullException("Não foi possivel encontrar o objeto!");
                });

            RuleFor(c => c.NameCity)
                .NotNull().WithMessage("É necessário informar o nome da cidade!")
                .NotEmpty().WithMessage("É necessário informar o nome da cidade!");
        }
    }
}
