﻿CREATE TABLE [dbo].[UserTasks]
(
	[UserTaskId] INT NOT NULL IDENTITY,
	[TaskId] INT NOT NULL,
	[UserId] INT NOT NULL,
	[StateId] INT NOT NULL

	CONSTRAINT PK_UserTaskId PRIMARY KEY (UserTaskId)
	CONSTRAINT FK_TaskId FOREIGN KEY (TaskId) REFERENCES Tasks(TaskId) ON UPDATE CASCADE ON DELETE CASCADE
	CONSTRAINT FK_UserId FOREIGN KEY (UserId) REFERENCES UserProfiles(UserId) ON UPDATE CASCADE ON DELETE CASCADE
	CONSTRAINT FK_StateId FOREIGN KEY (StateId) REFERENCES TaskStates(StateId) ON UPDATE CASCADE ON DELETE CASCADE

)
