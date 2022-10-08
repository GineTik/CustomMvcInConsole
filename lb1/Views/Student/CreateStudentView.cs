using lb1.Controllers;
using MVC.Redirectors.Implements;
using MVC.Redirectors.Interfaces;
using MVC.Views;

namespace lb1.Views.Student
{
    public class CreateStudentView : View
    {
        public override IRedirector Show()
        {
            Console.WriteLine("CreateStudentView");
            var student = new DataLayer.Entities.Student()
            {
                FirstName = "Коля",
                LastName = "Антонович",
                Course = 1,
            };
            return ActionRedirector.ToAction<StudentController>(nameof(StudentController.AddStudent), student);
        }
    }
}
