using System.Collections.Generic;
using MvcInvoker.Routes;

namespace MvcInvoker.Engine
{
    public class RouteCollection
    {
        public RouteCollection()
        {
            Routes = new List<RouteBase>();
            Routes.Add(new AdminRoute());
            Routes.Add(new StoreRoute());
            Routes.Add(new ContentRoute());
        }

        public RouteBase GetRouteForPath(string path)
        {
            RouteBase matchingRoute = null;
            foreach (RouteBase route in Routes)
            {
                if (route.RouteDoesMatch(path))
                {
                    matchingRoute = route;
                    break;
                }
            }
            return matchingRoute;
        }

        private List<RouteBase> Routes;
    }
}
