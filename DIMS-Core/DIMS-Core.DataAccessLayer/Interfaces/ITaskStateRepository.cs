using DIMS_Core.Common.Enums;
using DIMS_Core.DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task = System.Threading.Tasks.Task;

namespace DIMS_Core.DataAccessLayer.Interfaces
{
    public interface ITaskStateRepository : IRepository<TaskState>
    {
        Task SetState(int userId, int taskId, TaskStates state);
    }
}
