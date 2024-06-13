using Microsoft.AspNetCore.Mvc;
using ExpenseTracker.Models;

[ApiController]
[Route("api/[controller]")]
public class ExpensesController : ControllerBase
{
    private readonly IExpenseService _expenseService;

    public ExpensesController(IExpenseService expenseService)
    {
        _expenseService = expenseService;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Expense>>> GetExpenses()
    {
        var expenses = await _expenseService.GetAllExpensesAsync();
        return Ok(expenses);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Expense>> GetExpense(int id)
    {
        var expense = await _expenseService.GetExpenseByIdAsync(id);
        if (expense == null)
        {
            return NotFound();
        }
        return Ok(expense);
    }

    [HttpPost]
    public async Task<ActionResult> CreateExpense([FromBody] Expense expense)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        await _expenseService.AddExpenseAsync(expense);
        return CreatedAtAction(nameof(GetExpense), new { id = expense.Id }, expense);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult> UpdateExpense(int id, [FromBody] Expense expense)
    {
        if (id != expense.Id)
        {
            return BadRequest();
        }

        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        await _expenseService.UpdateExpenseAsync(expense);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> DeleteExpense(int id)
    {
        var expense = await _expenseService.GetExpenseByIdAsync(id);
        if (expense == null)
        {
            return NotFound();
        }

        await _expenseService.DeleteExpenseAsync(id);
        return NoContent();
    }
}
