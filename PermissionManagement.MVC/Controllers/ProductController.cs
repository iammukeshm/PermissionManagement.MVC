using Microsoft.AspNetCore.Mvc;

namespace PermissionManagement.MVC.Controllers
{
public class ProductController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
}