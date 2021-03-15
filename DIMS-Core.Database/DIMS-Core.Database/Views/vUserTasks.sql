CREATE VIEW [dbo].[vUserTasks]
	AS SELECT
	UserTasks.UserId,
	Tasks.TaskId,
	Tasks.[Name] as TaskName,
	Tasks.[Description],
	Tasks.StartDate,
	Tasks.EndDate as DeadlineDate,
	TaskStates.StateName as [State]

FROM [UserTasks] 
	INNER JOIN [Tasks] ON Tasks.TaskId = UserTasks.TaskId
	INNER JOIN [TaskStates] ON TaskStates.StateId = UserTasks.StateId
