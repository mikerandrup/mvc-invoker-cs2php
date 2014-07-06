using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MvcInvoker.Engine
{
    public class RouteBase
    {
        // override on derived Routes
        public virtual ControllerBase CreateController()
        {
            return new ControllerBase();
        }

        protected Regex MatchingRegex;
        public bool RouteDoesMatch(string requestedPath) 
        {
            if (MatchingRegex == null)
            {
                return false;
            }
            else
            {
                return MatchingRegex.IsMatch(requestedPath);
            }
        }


    }
}
