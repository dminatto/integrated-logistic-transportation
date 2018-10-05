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

            RuleFor(c => c.NameCompany)
                .NotNull().WithMessage("É necessário informar o nome da empresa!")
                .NotEmpty().WithMessage("É necessário informar o nome da empresa!");

            RuleFor(c => c.NameFantasy)
                .NotNull().WithMessage("É necessário informar o nome fantasia da empresa")
                .NotEmpty().WithMessage("É necessário informar o nome fantasia da empresa");    
        }
    }
}
