using BudgetTracker.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;


namespace BudgetTracker.API;

[ApiController] // this Data Annonation is marking our class as a controller
[Route("api/[controller]")]
public class ExpenseController : Controller{

    private readonly IExpenseService _expenseService; // dependency injection 

    public ExpenseController(IExpenseService expenseService){
        _expenseService = expenseService;
    }

    [HttpGet] // this Data Annonation is marking our method as a GET method (no route means the endpoint is '/')
    public IActionResult GetExpenses(){
        try{
           return Ok(_expenseService.GetAllExpenses()); // return status ok and our List of Expenses
        }
        catch(Exception ex){
            return StatusCode(500, ex.Message); // return server error with the error message
        }
    }

    [HttpGet("getExpenseById/{id}")]
    public IActionResult GetExpenseById(int id){

        try{
           Expense searchedExpense =  _expenseService.GetExpenseById(id);
           return Ok(searchedExpense);
        }
        catch(Exception e){
            return StatusCode(500, e.Message); 
        }
    }

    // Route to add a new expese
    [HttpPost("addNewExpense")]
    public IActionResult AddNewExpense([FromBody] Expense expense){

        try{
            _expenseService.AddExpense(expense);
            return Ok(expense);
        }
        catch(Exception e){
            return BadRequest("Could not add expense");
        }
    }

    //Route for editing
    [HttpPut("editExpense")]
    public IActionResult EditExpense([FromBody] Expense expense){

        try{
            _expenseService.EditExpense(expense);
            return Ok(expense);
        }
        catch(Exception e){
            return BadRequest("Could not edit expense");
        }
    }

    //Route for deleting
    [HttpDelete("deleteExpense/{id}")]
    public IActionResult DeleteExpense(int id){

        try{
            _expenseService.DeleteExpense(id);
            return Ok("Expense deleted");
        }
        catch(Exception e){
            return BadRequest("Could not delete expense");
        }
    }



}   