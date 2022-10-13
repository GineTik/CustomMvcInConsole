using MVC.Controllers;
using MVC.Factories;
using MVC.Redirecters.Interfaces;

namespace MVC.Redirecters.Implements
{
    public class ActionRedirecter : IRedirecter
    {
        public Controller Controller { get; set; }
        public string ActionName { get; set; }
        public object[] Params { get; set; }

        private static ActionRedirecter _lastActionRedirector;

        public ActionRedirecter(Type ControllerType, string actionName, object[] param = null)
        {
            Controller = (Controller)new ObjectReflectionFactory().Create(ControllerType);
            ActionName = actionName;
            Params = param ?? new object[0];
        }

        public IRedirecter Redirect()
        {
            _lastActionRedirector = this;
            IRedirecter redirector = Controller.InvokeAction(ActionName, Params);
            return redirector;
        }

        public static IRedirecter ToAction<TController>(string actionName)
            where TController : Controller => new ActionRedirecter(typeof(TController), actionName);

        public static IRedirecter ToAction<TController>(string actionName, params object[] param)
            where TController : Controller => new ActionRedirecter(typeof(TController), actionName, param);

        public static IRedirecter ToAction(Type type, string actionName) => new ActionRedirecter(type, actionName);

        public static IRedirecter ToLastAction => _lastActionRedirector;
    }
}
