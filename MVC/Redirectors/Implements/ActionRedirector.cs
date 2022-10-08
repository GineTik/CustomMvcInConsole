using MVC.Controllers;
using MVC.Factories;
using MVC.Redirectors.Interfaces;

namespace MVC.Redirectors.Implements
{
    public class ActionRedirector : IRedirector
    {
        public Controller Controller { get; set; }
        public string ActionName { get; set; }
        public object[] Params { get; set; }

        private static ActionRedirector _lastActionRedirector;

        public ActionRedirector(Type ControllerType, string actionName, object[] param = null)
        {
            Controller = (Controller)new ObjectReflectionFactory().Create(ControllerType);
            ActionName = actionName;
            Params = param ?? new object[0];
        }

        public IRedirector Redirect()
        {
            _lastActionRedirector = this;
            IRedirector redirector = Controller.InvokeAction(ActionName, Params);
            return redirector;
        }

        public static IRedirector ToAction<TController>(string actionName)
            where TController : Controller => new ActionRedirector(typeof(TController), actionName);

        public static IRedirector ToAction<TController>(string actionName, params object[] param)
            where TController : Controller => new ActionRedirector(typeof(TController), actionName, param);

        public static IRedirector ToAction(Type type, string actionName) => new ActionRedirector(type, actionName);

        public static IRedirector LastAction => _lastActionRedirector;
    }
}
