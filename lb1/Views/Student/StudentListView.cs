using MVC.Redirectors.Interfaces;
using MVC.Views;
using DataLayer.Entities;
using MVC.Redirectors.Implements;
using lb1.Controllers;

namespace lb1.Views.Students
{
    public class StudentListView : View
    {
        private readonly List<Student> _students;

        public StudentListView(List<Student> students)
        {
            _students = students;
        }

        public override IRedirector Show()
        {
            if (_students.Count == 0)
                Console.WriteLine("Немає жодних студентів");
            else
                DisplayStudentsList();

            return ActionRedirector.ToAction<HomeController>(nameof(HomeController.Index));
        }

        public void DisplayStudentsList()
        {
            foreach (var student in _students)
            {
                Console.WriteLine($"{student.GetType().Name} {student.Id}");
                Console.WriteLine($"FirstName: {student.FirstName}");
                Console.WriteLine($"LastName: {student.LastName}");
                Console.WriteLine($"Course: {student.Course}");
                Console.WriteLine($"Birthday: {student.Birthday.ToString("dd.mm.yyyy")}");
                Console.WriteLine("\n\n");
            }
        }
    }
}
