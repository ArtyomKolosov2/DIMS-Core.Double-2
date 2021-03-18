using DIMS_Core.DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIMS_Core.DataAccessLayer.Repositories
{
    public class VUserTrackRepository : ReadOnlyRepository<VUserTrack>
    {
        public VUserTrackRepository(DIMSCoreContext context) : base(context)
        {

        }
    }
}
