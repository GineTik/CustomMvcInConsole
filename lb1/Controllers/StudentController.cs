using MVC.Redirecters.Implements;
using DataLayer.Entities;
using MVC.Controllers;
using lb1.Views.Students;
using MVC.Redirecters.Interfaces;
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

        public IRedirecter AddStudent()
        {
            return View(new CreateStudentView());
        }

        public IRedirecter AddStudent(Student student)
        {
            student.Id = student.FirstName + student.LastName;
            _studentRepository.Add(student);
            return ActionRedirecter.ToAction<HomeController>(nameof(HomeController.Index));
        }

        public IRedirecter List()
        {
            var students = _studentRepository.GetAll();
            return View(new StudentListView(students));
        }

        public IRedirecter JumpFromParachute()
        {
            return View(new JumpStudentsView());
        }

        public IRedirecter GetStudentsByTask()
        {
            var students = _studentRepository.GetStudentsByTask();
            return View(new StudentListView(students));
        }
    }
}
