CREATE VIEW [dbo].[vUserProgress]
	AS SELECT
	UserTasks.UserId,
	UserTasks.TaskId,
	TaskTracks.TaskTrackId,
	(UserProfiles.FirstName + ' ' + UserProfiles.LastName) AS UserName,
	Tasks.[Name] as TaskName,
	TaskTracks.TrackNote,
	TaskTracks.TrackDate

FROM [UserTasks] 
	INNER JOIN [TaskTracks] ON TaskTracks.UserTaskId = UserTasks.UserTaskId
	INNER JOIN [Tasks] ON UserTasks.TaskId = Tasks.TaskId
	INNER JOIN [UserProfiles] ON UserTasks.UserId = UserProfiles.UserId
