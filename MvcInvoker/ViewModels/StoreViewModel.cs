using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvcInvoker.Engine;

namespace MvcInvoker.ViewModels
{
    public class StoreViewModel : ViewModelBase
    {
        public string ProductName { get; set; }
        public int ProductPrice { get; set; }
    }
}
