using MVC.Redirectors.Implements;
using DataLayer.Entities;
using MVC.Controllers;
using lb1.Views.Students;
using MVC.Redirectors.Interfaces;
using DataLayer.Repositories.Interfaces;
using DataLayer.Repositories.FilesImplementations;

namespace lb1.Controllers
{
    public class StudentController : Controller
    {
        public readonly IStudentRepository _studentRepository;

        public StudentController()
        {
            _studentRepository = new StudentFileRepository();
        }

        public IRedirector AddStudent()
        {
            return ViewRedirector.OpenView(new CreateStudentView());
        }

        public IRedirector AddStudent(Student student)
        {
            student.Id = student.FirstName + student.LastName;
            _studentRepository.Add(student);
            return ActionRedirector.ToAction<HomeController>("Index");
        }

        public IRedirector List()
        {
            var students = _studentRepository.GetAll();
            return ViewRedirector.OpenView(new StudentListView(students));
        }
    }
}
