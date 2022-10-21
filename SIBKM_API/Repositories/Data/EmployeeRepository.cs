using SIBKM_API.Context;
using SIBKM_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIBKM_API.Repositories.Data
{
    public class EmployeeRepository : GeneralRepository<Employee>
    {
        public EmployeeRepository(MyContext myContext) : base(myContext)
        {

        }
    }
    }
