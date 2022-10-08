using MVC;
using lb1.Controllers;

var application = new ConsoleApplication(typeof(HomeController), "Index");
application.Run();