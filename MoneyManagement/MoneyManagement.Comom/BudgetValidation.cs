using FluentValidation;
using MoneyManagement.Domain.Model;

namespace MoneyManagement.Comom
{
    public class BudgetValidation : AbstractValidator<Budget>
    {
        public BudgetValidation()
        {
            RuleFor(customer => customer.budgetType).IsInEnum();
            RuleFor(customer => customer.Name).NotNull().NotEmpty().WithMessage("O campo nome não pode ser vazio");
            RuleFor(customer => customer.Value).NotNull().NotEmpty().WithMessage("Digite um valor valido");
            RuleFor(customer => customer.ExpirationDate).NotNull().NotEmpty().WithMessage("Data invalida");
        }
    }
}
