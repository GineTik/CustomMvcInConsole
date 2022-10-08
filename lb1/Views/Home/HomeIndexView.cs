using MVC.Redirectors.Implements;
using MVC.Views;
using MVC.ViewElements.MenuList;
using lb1.Controllers;
using MVC.Redirectors.Interfaces;

namespace lb1.Views.Home
{
    public class HomeIndexView : View
    {
        public HomeIndexView()
        {
            MenuList = new List<ViewMenuItem>()
            {
                new ViewMenuItem("Додати нового користувача", 
                    ActionRedirector.ToAction<StudentController>(nameof(StudentController.AddStudent))),

                new ViewMenuItem("Список усіх студентів",
                    ActionRedirector.ToAction<StudentController>(nameof(StudentController.List))),

                new ViewMenuItem("Список усіх байкерів", IRedirector.Exit),

                new ViewMenuItem("Список усіх підприємців", IRedirector.Exit),

                new ViewMenuItem("Вийти", IRedirector.Exit),
            };
        }

        public override IRedirector Show()
        {
            Console.WriteLine("Вітаємо вас в адмін панелі\n");
            DisplayMenu();
            return null;
        }
    }
}
