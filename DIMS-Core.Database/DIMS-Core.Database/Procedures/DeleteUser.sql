CREATE PROCEDURE [dbo].[DeleteUser]
	@UserId INT
AS
	DELETE [dbo].[UserProfiles]
	WHERE UserId = @UserId
