using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvcInvoker.Engine;

namespace MvcInvoker.ViewModels
{
    public class ContentViewModel : ViewModelBase
    {
        public string PageTitle { get; set; }
        public string PageContent { get; set; }
    }
}
