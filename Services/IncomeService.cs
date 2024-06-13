using ExpenseTracker.Models;
using Microsoft.EntityFrameworkCore;

public class IncomeService : IIncomeService
{
    private readonly ApplicationDbContext _context;

    public IncomeService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Income>> GetAllIncomesAsync()
    {
        return await _context.Incomes.ToListAsync();
    }

    public async Task<Income> GetIncomeByIdAsync(int id)
    {
#pragma warning disable CS8603 // Possible null reference return.
        return await _context.Incomes.FindAsync(id);
#pragma warning restore CS8603 // Possible null reference return.
    }

    public async Task AddIncomeAsync(Income income)
    {
        _context.Incomes.Add(income);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateIncomeAsync(Income income)
    {
        _context.Entry(income).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }

    public async Task DeleteIncomeAsync(int id)
    {
        var income = await _context.Incomes.FindAsync(id);
        if (income != null)
        {
            _context.Incomes.Remove(income);
            await _context.SaveChangesAsync();
        }
    }
}
