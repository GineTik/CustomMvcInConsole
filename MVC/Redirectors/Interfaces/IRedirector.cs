namespace MVC.Redirectors.Interfaces
{
    public interface IRedirector
    {
        IRedirector Redirect();

        public static IRedirector Exit => null;
    }
}
