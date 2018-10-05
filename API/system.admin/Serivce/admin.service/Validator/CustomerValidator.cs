﻿using admin.domain.Entities;
using FluentValidation;
using System;

namespace admin.service.Validator
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

            RuleFor(c => c.NameCustomer)
                .NotNull().WithMessage("É necessário informar o nome do cliente!")
                .NotEmpty().WithMessage("É necessário informar o nome do cliente!");

            RuleFor(c => c.CpfCustomer)
                .NotNull().WithMessage("É necessário informar o CPF do cliente!")
                .NotEmpty().WithMessage("É necessário informar o CPF do cliente!");

            RuleFor(c => c.EmailCustomer)
                .NotEmpty().WithMessage("É necessário informar o email do cliente!")
                .NotNull().WithMessage("É necessário informar o email do cliente!");

            RuleFor(c => c.CepCustomer)
                .NotNull().WithMessage("É necessário informar o CEP do cliente!")
                .NotEmpty().WithMessage("É necessário informar o CEP do cliente!");

            RuleFor(c => c.PhoneCustomer)
                .NotNull().WithMessage("É necessário informar o telefone do cliente!")
                .NotEmpty().WithMessage("É necessário informar o telefone do cliente!");
        }
    }
}
