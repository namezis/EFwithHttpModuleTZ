using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace SampleDAL.Repositories
{
    public class EmployeeRepository
    {
        
        public EmployeeRepository()
        {           
        }

        public NorthwindEntities ctx
        {
            get
            {
                return (NorthwindEntities)HttpContext.Current.Items["__EFCONTEXT"];
            }
        }

        public void CreateContext()
        {
            HttpContext.Current.Items["__EFCONTEXT"] = new NorthwindEntities();
        }

        public void DestroyContext()
        {
            ((NorthwindEntities)HttpContext.Current.Items["__EFCONTEXT"]).Dispose();
        }

        public IEnumerable<SampleDAL.Entities.EmployeeShort> GetEmployeesShort()
        {
            var qry = from r in ctx.Employees
                      select new SampleDAL.Entities.EmployeeShort
                      {
                          FirstName = r.FirstName,
                          LastName = r.LastName
                      };
            return qry.ToList();
        }
    }
}
