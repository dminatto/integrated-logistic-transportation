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

            RuleFor(c => c.NameCompanyPartner)
                .NotNull().WithMessage("É necessário informar o nome da empresa!")
                .NotEmpty().WithMessage("É necessário informar o nome da empresa!");
        }
    }
}
