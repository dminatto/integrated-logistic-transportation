﻿using admin.domain.Entities;
using FluentValidation;
using System;

namespace admin.service.Validator
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(c => c)
                .NotNull()
                .OnAnyFailure(x =>
                {
                    throw new ArgumentNullException("Não foi possivel encontrar o objeto!");
                });

            RuleFor(c => c.NameUser)
                .NotNull().WithMessage("É necessário informar um nome!")
                .NotEmpty().WithMessage("É necessário informar um nome!");

            RuleFor(c => c.PasswordUser)
                .NotNull().WithMessage("É necessário informar uma senha!")
                .NotEmpty().WithMessage("É necessário informar uma senha!");

            RuleFor(c => c.UserProfile)
                .NotNull().WithMessage("É necessário selecionar um tipo de pefil de usuário!")
                .NotEmpty().WithMessage("É necessário selecionar um tipo de pefil de usuário!");
        }
    }
}
