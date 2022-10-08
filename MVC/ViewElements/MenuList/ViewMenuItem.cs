using MVC.Redirectors.Interfaces;

namespace MVC.ViewElements.MenuList
{
    public class ViewMenuItem
    {
        public string Message { get; set; }
        public IRedirector Redirector { get; set; }

        public ViewMenuItem(string message, IRedirector redirector)
        {
            if (string.IsNullOrEmpty(message) == true)
                throw new ArgumentException(nameof(message));

            Message = message;
            Redirector = redirector;
        }
    }
}
