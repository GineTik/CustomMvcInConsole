using MVC.Controllers;
using MVC.Redirecters.Interfaces;
using MVC.Redirecters.Implements;
using lb1.Views.Home;

namespace lb1.Controllers
{
    public class HomeController : Controller
    {
        public IRedirecter Index()
        {
            return View(new HomeIndexView());
        }

        public IRedirecter AddUser()
        {
            return View(new AddUserView());
        }
    }
}
