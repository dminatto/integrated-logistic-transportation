using delivery.logistics.domain.Entities;
using FluentValidation;
using System;

namespace delivery.logistics.service.Validators
{
    public class DeliveryProgressValidator : AbstractValidator<DeliveryProgress>
    {
        public DeliveryProgressValidator()
        {
            RuleFor(c => c)
                .NotNull()
                .OnAnyFailure(x =>
                {
                    throw new ArgumentNullException("Não foi possivel encontrar o objeto!");
                });

            RuleFor(c => c.IdDeliveryOrder)
                .NotNull().WithMessage("É necessário vincular uma ordem de coleta a esta entrega!")
                .NotEmpty().WithMessage("É necessário vincular uma ordem de coleta a esta entrega!");

            RuleFor(c => c.StatusDelivery)
                .NotNull().WithMessage("É necessário informar um status a esta entrega!")
                .NotEmpty().WithMessage("É necessário informar um status a esta entrega!");


        }
    }
}
