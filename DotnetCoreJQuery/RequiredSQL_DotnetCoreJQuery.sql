--USE DbCRUDDotnetCore

--Student Table
CREATE TABLE Student(
Id int IDENTITY(1,1) NOT NULL CONSTRAINT Student_ID PRIMARY KEY,
FirstName varchar(50) NOT NULL,
LastName varchar(50) NOT NULL,
Email varchar(50) NOT NULL,
Mobile varchar(20) NOT NULL,
Address varchar(220) NOT NULL
)


--Stored Procedure
CREATE PROCEDURE SPAddStudent
(
	@FirstName VARCHAR(50),
	@LastName VARCHAR(50),
	@Email VARCHAR(50),
	@Mobile VARCHAR(50),
	@Address VARCHAR(50)
)
As
Begin
	INSERT into Student (FirstName, LastName, Email, Mobile, Address)
	VALUES(@FirstName,@LastName,@Email,@Mobile,@Address)
End

-- Stored Producre for Update data

CREATE PROCEDURE SPUpdateStudent
(
	@Id INT,
	@FirstName VARCHAR(50),
	@LastName VARCHAR(50),
	@Email VARCHAR(50),
	@Mobile VARCHAR(50),
	@Address VARCHAR(50)
)
As
Begin
	UPDATE Student set FirstName=@FirstName, LastName= @LastName, Email= @Email, Mobile = @Mobile,Address= @Address WHERE Id =@Id
End


--Stored Procudure for delete record from the student

CREATE PROCEDURE SPDeleteStudent
(
	@Id INT
)
As
Begin
	DELETE from Student WHERE Id =@Id
End

--Stored Procudure for get all record from the student

ALTER PROCEDURE SPGetAllStudent
As
Begin
	SELECT * from Student ORDER BY Id DESC
End

--Stored Procudure for get all record from the student

CREATE PROCEDURE SPGetStudentById
(
	@Id INT
)
As
Begin
	SELECT * from Student WHERE Id =@Id
End

	
