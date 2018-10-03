using admin.domain.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace admin.service.Validator
{
    public class AddressValidator : AbstractValidator<Address>
    {
        public AddressValidator()
        {
            RuleFor(c => c)
                .NotNull()
                .OnAnyFailure(x =>
                {
                    throw new ArgumentNullException("Não foi possivel encontrar o objeto!");
                });

            RuleFor(c => c.Cep)
                .NotNull().WithMessage("É necessário informar o CEP da empresa!")
                .NotEmpty().WithMessage("É necessário informar o CEP da empresa!");

            RuleFor(c => c.Dwelling)
                .NotNull().WithMessage("É necessário informar o endereço da empresa!")
                .NotEmpty().WithMessage("É necessário informar o endereço da empresa!");

            RuleFor(c => c.City)
                .NotNull().WithMessage("É necessário informar a cidade da empresa!")
                .NotEmpty().WithMessage("É necessário informar a cidade da empresa!");

            RuleFor(c => c.IdState)
                .NotNull().WithMessage("É necessário informar o estado da empresa!")
                .NotEmpty().WithMessage("É necessário informar o estado da empresa!");

            RuleFor(c => c.IdCountry)
                .NotNull().WithMessage("É necessário informar o pais da empresa!")
                .NotEmpty().WithMessage("É necessário informar o pais da empresa!");

        }
    }
}
