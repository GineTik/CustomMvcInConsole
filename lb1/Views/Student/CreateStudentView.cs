using BussinessLogicLayer.Consoles;
using DataLayer.Entities;
using lb1.Controllers;
using MVC.Redirectors.Implements;
using MVC.Redirectors.Interfaces;
using MVC.ViewElements.MenuList;
using MVC.Views;
using System;

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
                    ActionRedirector.ToAction<StudentController>(nameof(StudentController.AddStudent), _student)),

                new ViewMenuItem("Ввести заново", 
                    ActionRedirector.LastAction),

                new ViewMenuItem("Відмінити додавання", 
                    ActionRedirector.ToAction<HomeController>(nameof(HomeController.Index))),
            };
        }

        public override IRedirector Show()
        {
            Console.WriteLine("Заповніть дані студента\n");

            _student.FirstName = ConsoleWrapper.ReadType<string>("FistName: ");
            _student.LastName = ConsoleWrapper.ReadType<string>("LastName: ");
            _student.Course = ConsoleWrapper.ReadType<uint>("Course: ");
            _student.Birthday = ConsoleWrapper.ReadType<DateTime>("Birthday: ");

            Console.WriteLine();
            DisplayMenu();

            return IRedirector.None;
        }
    }
}
