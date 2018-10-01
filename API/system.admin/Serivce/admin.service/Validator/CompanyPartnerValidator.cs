using admin.domain.Entities;
using FluentValidation;
using System;

namespace admin.service.Validator
{
    public class CompanyPartnerValidator : AbstractValidator<CompanyPartner>
    {
        public CompanyPartnerValidator()
        {
            RuleFor(c => c)
               .NotNull()
               .OnAnyFailure(x =>
               {
                   throw new ArgumentNullException("Não foi possivel encontrar o objeto!");
               });

            RuleFor(c => c.CnpjCompanyPartner)
                .NotNull().WithMessage("É necessário informar o CNPJ da empresa!")
                .NotEmpty().WithMessage("É necessário informar o CNPJ da empresa!");

            RuleFor(c => c.StateRegistrationCompanyPartner)
                .NotNull().WithMessage("É necessário informar a inscrição estadual da empresa!")
                .NotEmpty().WithMessage("É necessário informar a inscrição estadual da empresa!");

            RuleFor(c => c.NameCompanyPartner)
                .NotNull().WithMessage("É necessário informar o nome da empresa!")
                .NotEmpty().WithMessage("É necessário informar o nome da empresa!");

            RuleFor(c => c.CepCompanyPartner)
                .NotNull().WithMessage("É necessário informar o CEP da empresa!")
                .NotEmpty().WithMessage("É necessário informar o CEP da empresa!");

            RuleFor(c => c.AderessCompanyPartner)
                .NotNull().WithMessage("É necessário informar o endereço da empresa!")
                .NotEmpty().WithMessage("É necessário informar o endereço da empresa!");

            RuleFor(c => c.CityCompanyPartner)
                .NotNull().WithMessage("É necessário informar a cidade da empresa!")
                .NotEmpty().WithMessage("É necessário informar a cidade da empresa!");

            RuleFor(c => c.StateCompanyPartner)
                .NotNull().WithMessage("É necessário informar o estado da empresa!")
                .NotEmpty().WithMessage("É necessário informar o estado da empresa!");

            RuleFor(c => c.CountryCompanyPartner)
                .NotNull().WithMessage("É necessário informar o pais da empresa!")
                .NotEmpty().WithMessage("É necessário informar o pais da empresa!");
        }
    }
}
