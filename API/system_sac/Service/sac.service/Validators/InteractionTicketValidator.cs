using FluentValidation;
using sac.domain.Entities;
using System;

namespace sac.service.Validators
{
    public class InteractionTicketValidator : AbstractValidator<InteractionTicket>
    {
        public InteractionTicketValidator()
        {
            RuleFor(c => c)
               .NotNull()
               .OnAnyFailure(x =>
               {
                   throw new ArgumentNullException("Não foi possivel encontrar o objeto!");
               });

            RuleFor(c => c.IdUsuario)
                .NotNull().WithMessage("É necessário informar um usuário na interação do ticket!")
                .NotEmpty().WithMessage("É necessário informar um usuário descrição na interação do ticket!");

            RuleFor(c => c.NoteTicket)
                .NotNull().WithMessage("É necessário informar uma descrição na interação do ticket!")
                .NotEmpty().WithMessage("É necessário informar uma descrição na interação do ticket!");
        }
    }
}
