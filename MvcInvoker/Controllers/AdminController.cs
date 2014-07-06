using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvcInvoker.Engine;
using MvcInvoker.RequestModels;
using MvcInvoker.ViewModels;

namespace MvcInvoker.Controllers
{
    public class AdminController : ControllerBase
    {
        public AdminController()
        {
            _requestModel = new AdminRequestModel();
        }

        public override string GenerateResponseBody()
        {
            AdminViewModel vm = new AdminViewModel()
            {
                ToolMode = "Make Some Edits",
                IsAuthenticated = true
            };

            return "<html><head><title>" + vm.ToolMode + "</title></head><body>You " + (vm.IsAuthenticated ? "are" : "aren't") + " Authenticated.</body></html>";
        }
    }
}
