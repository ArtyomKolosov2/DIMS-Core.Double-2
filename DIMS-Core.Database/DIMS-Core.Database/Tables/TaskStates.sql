﻿CREATE TABLE [dbo].[TaskStates]
(
	[StateId] INT NOT NULL IDENTITY,
	[StateName] NVARCHAR(50) NOT NULL

	CONSTRAINT PK_StateId PRIMARY KEY (StateId)
)
