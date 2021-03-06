USE [testcapstone]
GO
/****** Object:  StoredProcedure [dbo].[GetAllRequests]    Script Date: 2/4/2020 10:07:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER Procedure [dbo].[GetAllRequests]
AS
BEGIN
	SET NOCOUNT ON
	DECLARE cur cursor for
		SELECT distinct r.Id From Requests r
					join RequestLines rl
						on r.id = rl.RequestId;
	DECLARE @id int;
	OPEN cur;

	FETCH NEXT From cur Into @id;
	WHILE @@FETCH_STATUS = 0
	BEGIN
		-- other statements go here
		PRINT 'Request id is ' + CAST(@id as nvarchar(10));
		EXEC UpdateRequestTotal @id;
		FETCH NEXT From cur Into @id;
	END

	CLOSE cur;
	DEALLOCATE cur;
END
Go
EXEC GetAllRequests;
go
Select * from Requests;
go