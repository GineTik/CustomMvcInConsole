using MVC.Redirecters.Implements;
using MVC.Redirecters.Interfaces;
using MVC.Views;

namespace MVC.Controllers
{
    public class Controller
    {
        public IRedirecter InvokeAction(string action, params object[] param)
        {
            if (param == null)
                throw new ArgumentNullException(nameof(param));

            var method = GetType().GetMethod(action, param.Select(o => o.GetType()).ToArray());

            if (method == null)
                throw new InvalidOperationException($"action '{action}' is not found");

            if (method.ReturnType != typeof(IRedirecter))
                throw new InvalidOperationException($"action '{action}' is not have '{nameof(IRedirecter)}' return type");

            return (IRedirecter)method.Invoke(this, param);
        }

        public IRedirecter Text(string text)
        {
            return TextRedirecter.DisplayText(text);
        }

        public IRedirecter View(View view)
        {
            return ViewRedirecter.OpenView(view);
        }
    }
}
