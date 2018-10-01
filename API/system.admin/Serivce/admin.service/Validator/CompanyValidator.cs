using admin.domain.Entities;
using FluentValidation;
using System;

namespace admin.service.Validator
{
    public class CompanyValidator : AbstractValidator<Company>
    {
        public CompanyValidator()
        {
            RuleFor(c => c)
               .NotNull()
               .OnAnyFailure(x =>
               {
                   throw new ArgumentNullException("Não foi possivel encontrar o objeto!");
               });

            RuleFor(c => c.CnpjCompany)
                .NotNull().WithMessage("É necessário informar o CNPJ da empresa!")
                .NotEmpty().WithMessage("É necessário informar o CNPJ da empresa!");

            RuleFor(c => c.StateRegistrationCompany)
                .NotNull().WithMessage("É necessário informar a inscrição estadual da empresa!")
                .NotEmpty().WithMessage("É necessário informar a inscrição estadual da empresa!");

            RuleFor(c => c.NameCompany)
                .NotNull().WithMessage("É necessário informar o nome da empresa!")
                .NotEmpty().WithMessage("É necessário informar o nome da empresa!");

            RuleFor(c => c.NameFantasy)
                .NotNull().WithMessage("É necessário informar o nome fantasia da empresa")
                .NotEmpty().WithMessage("É necessário informar o nome fantasia da empresa");

            RuleFor(c => c.CepCompany)
                .NotNull().WithMessage("É necessário informar o CEP da empresa!")
                .NotEmpty().WithMessage("É necessário informar o CEP da empresa!");

            RuleFor(c => c.AderessCompany)
                .NotNull().WithMessage("É necessário informar o endereço da empresa!")
                .NotEmpty().WithMessage("É necessário informar o endereço da empresa!");

            RuleFor(c => c.CityCompany)
                .NotNull().WithMessage("É necessário informar a cidade da empresa!")
                .NotEmpty().WithMessage("É necessário informar a cidade da empresa!");

            RuleFor(c => c.StateCompany)
                .NotNull().WithMessage("É necessário informar o estado da empresa!")
                .NotEmpty().WithMessage("É necessário informar o estado da empresa!");

            RuleFor(c => c.CountryCompany)
                .NotNull().WithMessage("É necessário informar o pais da empresa!")
                .NotEmpty().WithMessage("É necessário informar o pais da empresa!");
        }
    }
}
