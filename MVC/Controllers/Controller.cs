using MVC.Redirectors.Interfaces;
using MVC.Views;

namespace MVC.Controllers
{
    public class Controller
    {
        public IRedirector InvokeAction(string action, params object[] param)
        {
            if (param == null)
                throw new ArgumentNullException(nameof(param));

            var method = GetType().GetMethod(action, param.Select(o => o.GetType()).ToArray());

            if (method == null)
                throw new InvalidOperationException($"action '{action}' is not found");

            if (method.ReturnType != typeof(IRedirector))
                throw new InvalidOperationException($"action '{action}' is not have 'IRedirector' return type");

            return (IRedirector)method.Invoke(this, param);
        }
    }
}
