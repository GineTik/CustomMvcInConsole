using MVC.Redirecters.Interfaces;

namespace MVC.Redirecters.Implements
{
    public class TextRedirecter : IRedirecter
    {
        private readonly string _text;

        public TextRedirecter(string text)
        {
            _text = text;
        }

        public IRedirecter Redirect()
        {
            Console.WriteLine(_text);
            Console.ReadKey();
            return ActionRedirecter.ToLastAction;
        }

        public static IRedirecter DisplayText(string text) => new TextRedirecter(text);
    }
}
