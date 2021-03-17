using DIMS_Core.Common.Enums;
using DIMS_Core.DataAccessLayer.Interfaces;
using DIMS_Core.DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Task = System.Threading.Tasks.Task;

namespace DIMS_Core.DataAccessLayer.Repositories
{
    public class TaskStateRepository : Repository<TaskState>, ITaskStateRepository
    {
        private readonly DIMSCoreContext _context;

        public TaskStateRepository(DIMSCoreContext context) : base(context)
        {
            _context = context;
        }

        public Task SetState(int userId, int taskId, TaskStates state) => state switch
        {
            TaskStates.Active => _context.UserTasks.FromSqlInterpolated($"EXEC [dbo].[SetUserTaskAsSuccess] {userId} {taskId}").ToListAsync(),
            TaskStates.Fail => _context.UserTasks.FromSqlInterpolated($"EXEC [dbo].[SetUserTaskAsFail] {userId} {taskId}").ToListAsync(),
            _ => Task.CompletedTask
        };
    }
}
