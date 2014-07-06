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
    public class ContentRoute : RouteBase
    {
        public ContentRoute()
        {
            MatchingRegex = new Regex(".*");
        }

        public override ControllerBase CreateController()
        {
            return new ContentController();
        }

    }
}
