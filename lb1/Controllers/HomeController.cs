using lb1.Views;
using MVC.Controllers;
using MVC.Redirectors.Interfaces;
using MVC.Redirectors.Implements;
using lb1.Views.Home;

namespace lb1.Controllers
{
    public class HomeController : Controller
    {
        public IRedirector Index()
        {
            return ViewRedirector.OpenView(new HomeIndexView());
        }
    }
}
