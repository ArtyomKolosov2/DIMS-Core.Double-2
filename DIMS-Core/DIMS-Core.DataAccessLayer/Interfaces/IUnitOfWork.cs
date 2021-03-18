using System;
using DIMS_Core.DataAccessLayer.Models;
using ThreadTask = System.Threading.Tasks.Task;

namespace DIMS_Core.DataAccessLayer.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<UserProfile> UserProfileRepository { get; }
        IRepository<Direction> DirectionRepository { get; }
        IRepository<UserTask> UserTaskRepository { get; }
        IRepository<TaskTrack> TaskTrackRepository { get; }
        IRepository<Task> TaskRepository { get; }
        ITaskStateRepository TaskStateRepository { get; }
        IReadOnlyRepository<VUserProfile> VUserProfileRepository { get; }
        IReadOnlyRepository<VUserTask> VUserTaskRepository { get; }
        IReadOnlyRepository<VTask> VTaskRepository { get; }
        IReadOnlyRepository<VUserProgress> VUserProgressRepository { get; }
        IReadOnlyRepository<VUserTrack> VUserTrackRepository { get; }

        ThreadTask SaveChanges();
    }
}