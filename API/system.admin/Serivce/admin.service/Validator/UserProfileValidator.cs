using admin.domain.Entities;
using FluentValidation;
using System;


namespace admin.service.Validator
{
    public class UserProfileValidator : AbstractValidator<UserProfile>
    {
        public UserProfileValidator()
        {
            RuleFor(c => c)
                .NotNull()
                .OnAnyFailure(x =>
                {
                    throw new ArgumentNullException("Não foi possivel encontrar o objeto!");
                });

            RuleFor(c => c.NameUserProfile)
                .NotNull().WithMessage("É necessário informar o nome do perifl de usuário!")
                .NotEmpty().WithMessage("É necessário informar o nome do perifl de usuário!");
        }
    }
}
