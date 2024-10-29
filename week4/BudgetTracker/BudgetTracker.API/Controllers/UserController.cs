using Microsoft.AspNetCore.Mvc;
using BudgetTracker.Models;
using BudgetTracker.API.Service;
using BudgetTracker.API.Models.DTO;


namespace ExpenseTracker.API;

[ApiController]
[Route("api/[controller]")]
public class UserController: Controller{
     private readonly IUserService _userService;

    public UserController(IUserService userService){
        _userService = userService;
    }

    //Get all expenses
    [HttpGet]
    public async Task<IActionResult> getAllUsers(){ //IActionResult return a certait type of response (views, json etc)
        
        try{
            return Ok(await _userService.GetAllUsers());
        }
        catch(Exception e){
            return BadRequest(e.Message);
        }
        
    }

    [HttpGet("GetUserById/{id}")]
    public async Task<IActionResult> getById(int id){ //IActionResult return a certait type of response (views, json etc)
        
        try{
            return Ok(await _userService.GetUserById(id));
        }
        catch(Exception e){
            return BadRequest(e.Message);
        }
        
    }

    //Add a new expense
    [HttpPost("AddNewUser")]
    public async Task<IActionResult> AddNewUser([FromBody] NewUserDTO user){
        
        try{
            await _userService.AddUser(user);
            return Ok(user);
        }
        catch(Exception e){
            return BadRequest(e.Message);
        }
    }
    //Edit an existing expense
    [HttpPut("EditUser")]
    public async Task<IActionResult> EditExpense([FromBody] User user){
        try{
            await _userService.UpdateUser(user);
            return Ok(user);
        }

        catch(Exception e){
            return BadRequest(e.Message);
        }
    }

    //Delete an expense
    [HttpDelete("DeleteUser/{id}")]
    public async Task<IActionResult> DeleteExpense(int id){
        try{    
            await _userService.DeleteUser(id);
            return Ok();
        }

        catch(Exception e){
            return BadRequest(e.Message);
        }
    }

}