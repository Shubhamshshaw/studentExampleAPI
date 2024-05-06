In Database use SQL server, Where you need to create a DB named "Student"
Then you need to execute the following script:

USE [Student]
GO

/****** Object:  Table [dbo].[class1]    Script Date: 06-05-2024 18:19:25 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[class1]') AND type in (N'U'))
DROP TABLE [dbo].[class1]
GO

/****** Object:  Table [dbo].[class1]    Script Date: 06-05-2024 18:19:25 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[class1](
	[id] [int] NOT NULL,
	[RollNo] [int] NOT NULL,
	[Name] [varchar](50) NOT NULL
) ON [PRIMARY]
GO

Create database Student;


Create PROCEDURE GetAllStudents
/*************
Created by: Shubham Shaw
Created at: 17:40 06-05-2024
Reason: to get all records from table Class1
*************/
AS
BEGIN
    SELECT * FROM Class1;
END;

--exec GetAllStudents
