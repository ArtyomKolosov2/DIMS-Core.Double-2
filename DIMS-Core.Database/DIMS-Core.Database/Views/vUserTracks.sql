CREATE VIEW [dbo].[vUserTrack]
	AS SELECT
	UserTasks.UserId,
	UserTasks.TaskId,
	TaskTracks.TaskTrackId,
	Tasks.[Name] as TaskName,
	TaskTracks.TrackNote,
	TaskTracks.TrackDate

FROM [UserTasks] 
	INNER JOIN [TaskTracks] ON TaskTracks.UserTaskId = UserTasks.UserTaskId
	INNER JOIN [Tasks] ON UserTasks.TaskId = Tasks.TaskId
	
