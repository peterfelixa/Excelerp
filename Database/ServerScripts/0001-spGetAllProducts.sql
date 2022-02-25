IF EXISTS (SELECT
			*
		FROM sys.sysobjects AS S
		WHERE S.id = OBJECT_ID('spGetAllProducts')
		AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
	DROP PROCEDURE spGetAllProducts
GO

CREATE PROCEDURE spGetAllProducts
AS
	(
	SELECT
		[Id] = product_id
	   ,[Name] = P.product_name
	   ,[ProductDescription] = P.product_description
	   ,[ProductLogo] = P.product_logo
	   ,[CreatedBy] = P.created_by
	   ,[RowCreatedDate] = P.row_created_date
	   ,[RowUpdatedDate] = P.row_updated_date
	FROM products AS P
	)