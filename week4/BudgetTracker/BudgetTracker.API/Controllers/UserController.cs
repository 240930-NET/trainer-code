using BudgetTracker.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace BudgetTracker.API;

[ApiController]
[Route("/api/[controller]")]
public class UserController : Controller{

    private readonly IUserService _userService; // dependency injection

    public UserController(IUserService userService){
        _userService = userService;
    }

    //Get all users endpoint
    [HttpGet]
    public async Task<ActionResult> GetAllUsers(){

        try{
           return Ok(await _userService.GetAllUsers());
        }
        catch(Exception ex){
            return StatusCode(500, ex.Message); // return server error with the error message
        }
    }
      //Get by Id
    [HttpGet("getById/{id}")]
    public async Task<ActionResult> GetUserByUserId(int id){
        try{
            return Ok(await _userService.GetUserById(id));
        }
        catch(Exception ex){
            return StatusCode(500, ex.Message); // return server error with the error message
        }
    }

    //Add new
    [HttpPost("addNewUser")]
    [ProducesResponseType(StatusCodes.Status201Created)] // data annotation to send status code

    public async Task<ActionResult> AddNewUser([FromBody] User user){
        try{
           return Json( await _userService.AddNewUser(user));
        }
        catch(Exception ex){
            return StatusCode(500, ex.Message);
        }
    }

    //Update
    [HttpPut("UpdateUser")]
    public async Task<ActionResult> UpdateUser([FromBody] User user){
        try{
            return Ok(await _userService.UpdateUser(user));
        }
        catch(Exception ex){
            return StatusCode(500, ex.Message);
        }
    }

    //Delete
    [HttpDelete("deleteUser/{id}")]
    public async Task<ActionResult> DeleteUser(int id){
        try{
            return Ok(await _userService.DeleteUser(id));
        }
        catch(Exception ex){
            return StatusCode(500, ex.Message);
        }
    }
}