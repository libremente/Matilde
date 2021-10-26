﻿
CREATE PROCEDURE [dbo].[MSP_AggMovParametriVitali](@xParametri XML)
AS
BEGIN
		
	
			

								
		DECLARE @uIDParametroVitale AS UNIQUEIDENTIFIER
	DECLARE @uIDEpisodio AS UNIQUEIDENTIFIER	
	DECLARE @uIDTrasferimento AS UNIQUEIDENTIFIER	
		
	DECLARE @dDataEvento AS DATETIME	
	DECLARE @dDataEventoUTC AS DATETIME
	
	DECLARE @sCodTipoParametroVitale AS VARCHAR(20)
	DECLARE @sCodStatoParametroVitale AS VARCHAR(20)
	
	DECLARE @sValoriFUT AS VARCHAR(900)
		
	DECLARE @sCodUtenteUltimaModifica AS VARCHAR(100)					
		
		DECLARE @sGUID AS VARCHAR(50)	
	DECLARE @sDataTmp AS VARCHAR(20)	
	DECLARE @sTmp AS VARCHAR(MAX)
	DECLARE @xValoriGrafici XML
	DECLARE @xValoriFUT XML

	DECLARE @txtValoriGrafici VARCHAR(MAX)	
	DECLARE @txtValoriFUT VARCHAR(MAX)	
		
	DECLARE @sSQL AS VARCHAR(MAX)
	DECLARE @sSET AS VARCHAR(MAX)
	DECLARE @sWHERE AS VARCHAR(MAX)
	
	    DECLARE @xTimeStampBase AS XML	
	DECLARE @xTimeStamp AS XML	
			
		DECLARE @xSchedaMovimento AS XML	
	
		DECLARE @xLogPrima AS XML
	DECLARE @xLogDopo AS XML
	DECLARE @xTemp AS XML
	DECLARE @xParLog AS XML


		SET @sSQL='UPDATE T_MovParametriVitali ' + CHAR(13) + CHAR(10) +
			  'SET '  				  						
	
	SET @sSET =''		


		IF @xParametri.exist('/Parametri/IDParametroVitale')=1
		BEGIN
			SET @sGUID=(SELECT TOP 1 ValoreParametro.IDParametroVitale.value('.','VARCHAR(50)')
							  FROM @xParametri.nodes('/Parametri/IDParametroVitale') as ValoreParametro(IDParametroVitale))
			IF 	ISNULL(@sGUID,'') <> '' 
					SET @uIDParametroVitale=CONVERT(UNIQUEIDENTIFIER,	@sGUID)	
					END
					
		IF @xParametri.exist('/Parametri/DataEvento')=1
		BEGIN			
			SET @sDataTmp=(SELECT TOP 1 ValoreParametro.DataEvento.value('.','VARCHAR(20)')
							  FROM @xParametri.nodes('/Parametri/DataEvento') as ValoreParametro(DataEvento))					  
			SET @sDataTmp=ISNULL(@sDataTmp,'')
			
			IF @sDataTmp<> '' 
				BEGIN			
										SET @sDataTmp= SUBSTRING(@sDataTmp,4,2) + '-' 
								+ LEFT(@sDataTmp,2) + '-' +
								+ SUBSTRING(@sDataTmp,7,4) +
								' ' + RIGHT(@sDataTmp,5)
					IF ISDATE(@sDataTmp)=1
						SET	@dDataEvento=CONVERT(DATETIME,@sDataTmp,120)						
					ELSE
						SET	@dDataEvento =NULL			
				END
			IF @dDataEvento IS NOT NULL
				SET	@sSET= @sSET + ',DataEvento=CONVERT(DateTime,''' + CONVERT(VARCHAR(20),@dDataEvento,120) + ''',120)' + CHAR(13) + CHAR(10)		 
			ELSE	
				SET	@sSET= @sSET + ',DataEvento=NULL' + CHAR(13) + CHAR(10)		 
		END	
		
		
		IF @xParametri.exist('/Parametri/DataEventoUTC')=1
	BEGIN	
		SET @sDataTmp=(SELECT TOP 1 ValoreParametro.DataEventoUTC.value('.','VARCHAR(20)')
					  FROM @xParametri.nodes('/Parametri/DataEventoUTC') as ValoreParametro(DataEventoUTC))					  
		SET @sDataTmp=ISNULL(@sDataTmp,'')
	
		IF @sDataTmp<> '' 
		BEGIN			
						SET @sDataTmp= SUBSTRING(@sDataTmp,4,2) + '-' 
						+ LEFT(@sDataTmp,2) + '-' +
						+ SUBSTRING(@sDataTmp,7,4) +
						' ' + RIGHT(@sDataTmp,5)
			IF ISDATE(@sDataTmp)=1
				SET	@dDataEventoUTC=CONVERT(DATETIME,@sDataTmp,120)						
			ELSE
				SET	@dDataEventoUTC =NULL			
		END
		
		IF @dDataEventoUTC IS NOT NULL		
			SET	@sSET= @sSET + ',DataEventoUTC=CONVERT(DateTime,''' + CONVERT(VARCHAR(20),@dDataEventoUTC,120) + ''',120)' + CHAR(13) + CHAR(10)		
		ELSE
			SET	@sSET= @sSET + ',DataEventoUTC=NULL ' + CHAR(13) + CHAR(10)		
	END	
		
		IF @xParametri.exist('/Parametri/IDEpisodio')=1
		BEGIN
			SET @sGUID=(SELECT TOP 1 ValoreParametro.IDEpisodio.value('.','VARCHAR(50)')
							  FROM @xParametri.nodes('/Parametri/IDEpisodio') as ValoreParametro(IDEpisodio))
							  
				IF 	ISNULL(@sGUID,'') <> '' 
				BEGIN
					SET @uIDEpisodio=CONVERT(UNIQUEIDENTIFIER,	@sGUID)		
					SET	@sSET= @sSET + ',IDEpisodio=''' + convert(VARCHAR(50),@uIDEpisodio) + ''''	+ CHAR(13) + CHAR(10)	
				END
				ELSE
					SET	@sSET= @sSET + ',IDEpisodio=NULL'	+ CHAR(13) + CHAR(10)									  		
		END			
			
		IF @xParametri.exist('/Parametri/IDTrasferimento')=1
		BEGIN
			SET @sGUID=(SELECT TOP 1 ValoreParametro.IDTrasferimento.value('.','VARCHAR(50)')
							  FROM @xParametri.nodes('/Parametri/IDTrasferimento') as ValoreParametro(IDTrasferimento))
							  
				IF 	ISNULL(@sGUID,'') <> '' 
				BEGIN
					SET @uIDTrasferimento=CONVERT(UNIQUEIDENTIFIER,	@sGUID)		
					SET	@sSET= @sSET + ',IDTrasferimento=''' + convert(VARCHAR(50),@uIDTrasferimento) + ''''	+ CHAR(13) + CHAR(10)	
				END
				ELSE
					SET	@sSET= @sSET + ',IDTrasferimento=NULL'	+ CHAR(13) + CHAR(10)									  		
		END		
		
		IF @xParametri.exist('/Parametri/CodTipoParametroVitale')=1
	BEGIN
		SET @sCodTipoParametroVitale=(SELECT TOP 1 ValoreParametro.CodTipoParametroVitale.value('.','VARCHAR(20)')
					  FROM @xParametri.nodes('/Parametri/CodTipoParametroVitale') as ValoreParametro(CodTipoParametroVitale))	
					  
		IF @sCodTipoParametroVitale <> ''
				SET	@sSET= @sSET + ',CodTipoParametroVitale=''' + @sCodTipoParametroVitale +''''	+ CHAR(13) + CHAR(10)				
			ELSE
				SET	@sSET= @sSET + ',CodTipoParametroVitale=NULL'	+ CHAR(13) + CHAR(10)		
	END	
	
	
		IF @xParametri.exist('/Parametri/CodStatoParametroVitale')=1
	BEGIN
		SET @sCodStatoParametroVitale=(SELECT TOP 1 ValoreParametro.CodStatoParametroVitale.value('.','VARCHAR(20)')
					  FROM @xParametri.nodes('/Parametri/CodStatoParametroVitale') as ValoreParametro(CodStatoParametroVitale))	
					  
		IF @sCodStatoParametroVitale <> ''
				SET	@sSET= @sSET + ',CodStatoParametroVitale=''' + @sCodStatoParametroVitale +''''	+ CHAR(13) + CHAR(10)				
			ELSE
				SET	@sSET= @sSET + ',CodStatoParametroVitale=NULL'	+ CHAR(13) + CHAR(10)		
	END	
	
										 
		IF @xParametri.exist('/Parametri/ValoriFUT')=1
	BEGIN
						SET @xValoriFUT=(SELECT TOP 1 ValoriFUT.TS.query('.')
							 FROM @xParametri.nodes('/Parametri/ValoriFUT/ValoriPVT') as ValoriFUT(TS))
							 
			SET @txtValoriFUT= CONVERT(VARCHAR(MAX), @xValoriFUT)
						
			IF ISNULL(@txtValoriFUT,'') <> ''
				SET	@sSET= @sSET + ',ValoriFUT=CONVERT(XML, CONVERT(NVARCHAR(MAX), ''' + @txtValoriFUT + '''))'

	END				
		
		IF @xParametri.exist('/Parametri/ValoriGrafici')=1
	BEGIN

		    SET @xValoriGrafici=(SELECT TOP 1 ValoriGrafici.TS.query('.')
							 FROM @xParametri.nodes('/Parametri/ValoriGrafici/ValoriPVT') as ValoriGrafici(TS))


			SET @txtValoriGrafici= CONVERT(VARCHAR(MAX), @xValoriGrafici)
			IF ISNULL(@txtValoriGrafici,'') <> ''
				SET	@sSET= @sSET + ',ValoriGrafici=CONVERT(XML, CONVERT(NVARCHAR(MAX), ''' + @txtValoriGrafici + '''))'
	END			 
						  
		SET @sCodUtenteUltimaModifica=(SELECT TOP 1 ValoreParametro.CodUtenteUltimaModifica.value('.','VARCHAR(100)')
					  FROM @xParametri.nodes('/Parametri/TimeStamp/CodLogin') as ValoreParametro(CodUtenteUltimaModifica))	
	SET @sCodUtenteUltimaModifica=ISNULL(@sCodUtenteUltimaModifica,'')
	
	IF @sCodUtenteUltimaModifica <> ''
		SET	@sSET= @sSET + ',CodUtenteUltimaModifica=''' + @sCodUtenteUltimaModifica + '''' + CHAR(13) + CHAR(10)		
	ELSE
		SET	@sSET= @sSET + ',CodUtenteUltimaModifica=NULL' + CHAR(13) + CHAR(10)		
	
		SET	@sSET= @sSET + ',DataUltimaModifica=getdate() ' + CHAR(13) + CHAR(10)	
		
		SET	@sSET= @sSET + ',DataUltimaModificaUTC=getUTCdate() ' + CHAR(13) + CHAR(10)	
	
	    SET @xTimeStamp=(SELECT TOP 1 ValoreParametro.TS.query('.')
					  FROM @xParametri.nodes('/Parametri/TimeStamp') as ValoreParametro(TS))
	
		SET @xSchedaMovimento=(SELECT TOP 1 ValoreParametro.TS.query('.')
					  FROM @xParametri.nodes('/Parametri/SchedaMovimento') as ValoreParametro(TS))
	
						
					
	
									

		IF LEFT(@sSET,1)=',' 
		SET @sSET=RIGHT(@sSET,LEN(@sSET)-1)
	
	IF @sSET <> ''		
		BEGIN
						
						SET @sWHERE =' WHERE ID=''' + convert(varchar(50),@uIDParametroVitale) +''''
				
						SET @sSQL=	ISNULL(@sSQL,'') + CHAR(13) + CHAR(10) + 
						ISNULL(@sSET,'') + CHAR(13) + CHAR(10) + 
						ISNULL(@sWHERE,'')			
												
			PRINT @sSQL									
															SET @xTimeStamp.modify('delete (/TimeStamp/IDEntita)[1]') 
					
			SET @xTimeStamp.modify('insert <IDEntita>{sql:variable("@uIDParametroVitale")}</IDEntita> into (/TimeStamp)[1]')
			
						SET @xTimeStampBase=@xTimeStamp
				
			SET @xTimeStamp=CONVERT(XML,
								'<Parametri>' + CONVERT(varchar(max),@xTimeStamp) +
								'</Parametri>')		
			
												
			SET @xParLog=CONVERT(XML,'<Parametri><LogPrima/><LogDopo/></Parametri>')										
			
			SET @xLogPrima=Convert(XML,'<DataSet></DataSet>')														
			
			SET @xTemp=
				(SELECT * FROM 
					(SELECT
						 *
					 FROM T_MovParametriVitali
					 WHERE ID=@uIDParametroVitale										) AS [Table]
				FOR XML AUTO, ELEMENTS)

			SET @xLogPrima.modify('insert sql:variable("@xTemp") as first into (/DataSet)[1]')
																		
			SET @xParLog.modify('insert sql:variable("@xLogPrima") as first into (/Parametri/LogPrima)[1]')
				
												
			BEGIN TRANSACTION
												EXEC (@sSQL)
								
			IF @@ERROR=0 AND @@ROWCOUNT > 0
				BEGIN						
					EXEC MSP_InsMovTimeStamp @xTimeStamp		
				END	
			IF @@ERROR = 0
				BEGIN
					COMMIT TRANSACTION
					
				
																				
					SET @xLogDopo=Convert(XML,'<DataSet></DataSet>')				
					
					SET @xTemp=
						(SELECT * FROM 
							(SELECT	*
							 FROM T_MovParametriVitali
							 WHERE ID=@uIDParametroVitale												) AS [Table]
						FOR XML AUTO, ELEMENTS)

					SET @xLogDopo.modify('insert sql:variable("@xTemp") as first into (/DataSet)[1]')																											
					SET @xParLog.modify('insert sql:variable("@xLogDopo") as first into (/Parametri/LogDopo)[1]')
					
										SET @xParLog.modify('insert sql:variable("@xTimeStampBase") as last into (/Parametri)[1]')
				
										SET @xParLog.modify('insert sql:variable("@xSchedaMovimento") as last into (/Parametri/LogDopo/DataSet)[1]')

					
										EXEC MSP_InsMovLog @xParLog
									END	
			ELSE
				BEGIN
					ROLLBACK TRANSACTION	
									END	 
		END														
	
	RETURN 0
END