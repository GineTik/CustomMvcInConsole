using MVC.Redirectors.Interfaces;
using MVC.ViewElements.MenuList;

namespace MVC.Views
{
    public abstract class View
    {
        public List<ViewMenuItem> MenuList { get; set; } = new List<ViewMenuItem>();

        public abstract IRedirector Show();

        public void DisplayMenu()
        {
            int i = 0;
            foreach (var item in MenuList)
                Console.WriteLine($"{++i}. {item.Message}");
        }

        public IRedirector GetAnswer()
        {
            if (MenuList.Count == 0)
                throw new InvalidOperationException("menu is empty");

            bool successKey = false;
            int key = -1;
            while (successKey == false)
            {
                Console.Write(">>> ");
                successKey = int.TryParse(Console.ReadLine(), out key);
                key--;

                if (key < 0 || key >= MenuList.Count)
                    successKey = false;
            }

            return MenuList[key].Redirector;
        }
    }
}
