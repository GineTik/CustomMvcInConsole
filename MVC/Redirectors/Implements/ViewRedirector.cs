using MVC.Redirectors.Interfaces;
using MVC.Views;

namespace MVC.Redirectors.Implements
{
    public class ViewRedirector : IRedirector
    {
        public View View { get; set; }

        public ViewRedirector(View view)
        {
            View = view;
        }

        public IRedirector Redirect()
        {
            IRedirector redirector = View.Show();

            if (View.MenuList.Count > 0)
                redirector = View.GetAnswer();
            else
                Console.ReadKey();

            return redirector;
        }

        public static IRedirector OpenView(View view) => new ViewRedirector(view);
    }
}
