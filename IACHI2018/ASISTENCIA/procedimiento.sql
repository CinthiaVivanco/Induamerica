
IF EXISTS(SELECT 1 FROM sys.procedures WHERE Name = 'pr_ListadoAsisxID')
BEGIN
    DROP PROCEDURE dbo.pr_ListadoAsisxID
END
GO

IF EXISTS(SELECT 1 FROM sys.procedures WHERE Name = 'pr_LeerxNroDoc')
BEGIN
    DROP PROCEDURE dbo.pr_LeerxNroDoc
END
GO

IF EXISTS(SELECT 1 FROM sys.procedures WHERE Name = 'pr_LeerDnixId')
BEGIN
    DROP PROCEDURE dbo.pr_LeerDnixId
END
GO

IF EXISTS(SELECT 1 FROM sys.procedures WHERE Name = 'pr_consultar_personal_huella')
BEGIN
    DROP PROCEDURE dbo.pr_consultar_personal_huella
END
GO

IF EXISTS(SELECT 1 FROM sys.procedures WHERE Name = 'pr_iAsistencia')
BEGIN
    DROP PROCEDURE dbo.pr_iAsistencia
END
GO

IF EXISTS(SELECT 1 FROM sys.procedures WHERE Name = 'ValidarAsistencia')
BEGIN
    DROP PROCEDURE dbo.ValidarAsistencia
END
GO
----------------------------------------------------------------------------------------------------------------------------------------------------

CREATE PROC  pr_ListadoAsisxID     
@id char(8)
as       
select alias as Nombre,Hora as Hora,estadoaviso as Estado from asistenciadiarias
where fecha = CONVERT(VARCHAR(10), getdate(), 126)
order by fechatime desc
GO


CREATE PROC  pr_LeerxNroDoc     
@dni char(8)
as       
SELECT u.id,u.dni,u.apellidopaterno,u.apellidomaterno  ,u.nombres,
 isnull(U.template,'') Template,isnull(U.template10,'') as  Template10 ,isnull(U.huella_foto,'') as huella_foto,isnull(U.MAR_DNI,0) as  MAR_DNI,isnull(U.MAR_HUELLA,0) as MAR_HUELLA
 FROM trabajadores u 
 where u.dni=@dni
GO


CREATE PROC  pr_LeerDnixId     
@id char(8)
as      
select id as ID, dni as DNI,  
  ISNULL(Template,'') AS 'Template',      
  ISNULL(Template10,'') AS 'Template10',
  isnull(U.MAR_DNI,0) as  MAR_DNI, isnull(U.MAR_HUELLA,0) as MAR_HUELLA   
from trabajadores U 
where U.dni = @id
GO


CREATE PROC  pr_consultar_personal_huella     
as      
select dni,      
  ISNULL(Template,'') AS 'Template',      
  ISNULL(Template10,'') AS 'Template10'      
from trabajadores     
where ISNULL(Template,'')!=''  
GO


-- exec pr_iAsistencia 'SLCHICEN000000000001','lumi','lu'
CREATE PROCEDURE pr_iAsistencia(     
	@idasistenca varchar(20),  
	@variableenviar varchar(5) = '',
	@prefijo varchar(2) = '',
	@estadoaviso varchar(20) = ''
)    

AS    
     
declare @hora varchar(5) = ''
declare @sql varchar(MAX) = ''
declare @cpmhorario char(6) = ''
declare @cantidad int = 0
declare @cant varchar(10) = ''
declare @idtrabajador varchar(20) = ''
declare @nombrecompleto varchar(200) = '' 

set @hora = LEFT(CONVERT(time, SYSDATETIME()) ,5)
set @cpmhorario = @prefijo+'cant'

set @idtrabajador = (select top 1 trabajador_id from asistenciatrabajadores where id = @idasistenca)
set @nombrecompleto = (select top 1 nombres+' '+apellidopaterno+' '+apellidomaterno from trabajadores where id = @idtrabajador)


set  @sql = 'select '+@cpmhorario+' from asistenciatrabajadores  where id = '+ CHAR(39) + @idasistenca + CHAR(39)
DECLARE @t TABLE(resultado int)
INSERT INTO @t 
EXEC(@sql) 
SELECT @cantidad=resultado  FROM @t
set @cantidad = @cantidad + 1
set @cant = @cantidad

set  @sql = 'update asistenciatrabajadores set '+@cpmhorario+' = ' +  @cant + ' , '+@variableenviar+' = '+ CHAR(39) + @hora + CHAR(39)+ ' where id = '+ CHAR(39) + @idasistenca + CHAR(39)	 
EXEC(@sql) 

insert into asistenciadiarias (trabajador_id,alias,hora,fecha,fechatime,estadoaviso)
values(@idtrabajador,@nombrecompleto,@hora,CONVERT(VARCHAR(10), getdate(), 126),getdate(),@estadoaviso)
GO

-- exec ValidarAsistencia '70251035'
CREATE PROC  ValidarAsistencia
@dni char(8)
as
declare @idtrabajador varchar(20) = ''  
declare @idasistenciatrabajador varchar(20) = ''
declare @cantidadasistenciamarcados int=0
declare @cantidadasistenciapormarcar int=0

declare @prefijo char(2) = ''
declare @phorario char(3) = ''  
declare @cpmhorario char(6) = ''
declare @cmhorario char(10) = ''
declare @qmarcacion varchar(5) = ''
 
declare @diasemana varchar(20) = ''
declare @idsemana varchar(20) = ''
declare @tienehorario int=0
declare @nombresemana varchar(20)
declare @nombrecompleto varchar(200) = '' 
declare @sql varchar(MAX) = '' 
declare @mensaje varchar(MAX) = ''
declare @sw int=0
declare @color int=0
declare @estadoaviso varchar(20) = ''
declare @fecha smalldatetime  

declare @m1 char(5) = ''
declare @m2 char(5) = ''
declare @m3 char(5) = ''
declare @m4 char(5) = ''
declare @variableenviar varchar(5) = ''
  

set @fecha=GETDATE() 
set @idtrabajador = (select top 1 id from trabajadores where dni = @dni)
set @nombrecompleto = (select top 1 nombres+' '+apellidopaterno+' '+apellidomaterno from trabajadores where dni = @dni)

set @diasemana = CAST(convert(date, dateadd(minute,-10,SYSDATETIME())) AS varchar(20)) 
set @idsemana = (select top 1 Id from semanas where fechainicio<= @diasemana and fechafin>=@diasemana)

SET LANGUAGE Español;
set @nombresemana = DATENAME(dw, @diasemana)
set @nombresemana = REPLACE(@nombresemana,'é','e')
set @nombresemana = REPLACE(@nombresemana,'á','a')
IF @nombresemana = 'Lunes'
	BEGIN
		set @prefijo = 'lu'
	END
ELSE 
	IF @nombresemana = 'Martes'
		BEGIN
			set @prefijo = 'ma'
		END
	ELSE
		IF @nombresemana = 'Miercoles'
			BEGIN
				set @prefijo = 'mi'
			END
		ELSE
			IF @nombresemana = 'Jueves'
				BEGIN
					set @prefijo = 'ju'
				END
			ELSE
				IF @nombresemana = 'Viernes'
					BEGIN
						set @prefijo = 'vi'
					END
				ELSE
					IF @nombresemana = 'Sabado'
						BEGIN
							set @prefijo = 'sa'
						END
					ELSE
						BEGIN
							set @prefijo = 'do'
						END

set @phorario = @prefijo+'h'

/******************** Tiene Horario ***********************/

set  @sql = 'select count(*) from horariotrabajadores where '+@phorario+' = 1 and trabajador_id = '+  CHAR(39) + @idtrabajador + CHAR(39) +' and semana_id = '+ CHAR(39) + @idsemana + CHAR(39)
DECLARE @t TABLE(resultado int)
INSERT INTO @t 
EXEC(@sql) 
SELECT @tienehorario=resultado FROM @t


IF @tienehorario = 0
	BEGIN
		set @mensaje = 'No tienes Horario '+@nombrecompleto
		set @sw = 1
	END
ELSE
	BEGIN

		set @idasistenciatrabajador = (select top 1 id from asistenciatrabajadores where trabajador_id = @idtrabajador and semana_id = @idsemana)
		
		set @cpmhorario = @prefijo+'cant'
		set @cmhorario	= @prefijo+'cantmarc'

		/**** cantidad que esta marcando ****/
		set  @sql = 'select top 1 '+@cpmhorario+' from asistenciatrabajadores where id = '+CHAR(39) + @idasistenciatrabajador + CHAR(39)
			
		INSERT INTO @t 
		EXEC(@sql) 
		SELECT @cantidadasistenciamarcados=resultado FROM @t

		/**** cantidad que deberia marcar ****/
		set  @sql = 'select top 1 '+@cmhorario+' from asistenciatrabajadores where id = '+CHAR(39) + @idasistenciatrabajador + CHAR(39)	
		INSERT INTO @t 
		EXEC(@sql) 
		SELECT @cantidadasistenciapormarcar=resultado FROM @t


		/*********** marcaciones cual toca *************/

		--- marcacion inicial ---
		set @qmarcacion = @prefijo+'mi'
		print @qmarcacion
		set  @sql = 'select top 1 '+@qmarcacion+' from asistenciatrabajadores where id = '+CHAR(39) + @idasistenciatrabajador + CHAR(39)	
		DECLARE @tm TABLE(horario varchar(5))
		INSERT INTO @tm 
		EXEC(@sql) 
		SELECT @m1=horario FROM @tm

		--- salida refrigerio ---
		set @qmarcacion = @prefijo+'mri'
		set  @sql = 'select top 1 '+@qmarcacion+' from asistenciatrabajadores where id = '+CHAR(39) + @idasistenciatrabajador + CHAR(39)	
		INSERT INTO @tm 
		EXEC(@sql) 
		SELECT @m2=horario FROM @tm

		--- ingreso refrigerio ---
		set @qmarcacion = @prefijo+'mrf'
		set  @sql = 'select top 1 '+@qmarcacion+' from asistenciatrabajadores where id = '+CHAR(39) + @idasistenciatrabajador + CHAR(39)	
		INSERT INTO @tm 
		EXEC(@sql) 
		SELECT @m3=horario FROM @tm

		--- marcacion final ---
		set @qmarcacion = @prefijo+'mf'
		set  @sql = 'select top 1 '+@qmarcacion+' from asistenciatrabajadores where id = '+CHAR(39) + @idasistenciatrabajador + CHAR(39)	
		INSERT INTO @tm 
		EXEC(@sql) 
		SELECT @m4=horario FROM @tm


		IF @cantidadasistenciapormarcar = 4
			BEGIN

				IF @m1 = ''
					BEGIN
						set @variableenviar = @prefijo+'mi'
						set @mensaje = 'ENTRADA'
						set @estadoaviso = 'Entrada'
						set @sw = 0
					END
				ELSE
					BEGIN
						IF @m2 = ''
							BEGIN
								set @variableenviar = @prefijo+'mri'
								set @mensaje = 'SALIDA a refrigerio'
								set @estadoaviso = 'S. refrigerio'
								set @sw = 0
								set @color = 1
							END
						ELSE
							BEGIN
								IF @m3 = ''
									BEGIN
										set @variableenviar = @prefijo+'mrf'
										set @mensaje = 'ENTRADA de refrigerio'
										set @estadoaviso = 'E. refrigerio'
										set @sw = 0
										set @color = 1
									END
								ELSE
									BEGIN
										IF @m4 = ''
											BEGIN
												set @variableenviar = @prefijo+'mf'
												set @mensaje = 'SALIDA'
												set @estadoaviso = 'Salida'
												set @sw = 0
											END
										ELSE
											BEGIN
												set @mensaje = 'Ya marco toda sus asitencias'
												set @sw = 1
											END

									END
							END
					END


			END
		ELSE
			BEGIN

				IF @m1 = ''
					BEGIN
						set @variableenviar = @prefijo+'mi'
						set @mensaje = 'ENTRADA'
						set @estadoaviso = 'Entrada'
						set @sw = 0
					END
				ELSE
					BEGIN
						IF @m4 = ''
							BEGIN
								set @variableenviar = @prefijo+'mf'
								set @mensaje = 'SALIDA'
								set @estadoaviso = 'Salida'
								set @sw = 0
							END
						ELSE
							BEGIN
								set @mensaje = 'Ya marco toda sus asitencias'
								set @sw = 1
							END
					END

			END
	END




select @mensaje mensaje,
	   @sw error,
	   @idasistenciatrabajador idasistencia,
	   @variableenviar donderegistrar,
	   @prefijo prefijo,
	   @color color,
	   @nombrecompleto nombrecompleto,
	   @estadoaviso estadomensaje,
	   @idtrabajador idtrabajador,
	   @diasemana diasemana,
	   @idsemana  idsemana,
	   @tienehorario tienehorario,
	   @nombresemana nombresemana


