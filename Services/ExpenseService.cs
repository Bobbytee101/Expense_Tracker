using System.Collections.Generic;
using System.Threading.Tasks;
using ExpenseTracker.Models;
using Microsoft.EntityFrameworkCore;

public class ExpenseService : IExpenseService
{
    private readonly ApplicationDbContext _context;

    public ExpenseService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Expense>> GetAllExpensesAsync()
    {
        return await _context.Expenses.ToListAsync();
    }

    public async Task<Expense> GetExpenseByIdAsync(int id)
    {
#pragma warning disable CS8603 // Possible null reference return.
        return await _context.Expenses.FindAsync(id);
#pragma warning restore CS8603 // Possible null reference return.
    }

    public async Task AddExpenseAsync(Expense expense)
    {
        _context.Expenses.Add(expense);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateExpenseAsync(Expense expense)
    {
        _context.Entry(expense).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }

    public async Task DeleteExpenseAsync(int id)
    {
        var expense = await _context.Expenses.FindAsync(id);
        if (expense != null)
        {
            _context.Expenses.Remove(expense);
            await _context.SaveChangesAsync();
        }
    }
}
