using MVC.Redirecters.Interfaces;
using MVC.Views;

namespace MVC.Redirecters.Implements
{
    public class ViewRedirecter : IRedirecter
    {
        public View View { get; set; }

        public ViewRedirecter(View view)
        {
            View = view;
        }

        public IRedirecter Redirect()
        {
            IRedirecter redirecter = View.Show();

            if (View.MenuList.Count > 0)
                redirecter = View.GetAnswer();
            else
                Console.ReadKey();

            return redirecter;
        }

        public static IRedirecter OpenView(View view) => new ViewRedirecter(view);
    }
}
