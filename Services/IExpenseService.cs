using ExpenseTracker.Models;

public interface IExpenseService
{
    Task<IEnumerable<Expense>> GetAllExpensesAsync();
    Task<Expense> GetExpenseByIdAsync(int id);
    Task AddExpenseAsync(Expense expense);
    Task UpdateExpenseAsync(Expense expense);
    Task DeleteExpenseAsync(int id);
}
