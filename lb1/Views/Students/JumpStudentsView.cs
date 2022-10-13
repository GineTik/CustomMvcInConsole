using lb1.Controllers;
using MVC.Redirecters.Interfaces;
using MVC.Views;

namespace lb1.Views.Students
{
    public class JumpStudentsView : View
    {
        public override IRedirecter Show()
        {
            Console.WriteLine("студенти пригнули з парашутами :)");
            return ToAction<HomeController>(nameof(HomeController.Index));
        }
    }
}
