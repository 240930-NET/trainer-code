using Microsoft.AspNetCore.Mvc;

namespace Sample.API.Controller;

[Route("/")]
[ApiController]
public class HomeController : ControllerBase
{
    [HttpGet]
    public ContentResult Welcome()
    {
        var html = "<p>Welcome to my API, There is nothing here. Goto /swagger<p>";

        return new ContentResult
        {
            Content = html,
            ContentType = "text/html"
        };
    }
}