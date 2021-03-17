using System;
using DIMS_Core.DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;
using Task = System.Threading.Tasks.Task;

namespace DIMS_Core.DataAccessLayer.Repositories
{
    public class UserProfileRepository : Repository<UserProfile>
    {
        private readonly DIMSCoreContext _context;

        public UserProfileRepository(DIMSCoreContext context) : base(context)
        {
            _context = context;
        }

        public override Task Delete(int id)
        {
            return _context.Database.ExecuteSqlInterpolatedAsync($"EXEC [dbo].[DeleteUser] {id}");
        }
    }
}