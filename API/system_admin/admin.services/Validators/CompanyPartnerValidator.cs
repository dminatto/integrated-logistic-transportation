using admin.domain.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace admin.services.Validators
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

            RuleFor(c => c.cnpjCompanyPartner)
                .NotNull().WithMessage("É necessário informar o CNPJ da empresa!")
                .NotEmpty().WithMessage("É necessário informar o CNPJ da empresa!");

            RuleFor(c => c.stateRegistrationCompanyPartner)
                .NotNull().WithMessage("É necessário informar a inscrição estadual da empresa!")
                .NotEmpty().WithMessage("É necessário informar a inscrição estadual da empresa!");

            RuleFor(c => c.nameCompanyPartner)
                .NotNull().WithMessage("É necessário informar o nome da empresa!")
                .NotEmpty().WithMessage("É necessário informar o nome da empresa!");
            
            RuleFor(c => c.cepCompanyPartner)
                .NotNull().WithMessage("É necessário informar o CEP da empresa!")
                .NotEmpty().WithMessage("É necessário informar o CEP da empresa!");

            RuleFor(c => c.aderessCompanyPartner)
                .NotNull().WithMessage("É necessário informar o endereço da empresa!")
                .NotEmpty().WithMessage("É necessário informar o endereço da empresa!");

            RuleFor(c => c.cityCompanyPartner)
                .NotNull().WithMessage("É necessário informar a cidade da empresa!")
                .NotEmpty().WithMessage("É necessário informar a cidade da empresa!");

            RuleFor(c => c.stateCompanyPartner.Id)
                .NotNull().WithMessage("É necessário informar o estado da empresa!")
                .NotEmpty().WithMessage("É necessário informar o estado da empresa!");

            RuleFor(c => c.countryCompanyPartner.Id)
                .NotNull().WithMessage("É necessário informar o pais da empresa!")
                .NotEmpty().WithMessage("É necessário informar o pais da empresa!");
        }
    }
}
