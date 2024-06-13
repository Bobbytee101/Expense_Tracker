using FluentValidation;
using ExpenseTracker.Models;

public class CategoryValidator : AbstractValidator<Category>
{
    public CategoryValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty().WithMessage("Category name is required.")
            .MaximumLength(50).WithMessage("Category name must not exceed 50 characters.");
    }
}
