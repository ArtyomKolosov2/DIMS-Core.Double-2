CREATE VIEW [dbo].[vTask]
	AS SELECT
	Tasks.TaskId,
	Tasks.[Name],
	Tasks.[Description],
	Tasks.StartDate,
	Tasks.EndDate as DeadlineDate
	
FROM [Tasks]
