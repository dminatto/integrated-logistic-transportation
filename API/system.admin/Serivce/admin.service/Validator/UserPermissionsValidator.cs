using System;
using admin.domain.Entities;
using FluentValidation;

namespace admin.service.Validator
{
    public class UserPermissionsValidator : AbstractValidator<UserPermissions>
    {
        public UserPermissionsValidator()
        {
            RuleFor(c => c)
                .NotNull()
                .OnAnyFailure(x =>
                {
                    throw new ArgumentNullException("Não foi possivel encontrar o objeto!");
                });

            RuleFor(c => c.IdModule)
                .NotNull().WithMessage("É necessário informar o modulo!")
                .NotEmpty().WithMessage("É necessário informar o modulo!");

            RuleFor(c => c.Permission)
                .NotNull().WithMessage("É necessário informar o nivel de permissão!")
                .NotEmpty().WithMessage("É necessário informar o nivel de permissão!");
        }
    }
    }
}
