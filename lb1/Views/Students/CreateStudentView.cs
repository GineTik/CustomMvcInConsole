using BussinessLogicLayer.Consoles;
using DataLayer.Entities;
using lb1.Controllers;
using MVC.Redirecters.Implements;
using MVC.Redirecters.Interfaces;
using MVC.ViewElements.MenuList;
using MVC.Views;

namespace lb1.Views.Students
{
    public class CreateStudentView : View
    {
        private readonly Student _student;

        public CreateStudentView()
        {
            _student = new Student();
            MenuList = new()
            {
                new ViewMenuItem("Підтвердити введені дані",
                    ActionRedirecter.ToAction<StudentController>(nameof(StudentController.AddStudent), _student)),

                new ViewMenuItem("Ввести заново", 
                    ActionRedirecter.ToLastAction),

                new ViewMenuItem("Відмінити додавання", 
                    ActionRedirecter.ToAction<HomeController>(nameof(HomeController.Index))),
            };
        }

        public override IRedirecter Show()
        {
            Console.WriteLine("Заповніть дані студента\n");

            _student.FirstName = ConsoleWrapper.ReadType<string>("FistName: ");
            _student.LastName = ConsoleWrapper.ReadType<string>("LastName: ");
            _student.Course = ConsoleWrapper.ReadType<uint>("Course: ");
            _student.Birthday = ConsoleWrapper.ReadType<DateTime>("Birthday: ");

            Console.WriteLine();
            DisplayMenu();

            return IRedirecter.None;
        }
    }
}
