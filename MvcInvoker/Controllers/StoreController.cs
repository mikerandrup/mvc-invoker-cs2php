using MvcInvoker.Engine;
using MvcInvoker.RequestModels;
using MvcInvoker.ViewModels;

namespace MvcInvoker.Controllers
{
    public class StoreController : ControllerBase
    {
        public StoreController()
        {
            _requestModel = new StoreRequestModel();
        }

        public override string GenerateResponseBody()
        {
            StoreViewModel vm = new StoreViewModel()
            {
                ProductName = "Karaoke Machine",
                ProductPrice = 500
            };

            return "<html><head><title>" + vm.ProductName + "</title></head><body>$" + vm.ProductPrice + "</body></html>";
        }
    }
}
