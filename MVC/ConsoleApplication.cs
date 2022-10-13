using MVC.Redirecters.Implements;
using MVC.Redirecters.Interfaces;

namespace MVC
{
    public class ConsoleApplication
    {
        private IRedirecter _redirecter;

        public ConsoleApplication(Type controllerType, string actionName)
        {
            if (controllerType == null)
                throw new ArgumentNullException(nameof(controllerType));

            if (string.IsNullOrEmpty(actionName) == true)
                throw new ArgumentException(nameof(actionName));

            _redirecter = ActionRedirecter.ToAction(controllerType, actionName);
        }

        public void Run()
        {
            bool exit = false;
            while(exit == false)
            {
                _redirecter = _redirecter.Redirect();
                
                if (_redirecter == null)
                    exit = true;

                Console.Clear();
            }

            Console.WriteLine("Дякую за користуванням програмою! :)");
            Console.ReadKey();
        }
    }
}
