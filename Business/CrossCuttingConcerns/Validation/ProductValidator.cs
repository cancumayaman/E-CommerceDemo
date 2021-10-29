using Entities.Concrete;
using FluentValidation;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.CrossCuttingConcerns.Validation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.ProductName).NotEmpty();
            RuleFor(p => p.ProductName).MinimumLength(2);
            RuleFor(p => p.ProductName).Must(StartWithA).WithMessage("Products must start with A");
        }
        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}


