using MVC.Redirecters.Interfaces;
using MVC.Views;
using DataLayer.Entities;
using MVC.Redirecters.Implements;
using lb1.Controllers;

namespace lb1.Views.Students
{
    public class StudentListView : View
    {
        private readonly IEnumerable<Student> _students;

        public StudentListView(IEnumerable<Student> students)
        {
            _students = students;
        }

        public override IRedirecter Show()
        {
            if (_students.Count() == 0)
                Console.WriteLine("Не знайдено жодного студента");
            else
                DisplayStudentsList();

            return ActionRedirecter.ToAction<HomeController>(nameof(HomeController.Index));
        }

        public void DisplayStudentsList()
        {
            foreach (var student in _students)
            {
                Console.WriteLine($"{student.GetType().Name} {student.Id}");
                Console.WriteLine($"FirstName: {student.FirstName}");
                Console.WriteLine($"LastName: {student.LastName}");
                Console.WriteLine($"Course: {student.Course}");
                Console.WriteLine($"Birthday: {student.Birthday.ToString("dd.MM.yyyy")}");
                Console.WriteLine("\n\n");
            }
        }
    }
}
