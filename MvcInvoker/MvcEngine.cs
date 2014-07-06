using Lang.Php;
using MvcInvoker.Engine;
 
namespace MvcInvoker
{ 
    [Page("router")]
    public class MvcEngine : PhpDummy
    {
        public static void PhpMain()
        {
            string routePath = "admin/announcements"; // Get this from query value passed in from apache

            RouteCollection routeCollection = new RouteCollection();
            RouteBase route = routeCollection.GetRouteForPath(routePath);
            ControllerBase controller = route.CreateController();

            echo(controller.GenerateResponseBody());
        }
    }
}
