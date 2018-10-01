using delivery.logistics.domain.Entities;
using FluentValidation;
using System;

namespace delivery.logistics.service.Validators
{
    public class FeedbackValidator : AbstractValidator<Feedback>
    {
        public FeedbackValidator()
        {
            RuleFor(c => c)
                .NotNull()
                .OnAnyFailure(x =>
                {
                    throw new ArgumentNullException("Não foi possivel encontrar o objeto!");
                });

            RuleFor(c => c.Rating)
                .NotNull().WithMessage("É necessário informar uma classificação para o serviço!")
                .NotEmpty().WithMessage("É necessário informar uma classificação para o serviço!");
        }
    }
}
