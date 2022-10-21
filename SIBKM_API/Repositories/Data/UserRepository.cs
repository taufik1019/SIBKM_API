using SIBKM_API.Context;
using SIBKM_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIBKM_API.Repositories.Data
{
    public class UserRepository : GeneralRepository<User>
    {
        public UserRepository(MyContext myContext) : base(myContext)
        {

        }
    }
}
