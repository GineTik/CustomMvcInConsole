namespace MVC.Redirecters.Interfaces
{
    public interface IRedirecter
    {
        IRedirecter Redirect();

        public static IRedirecter Exit => null;
        public static IRedirecter None => null;
    }
}
