﻿CREATE PROCEDURE [dbo].[MSP_SelStatoOrdine](@xParametri AS XML )
AS
BEGIN
	

				 	
	DECLARE @bDatiEstesi AS Bit			
											
	SET @bDatiEstesi=(SELECT TOP 1 ValoreParametro.DatiEstesi.value('.','bit')
					  FROM @xParametri.nodes('/Parametri/DatiEstesi') as ValoreParametro(DatiEstesi))											
	
				SELECT
		Codice,
		Descrizione,
		CASE 
			WHEN  ISNULL(@bDatiEstesi,0)=0 THEN NULL
			ELSE Icona
		END AS  Icona,
		Colore						 
	FROM T_StatoOrdine

	
	RETURN 0
END