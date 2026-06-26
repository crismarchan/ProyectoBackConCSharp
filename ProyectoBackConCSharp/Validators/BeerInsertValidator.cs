using FluentValidation;
using ProyectoBackConCSharp.DTOs;

namespace ProyectoBackConCSharp.Validators
{
    public class BeerInsertValidator : AbstractValidator<BeerInsertDto>
    {
        public BeerInsertValidator() { 
        
            RuleFor (x => x.Name).NotEmpty();
        }
    }
}
