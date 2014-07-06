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
    public class ContentController : ControllerBase
    {
        public ContentController()
        {
            _requestModel = new ContentRequestModel();
        }

        public override string GenerateResponseBody()
        {
            ContentViewModel vm = BuildViewModelFromDatabase(); 

            // Obviously temporary, figure out way to create view markup that can be bound to vm

            return "<html><head><title>" + vm.PageTitle + "</title></head><body>" + vm.PageContent + "</body></html>";
        }

        private ContentViewModel BuildViewModelFromDatabase()
        {
            // run your query against the content table

            ContentViewModel vm = new ContentViewModel()
            {
                PageTitle = "Page Title From the DB",
                PageContent = "Content that was just loaded from the DB."
            };

            return vm;
        }

    }
}
