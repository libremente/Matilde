﻿CREATE FUNCTION [dbo].[MF_TogliApici](@sIn AS VARCHAR(MAX))
RETURNS VARCHAR(MAX)
AS
BEGIN
	DECLARE @sOUT AS VARCHAR(MAX)

	IF ISNULL(@sIn,'') <> ''
		BEGIN
			SET @sOUT=@sIN				
			SET @sOUT=REPLACE(@sOUT, '''''', '''')
			SET @sOUT=REPLACE(@sOUT, '''''', '''')
		END
	ELSE
		BEGIN		
			SET @sOUT=@sIN	
		END	
		
	RETURN @sOUT
END