﻿using admin.domain.Entities;
using FluentValidation;
using System;

namespace admin.services.Validators
{
    public class StateValidador : AbstractValidator<State>
    {
        public StateValidador()
        {
            RuleFor(c => c)
                .NotNull()
                .OnAnyFailure(x =>
                {
                    throw new ArgumentNullException("Não foi possivel encontrar o objeto!");
                });
            
            RuleFor(c => c.nameState)
                .NotNull().WithMessage("É necessário informar o nome do estado!")
                .NotEmpty().WithMessage("É necessário informar o nome do estado!");
        }
    }
}
