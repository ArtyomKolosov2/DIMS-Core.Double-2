using DIMS_Core.DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIMS_Core.DataAccessLayer.Repositories
{
    public class VTaskRepository : ReadOnlyRepository<VTask>
    {
        public VTaskRepository(DIMSCoreContext context) : base(context)
        {

        }
    }
}
