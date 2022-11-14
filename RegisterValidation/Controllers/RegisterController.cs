namespace RegisterValidation.Controllers;

public class RegisterController : Controller
{
    public IActionResult Index() => View();


    public IActionResult SignUp() => View();

    [HttpPost] public IActionResult SignUp(User user) => View();
}
