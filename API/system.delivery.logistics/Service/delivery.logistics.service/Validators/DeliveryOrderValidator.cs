using delivery.logistics.domain.Entities;
using FluentValidation;
using System;

namespace delivery.logistics.service.Validators
{
    public class DeliveryOrderValidator : AbstractValidator<DeliveryOrder>
    {
        public DeliveryOrderValidator()
        {
            RuleFor(c => c)
                .NotNull()
                .OnAnyFailure(x =>
                {
                    throw new ArgumentNullException("Não foi possivel encontrar o objeto!");
                });

            RuleFor(c => c.TokenOrder)
                .NotNull().WithMessage("É necessário informar o token desta entrega!")
                .NotEmpty().WithMessage("É necessário informar o token desta entrega!");
        }
    }
}
