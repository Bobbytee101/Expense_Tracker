using Microsoft.AspNetCore.Mvc;
using ExpenseTracker.Models;

[ApiController]
[Route("api/[controller]")]
public class IncomeController : ControllerBase
{
    private readonly IIncomeService _incomeService;

    public IncomeController(IIncomeService incomeService)
    {
        _incomeService = incomeService;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Income>>> GetIncomes()
    {
        var incomes = await _incomeService.GetAllIncomesAsync();
        return Ok(incomes);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Income>> GetIncome(int id)
    {
        var income = await _incomeService.GetIncomeByIdAsync(id);
        if (income == null)
        {
            return NotFound();
        }
        return Ok(income);
    }

    [HttpPost]
    public async Task<ActionResult> CreateIncome([FromBody] Income income)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        await _incomeService.AddIncomeAsync(income);
        return CreatedAtAction(nameof(GetIncome), new { id = income.Id }, income);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult> UpdateIncome(int id, [FromBody] Income income)
    {
        if (id != income.Id)
        {
            return BadRequest();
        }

        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        await _incomeService.UpdateIncomeAsync(income);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> DeleteIncome(int id)
    {
        var income = await _incomeService.GetIncomeByIdAsync(id);
        if (income == null)
        {
            return NotFound();
        }

        await _incomeService.DeleteIncomeAsync(id);
        return NoContent();
    }
}
