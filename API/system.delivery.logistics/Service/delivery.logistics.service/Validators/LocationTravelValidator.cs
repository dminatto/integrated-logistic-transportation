using System;
using delivery.logistics.domain.Entities;
using FluentValidation;

namespace delivery.logistics.service.Validators
{
    public class LocationTravelValidator : AbstractValidator<LocationTravel>
    {
        public LocationTravelValidator()
        {
            RuleFor(c => c)
                .NotNull()
                .OnAnyFailure(x =>
                {
                    throw new ArgumentNullException("Não foi possivel encontrar o objeto!");
                });

            RuleFor(c => c.IdTravelAgenda)
                .NotNull().WithMessage("É necessário vincular uma viagem á esta localização!")
                .NotEmpty().WithMessage("É necessário vincular uma viagem á esta localização!");

            RuleFor(c => c.Latitude)
                .NotNull().WithMessage("É necessário informar uma Latitude!")
                .NotEmpty().WithMessage("É necessário informar uma Latitude!");

            RuleFor(c => c.Longitude)
                .NotNull().WithMessage("É necessário informar uma Longitude!")
                .NotEmpty().WithMessage("É necessário informar uma Longitude!");
        }
    }
}
