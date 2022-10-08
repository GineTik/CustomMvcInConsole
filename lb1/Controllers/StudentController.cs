using MVC.Redirectors.Implements;
using MVC.Views;
using DataLayer.Entities;
using MVC.Controllers;
using lb1.Views.Student;
using MVC.Redirectors.Interfaces;

namespace lb1.Controllers
{
    public class StudentController : Controller
    {
        public IRedirector AddStudent()
        {
            return ViewRedirector.OpenView(new CreateStudentView());
        }

        public IRedirector AddStudent(Student student)
        {
            return ActionRedirector.ToAction<HomeController>("Index");
        }
    }
}
