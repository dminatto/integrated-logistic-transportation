using FluentValidation;
using sac.domain.Entities;
using System;

namespace sac.service.Validators
{
    public class HelpDeskValidator : AbstractValidator<HelpDesk>
    {
        public HelpDeskValidator()
        {
            RuleFor(c => c)
               .NotNull()
               .OnAnyFailure(x =>
               {
                   throw new ArgumentNullException("Não foi possivel encontrar o objeto!");
               });

            RuleFor(c => c.IdUsuario)
                .NotNull().WithMessage("É necessário informar o usuário!")
                .NotEmpty().WithMessage("É necessário informar o usuário!");
        }
    }
}
