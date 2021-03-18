using DIMS_Core.DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using ThreadTask = System.Threading.Tasks.Task;

namespace DIMS_Core.DataAccessLayer.Repositories
{
    public class TaskRepository : Repository<Task>
    {
        private readonly DIMSCoreContext _context;

        public TaskRepository(DIMSCoreContext context) : base(context)
        {
            _context = context;
        }

        public override ThreadTask Delete(int id)
        {
            return _context.Database.ExecuteSqlInterpolatedAsync($"EXEC [dbo].[DeleteTask] {id}");
        }
    }
}
