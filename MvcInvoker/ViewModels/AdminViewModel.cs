using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvcInvoker.Engine;

namespace MvcInvoker.ViewModels
{
    public class AdminViewModel : ViewModelBase
    {
        public string ToolMode { get; set; }
        public bool IsAuthenticated { get; set; }
    }
}
