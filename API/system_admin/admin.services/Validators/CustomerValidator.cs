using admin.domain.Entities;
using FluentValidation;
using System;

namespace admin.services.Validators
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(c => c)
               .NotNull()
               .OnAnyFailure(x =>
               {
                   throw new ArgumentNullException("Não foi possivel encontrar o objeto!");
               });

            RuleFor(c => c.nameCustomer)
                .NotNull().WithMessage("É necessário informar o nome do cliente!")
                .NotEmpty().WithMessage("É necessário informar o nome do cliente!");

            RuleFor(c => c.cpfCustomer)
                .NotNull().WithMessage("É necessário informar o CPF do cliente!")
                .NotEmpty().WithMessage("É necessário informar o CPF do cliente!");

            RuleFor(c => c.emailCustomer)
                .NotEmpty().WithMessage("É necessário informar o email do cliente!")
                .NotNull().WithMessage("É necessário informar o email do cliente!");

            RuleFor(c => c.cepCustomer)
                .NotNull().WithMessage("É necessário informar o CEP do cliente!")
                .NotEmpty().WithMessage("É necessário informar o CEP do cliente!");

            RuleFor(c => c.aderessCustomer)
                .NotNull().WithMessage("É necessário informar o endereço do cliente!")
                .NotEmpty().WithMessage("É necessário informar o endereço do cliente!");

            RuleFor(c => c.cityCustomer)
                .NotNull().WithMessage("É necessário informar a cidade do cliente!")
                .NotEmpty().WithMessage("É necessário informar a cidade do cliente!");

            RuleFor(c => c.stateCustomer)
                .NotNull().WithMessage("É necessário informar o estado do cliente!")
                .NotEmpty().WithMessage("É necessário informar o estado do cliente!");

            RuleFor(c => c.districtCustomer)
                .NotNull().WithMessage("É necessário informar o bairro do cliente!")
                .NotEmpty().WithMessage("É necessário informar o bairro do cliente!");

            RuleFor(c => c.phoneCustomer)
                .NotNull().WithMessage("É necessário informar o telefone do cliente!")
                .NotEmpty().WithMessage("É necessário informar o telefone do cliente!");
        }
    }
}
