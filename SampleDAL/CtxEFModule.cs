using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleDAL
{
    public class CtxEFModule : IHttpModule
    {

        public CtxEFModule()
        {
        }

        public String ModuleName
        {
            get { return "ContextEFModule"; }
        }
        
        public void Init(HttpApplication application)
        {
            application.BeginRequest +=
              (new EventHandler(this.Application_BeginRequest));
            application.EndRequest +=
                (new EventHandler(this.Application_EndRequest));
        }

        private void Application_BeginRequest(Object source, EventArgs e)
        {
            new Repositories.EmployeeRepository().CreateContext();
        }

        private void Application_EndRequest(Object source, EventArgs e)
        {
            new Repositories.EmployeeRepository().DestroyContext();
        }

        public void Dispose()
        {
        }
    }
}