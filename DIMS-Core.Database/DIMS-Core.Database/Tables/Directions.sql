CREATE TABLE [dbo].[Directions]
(
	[DirectionId] INT NOT NULL IDENTITY,
	[Name] NVARCHAR(50) NOT NULL,
	[Description] NVARCHAR(250) NULL

	CONSTRAINT PK_Directions_DirectionId PRIMARY KEY (DirectionId)
)
