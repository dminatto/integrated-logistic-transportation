using admin.domain.Entities;
using FluentValidation;
using System;

namespace admin.services.Validators
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

            RuleFor(c => c.cnpjCompany)
                .NotNull().WithMessage("É necessário informar o CNPJ da empresa!")
                .NotEmpty().WithMessage("É necessário informar o CNPJ da empresa!");

            RuleFor(c => c.stateRegistrationCompany)
                .NotNull().WithMessage("É necessário informar a inscrição estadual da empresa!")
                .NotEmpty().WithMessage("É necessário informar a inscrição estadual da empresa!");
            
            RuleFor(c => c.nameCompany)
                .NotNull().WithMessage("É necessário informar o nome da empresa!")
                .NotEmpty().WithMessage("É necessário informar o nome da empresa!");

            RuleFor(c => c.nameFantasy)
                .NotNull().WithMessage("É necessário informar o nome fantasia da empresa")
                .NotEmpty().WithMessage("É necessário informar o nome fantasia da empresa");

            RuleFor(c => c.cepCompany)
                .NotNull().WithMessage("É necessário informar o CEP da empresa!")
                .NotEmpty().WithMessage("É necessário informar o CEP da empresa!");

            RuleFor(c => c.aderessCompany)
                .NotNull().WithMessage("É necessário informar o endereço da empresa!")
                .NotEmpty().WithMessage("É necessário informar o endereço da empresa!");

            RuleFor(c => c.cityCompany)
                .NotNull().WithMessage("É necessário informar a cidade da empresa!")
                .NotEmpty().WithMessage("É necessário informar a cidade da empresa!");

            RuleFor(c => c.stateCompany)
                .NotNull().WithMessage("É necessário informar o estado da empresa!")
                .NotEmpty().WithMessage("É necessário informar o estado da empresa!");

            RuleFor(c => c.countryCompany)
                .NotNull().WithMessage("É necessário informar o pais da empresa!")
                .NotEmpty().WithMessage("É necessário informar o pais da empresa!");
        }
    }
}
