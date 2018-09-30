using FluentValidation;
using sac.domain.Entities;
using System;

namespace sac.service.Validators
{
    public class TicketValidator : AbstractValidator<Tikcet>
    {
        public TicketValidator()
        {
            RuleFor(c => c)
               .NotNull()
               .OnAnyFailure(x =>
               {
                   throw new ArgumentNullException("Não foi possivel encontrar o objeto!");
               });

            RuleFor(c => c.NameCustomer)
                .NotNull().WithMessage("É necessário informar o nome do cliente!")
                .NotEmpty().WithMessage("É necessário informar o nome do cliente!");

            RuleFor(c => c.PhoneCustomer)
                .NotNull().WithMessage("É necessário informar o telefone do cliente!")
                .NotEmpty().WithMessage("É necessário informar o telefone do cliente!");

            RuleFor(c => c.EmailCustomer)
                .NotNull().WithMessage("É necessário informar o email do cliente!")
                .NotEmpty().WithMessage("É necessário informar o email do cliente!");

            RuleFor(c => c.StatusTicket)
                .NotNull().WithMessage("É necessário informar o status do ticket!")
                .NotEmpty().WithMessage("É necessário informar o status do ticket!");

            RuleFor(c => c.CategoryTiket)
                .NotNull().WithMessage("É necessário informar a categoria do ticket!")
                .NotEmpty().WithMessage("É necessário informar a categoria do ticket!");

            RuleFor(c => c.Interactions)
                .NotNull().WithMessage("É necessário informar uma descrição na interação do ticket!")
                .NotEmpty().WithMessage("É necessário informar uma descrição na interação do ticket!");  
        }
    }
}
