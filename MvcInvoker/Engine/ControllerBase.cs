using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcInvoker.Engine
{
    public class ControllerBase
    {
        public void BindRequestModelFromGlobalState( ModelBase requestModel, Dictionary<string, string> requestDictionary )
        {
            
        }

        public virtual string GenerateResponseBody()
        {
            return String.Empty;
        }

        protected ModelBase _requestModel;
        public ModelBase RequestModel { get { return _requestModel; } }
    }
}
