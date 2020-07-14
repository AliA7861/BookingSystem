CREATE PROC AddUser
@UserID int,
@Firstname varchar(50),
@Surname varchar(50),
@Email varchar(50),
@Username varchar(40),
@Password varchar(30)
AS
	INSERT INTO UserTBL(UserID,Firstname,Surname,Email,Username,Password)
	VALUES (@UserID,@Firstname,@Surname,@Email,@Username,@Password)