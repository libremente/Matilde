﻿CREATE PROCEDURE [dbo].[MSP_SelMovCartelleInVisione](@xParametri XML)
AS
BEGIN

	
	
				
	DECLARE @sCodRuolo AS VARCHAR(20)
	DECLARE @sCodUtente AS VARCHAR(100)	
	DECLARE @uIDCartellaInVisione AS UNIQUEIDENTIFIER
	DECLARE @uIDCartella AS UNIQUEIDENTIFIER
	
		DECLARE @sGUID AS VARCHAR(Max)
	DECLARE @nTemp AS INTEGER
	DECLARE @bInserisci AS  BIT
	DECLARE @bModifica AS  BIT
	DECLARE @bCancella AS  BIT
	DECLARE @bVisualizza AS  BIT
		
	
			
		SET @sGUID=(SELECT TOP 1 ValoreParametro.IDCartellaInVisione.value('.','VARCHAR(50)')
					  FROM @xParametri.nodes('/Parametri/IDCartellaInVisione') as ValoreParametro(IDCartellaInVisione))
	IF 	ISNULL(@sGUID,'') <> '' SET @uIDCartellaInVisione=CONVERT(UNIQUEIDENTIFIER,	@sGUID)	
		
	SET @sGUID=(SELECT TOP 1 ValoreParametro.IDCartella.value('.','VARCHAR(50)')
					  FROM @xParametri.nodes('/Parametri/IDCartella') as ValoreParametro(IDCartella))
	IF 	ISNULL(@sGUID,'') <> '' SET @uIDCartella=CONVERT(UNIQUEIDENTIFIER,	@sGUID)	
		
	SET @sCodUtente=(SELECT TOP 1 ValoreParametro.CodLogin.value('.','VARCHAR(100)')
					  FROM @xParametri.nodes('/Parametri/TimeStamp/CodLogin') as ValoreParametro(CodLogin))	
	SET @sCodUtente=ISNULL(@sCodUtente,'')

		SET @sCodRuolo=(SELECT TOP 1 ValoreParametro.CodRuolo.value('.','VARCHAR(20)')
					  FROM @xParametri.nodes('/Parametri/TimeStamp/CodRuolo') as ValoreParametro(CodRuolo))
	SET @sCodRuolo=ISNULL(@sCodRuolo,'')
	
	
	SET @nTemp=(SELECT COUNT(*) FROM T_AssRuoliModuli
				WHERE CodModulo='CartellaIV_Inserisci'	
				AND CodRuolo=@sCodRuolo)
	IF @nTemp>=1 
		SET @bInserisci=1
	ELSE
		SET @bInserisci=0	
		
	
		SET @nTemp=(SELECT COUNT(*) FROM T_AssRuoliModuli
				WHERE CodModulo='CartellaIV_Modifica'	
				AND CodRuolo=@sCodRuolo)
	IF @nTemp>=1 
		SET @bModifica=1
	ELSE
		SET @bModifica=0		
			
		SET @nTemp=(SELECT COUNT(*) FROM T_AssRuoliModuli
				WHERE CodModulo='CartellaIV_Cancella'	
				AND CodRuolo=@sCodRuolo)
	IF @nTemp>=1 
		SET @bCancella=1
	ELSE
		SET @bCancella=0	
	
		SET @nTemp=(SELECT COUNT(*) FROM T_AssRuoliModuli
				WHERE CodModulo='CartellaIV_Visualizza'	
				AND CodRuolo=@sCodRuolo)
	IF @nTemp>=1 
		SET @bVisualizza=1
	ELSE
		SET @bVisualizza=0

		IF @uIDCartella IS NOT NULL
		BEGIN
			SELECT 
				M.ID,
				M.IDCartella,
				CONVERT(VARBINARY(MAX),NULL) AS Icona,
				CodRuoloInVisione,
				
										ISNULL(R.Descrizione,CodRuoloInVisione) + CHAR(13) + CHAR(10) +
					
										'Inserito da: ' + ISNULL(LI.Descrizione,'') + 
						CASE 
							WHEN M.DataInserimento IS NOT NULL THEN ' il ' + Convert(VARCHAR(10),M.DataInserimento,105) + ' ' + LEFT(CONVERT(varchar(20),M.DataInserimento,14),5) 		
							ELSE ''
						END	+ 
				    
										   CASE 
							WHEN M.CodUtenteUltimaModifica IS NOT NULL THEN CHAR(13) + CHAR(10) + 'Modificato da: ' + ISNULL(LM.Descrizione,'') 
							ELSE ''
					   END +	
					   
					   CASE 
							WHEN M.DataUltimaModifica IS NOT NULL THEN ' il ' + + Convert(VARCHAR(10),M.DataUltimaModifica,105) + ' ' + LEFT(CONVERT(varchar(20),M.DataUltimaModifica,14),5)
							ELSE ''
					   END +
					
										+ CHAR(13) + CHAR(10) + 
						'(' + 
						CASE	
							WHEN DataInizio <= GETDATE() AND DataFine >= GETDATE() 	THEN SCIV.Descrizione
							ELSE UPPER('Non Attiva')
						END						
						
						+ ')'
			        
				AS Descrizione,
				CASE	
					WHEN DataInizio <= GETDATE() AND DataFine >= GETDATE() 	THEN M.CodStatoCartellaInVisione
					ELSE 'SS'
				END CodStatoCartellaInVisione,
				DataInizio,
				DataFine,
				CONVERT(INTEGER,@bModifica) AS PermessoModifica,				
				CONVERT(INTEGER,@bCancella) AS PermessoCancella
			FROM 
				T_MovCartelleInVisione M
					LEFT JOIN T_Ruoli R
						ON M.CodRuoloInVisione=R.Codice
					LEFT JOIN T_Login LI
						ON M.CodUtenteInserimento=LI.Codice
					LEFT JOIN T_Login LM
						ON M.CodUtenteUltimaModifica=LM.Codice	
					LEFT JOIN T_StatoCartellaInVisione SCIV
						ON M.CodStatoCartellaInVisione=SCIV.Codice	
			WHERE				
				M.IDCartella=ISNULL(@uIDCartella,M.IDCartella) AND				
				CodStatoCartellaInVisione IN ('IC')				END		
	ELSE
		BEGIN
			SELECT M.*, ISNULL(R.Descrizione,'') As DescrRuoloInVisione
			FROM 
				T_MovCartelleInVisione M
					LEFT JOIN T_Ruoli R
						ON M.CodRuoloInVisione=R.Codice
			WHERE ID=@uIDCartellaInVisione
		END	
	
	
	RETURN 0
END