using FluentValidation;
using ExpenseTracker.Models;

public class ExpenseValidator : AbstractValidator<Expense>
{
    public ExpenseValidator()
    {
        RuleFor(x => x.Amount).GreaterThan(0).WithMessage("Amount must be greater than zero.");
        RuleFor(x => x.Description).NotEmpty().WithMessage("Description is required.");
        RuleFor(x => x.Date).NotEmpty().WithMessage("Date is required.");
        RuleFor(x => x.CategoryId).GreaterThan(0).WithMessage("CategoryId is required.");
        RuleFor(x => x.UserId).GreaterThan(0).WithMessage("UserId is required.");
    }
}
