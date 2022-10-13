using lb1.Controllers;
using MVC.Redirecters.Implements;
using MVC.Redirecters.Interfaces;
using MVC.ViewElements.MenuList;
using MVC.Views;

namespace lb1.Views.Home
{
    public class AddUserView : View
    {
        public AddUserView()
        {
            MenuList = new()
            {
                new ViewMenuItem("Створити студента",
                    ToAction<StudentController>(nameof(StudentController.AddStudent))),

                new ViewMenuItem("Створити підприємця", DisplayText("Функція ще не реалізована")),
                
                new ViewMenuItem("Створити байкера", DisplayText("Функція ще не реалізована")),
                
                new ViewMenuItem("Назад", 
                    ToAction<HomeController>(nameof(HomeController.Index))),
            };
        }

        public override IRedirecter Show()
        {
            DisplayMenu();
            return IRedirecter.None;
        }
    }
}
