SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE GetStudents 
	@Id int
AS
BEGIN
	SET NOCOUNT ON;

    SELECT people.Id, people.FirstName, people.LastName, student.Fee FROM People people
	JOIN Students student on student.Id = people.Id
	WHERE people.Id = @Id

END
GO
