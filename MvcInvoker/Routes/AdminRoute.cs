using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using MvcInvoker.Controllers;
using MvcInvoker.Engine;

namespace MvcInvoker.Routes
{
    public class AdminRoute : RouteBase
    {
        public AdminRoute()
        {
            MatchingRegex = new Regex(@"admin\/");
        }

        public override ControllerBase CreateController()
        {
            return new AdminController();
        }
    }
}
