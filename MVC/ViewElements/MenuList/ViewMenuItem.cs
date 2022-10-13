using MVC.Redirecters.Interfaces;

namespace MVC.ViewElements.MenuList
{
    public class ViewMenuItem
    {
        public string Message { get; set; }
        public IRedirecter Redirecter { get; set; }

        public ViewMenuItem(string message, IRedirecter redirector)
        {
            if (string.IsNullOrEmpty(message) == true)
                throw new ArgumentException(nameof(message));

            Message = message;
            Redirecter = redirector;
        }
    }
}
