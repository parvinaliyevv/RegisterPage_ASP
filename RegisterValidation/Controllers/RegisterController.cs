namespace RegisterValidation.Controllers;

public class RegisterController : Controller
{
    public IActionResult Index() => View();


    [HttpGet]
    public IActionResult SignUp()
    {
        return View();
    }

    [HttpPost]
    public IActionResult SignUp(User user)
    {
        return View();
    }
}
