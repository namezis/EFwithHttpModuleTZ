using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EFwithHttpModuleTest1
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            gvEmployeeShort.DataSource = new SampleDAL.Repositories.EmployeeRepository().GetEmployeesShort();
            gvEmployeeShort.DataBind();

            gvEmployeeLong.DataSource = new SampleDAL.Repositories.EmployeeRepository().GetEmployeesLong();
            gvEmployeeLong.DataBind();
        }
    }
}