using FluentValidation;
using ExpenseTracker.Models;

public class IncomeValidator : AbstractValidator<Income>
{
    public IncomeValidator()
    {
        RuleFor(x => x.Amount)
            .GreaterThan(0).WithMessage("Amount must be greater than zero.");

        RuleFor(x => x.Description)
            .NotEmpty().WithMessage("Description is required.");

        RuleFor(x => x.Date)
            .NotEmpty().WithMessage("Date is required.");

        RuleFor(x => x.UserId)
            .GreaterThan(0).WithMessage("UserId is required.");
    }
}
