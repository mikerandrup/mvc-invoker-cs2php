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
    public class StoreRoute : RouteBase
    {
        public StoreRoute()
        {
            MatchingRegex = new Regex(@"retail\/");
        }

        public override ControllerBase CreateController()
        {
            return new StoreController();
        }
    }
}
