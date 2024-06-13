using ExpenseTracker.Models;

public interface IIncomeService
{
    Task<IEnumerable<Income>> GetAllIncomesAsync();
    Task<Income> GetIncomeByIdAsync(int id);
    Task AddIncomeAsync(Income income);
    Task UpdateIncomeAsync(Income income);
    Task DeleteIncomeAsync(int id);
}
