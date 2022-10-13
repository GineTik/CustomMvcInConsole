using MVC.Redirecters.Implements;
using MVC.Views;
using MVC.ViewElements.MenuList;
using lb1.Controllers;
using MVC.Redirecters.Interfaces;

namespace lb1.Views.Home
{
    public class HomeIndexView : View
    {
        public HomeIndexView()
        {
            MenuList = new List<ViewMenuItem>()
            {
                new ViewMenuItem("Додати нового користувача", 
                    ToAction<HomeController>(nameof(HomeController.AddUser))),

                new ViewMenuItem("Список усіх студентів",
                    ToAction<StudentController>(nameof(StudentController.List))),

                new ViewMenuItem("Список усіх байкерів", ActionRedirecter.ToLastAction),

                new ViewMenuItem("Список усіх підприємців", ActionRedirecter.ToLastAction),
                
                new ViewMenuItem("Пригнути з парашута",
                    ToAction<StudentController>(nameof(StudentController.JumpFromParachute))),

                new ViewMenuItem("Отримати усіх студентів, які на 4 курсі та народились навесні", 
                    ToAction<StudentController>(nameof(StudentController.GetStudentsByTask))),

                new ViewMenuItem("Вийти", IRedirecter.Exit),
            };
        }

        public override IRedirecter Show()
        {
            Console.WriteLine("Вітаємо вас в адмін панелі\n");
            DisplayMenu();
            return IRedirecter.None;
        }
    }
}
