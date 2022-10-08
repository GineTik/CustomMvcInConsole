using MVC.Redirectors.Implements;
using MVC.Redirectors.Interfaces;

namespace MVC
{
    public class ConsoleApplication
    {
        private IRedirector _redirector;

        public ConsoleApplication(Type controllerType, string actionName)
        {
            if (controllerType == null)
                throw new ArgumentNullException(nameof(controllerType));

            if (string.IsNullOrEmpty(actionName) == true)
                throw new ArgumentException(nameof(actionName));

            _redirector = ActionRedirector.ToAction(controllerType, actionName);
        }

        public void Run()
        {
            bool exit = false;
            while(exit == false)
            {
                _redirector = _redirector.Redirect();
                
                if (_redirector == null)
                    exit = true;

                Console.Clear();
            }

            Console.WriteLine("Дякую за користуванням програмою! :)");
            Console.ReadKey();
        }
    }
}
