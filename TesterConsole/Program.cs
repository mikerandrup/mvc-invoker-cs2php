using System;
using MvcInvoker.Engine;

namespace TesterConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GenerateResponseForPath("about/company/history"));
            Console.WriteLine(GenerateResponseForPath("retail/karaoke4000"));
            Console.WriteLine(GenerateResponseForPath("admin/announcements"));
        }

        static string GenerateResponseForPath(string routePath)
        {
            RouteCollection routeCollection = new RouteCollection();
            RouteBase route = routeCollection.GetRouteForPath(routePath);
            ControllerBase controller = route.CreateController();
            return controller.GenerateResponseBody();
        }
    }
}
