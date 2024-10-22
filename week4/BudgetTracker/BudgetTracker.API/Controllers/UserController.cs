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
    //Add new

    //Get by Id

    //Update

    //Delete
}