
------------------------------------------------------------------------------------------------

create PROCEDURE pr_liUsuariot 
@nombreUsuario  varchar(20)    
AS  
BEGIN  
SELECT dni,apellidopaterno,apellidomaterno,nombres, telefono, tiene,  [template], [template10],[mar_huella], [mar_dni], [huella_foto] FROM  trabajadores  p    
order by nombres 
END   
-----------------------------------------------------------------------------------------------------------------------------------
go

create PROCEDURE pr_lUsuariot
		@dni  varchar(50) 	
AS
BEGIN
	SELECT u.dni FROM trabajadores u
	WHERE  dni=@dni
END 

-----------------------------------------------------------------------------------------------------------------------------------
go

create procedure pr_aUsuariot  
 @dni varchar(50),  
 @tiene char(2),
 @Template   VARCHAR(MAX),    
 @Template10   VARCHAR(MAX),
 @FOTO image

as  
BEGIN   
 UPDATE trabajadores SET tiene=@tiene, Template=@Template,Template10=@Template10,HUELLA_FOTO=@FOTO
 WHERE dni  = @dni
END 
GO

-----------------------------------------------------------------------------------------------------------------------------------


create PROCEDURE pr_liUsuariofiltro 
@nombreUsuario  varchar(200)    
AS  
BEGIN  
SELECT dni,apellidopaterno,apellidomaterno,nombres, telefono, tiene,  [template], [template10],[mar_huella], [mar_dni], [huella_foto] FROM  trabajadores  p   
where  apellidopaterno like '%'+@nombreUsuario+'%'
order by nombres 
END   

-----------------------------------------------------------------------------------------------------------------------------------


go

create proc  pr_consultar_personal_huella     
as      
select dni as ID,      
  ISNULL(Template,'') AS 'Template',      
  ISNULL(Template10,'') AS 'Template10'      
from trabajadores     
where ISNULL(Template,'')!=''  





GO
-----------------------------------------------------------ASISTENCIA-------------------------------------------------------------------------


CREATE PROCEDURE pr_iAsistencia(     
@Usuario varchar(30),     
@tipo char(1),     
@Hora datetime,     
@observacion varchar(50),
@cod_turno int
)    
AS    
BEGIN     
 declare @jornada char(1)    
--set @jornada =( select jornada from personal WHERE CODIGOPERSONAL = ( SELECT codigopersona FROM USUARIO WHERE NOMBRE=@Usuario) )    
--set @cod_turno=(select cod_turno from turno WHERE jornada=@jornada and   
--(  
--DATEDIFF(HOUR,CONVERT(VARCHAR(15),HORAINI,108),CONVERT(VARCHAR(15),GETDATE(),108))IN(-1,1)  
--OR   
--DATEDIFF(HOUR,CONVERT(VARCHAR(15),HoraFin,108),CONVERT(VARCHAR(15),GETDATE(),108))IN(-1,1)  
--))    
 INSERT INTO Asistencia( Cod_turno, Usuario, tipo, Hora, observacion)    
 VALUES ( @cod_turno, @Usuario, @tipo, @Hora, @observacion)    
END    

GO

CREATE PROCEDURE pr_lPAfechaEstHActual     
AS    
BEGIN     
 SELECT GETDATE() as fecha 
END    

GO
-----------------------------------------------------------------------------------------------------------------------------------------------


CREATE proc  pr_LeerDnixId     
@id varchar
as      
select id as ID, dni as DNI,  
  ISNULL(Template,'') AS 'Template',      
  ISNULL(Template10,'') AS 'Template10',
  isnull(U.MAR_DNI,0) as  MAR_DNI, isnull(U.MAR_HUELLA,0) as MAR_HUELLA   
from trabajadores U 
where U.id =@id

-----------------------------------------------------------------------------------------------------------------------------------------------

GO

CREATE proc  pr_LeerxNroDoc     
@dni varchar(50)
as       
SELECT u.dni,u.apellidopaterno,u.apellidomaterno  ,u.nombres  as 'nombreTrabajador',
 isnull(U.template,'') Template,isnull(U.template10,'') as  Template10 ,isnull(U.huella_foto,'') as huella_foto,isnull(U.MAR_DNI,0) as  MAR_DNI,isnull(U.MAR_HUELLA,0) as MAR_HUELLA
 FROM trabajadores u 
 where u.dni=@dni

 GO

CREATE procedure pr_liPersonaUsuario
	@codigoPersona  varchar
as
BEGIN			
	SELECT u.dni,u.nombres as 'nombreUsuario'  FROM trabajadores u 
	where u.dni=@codigoPersona
END



GO

CREATE PROCEDURE pr_liUsuarios
	@nombre  varchar(20)	
AS
BEGIN
	SELECT u.dni, u.apellidopaterno,u.apellidomaterno,u.nombres as 'nombreUsuario'FROM trabajadores u
	WHERE  u.nombres LIKE @nombre + '%' 
	ORDER BY u.nombres
END 


GO

CREATE proc ValidarAsistencia    
@Usuario varchar(20) 
as       
declare @Fecha smalldatetime    
--declare @jornada char(1)    
--set @jornada =( select jornada from personal WHERE CODIGOPERSONAL = ( SELECT codigopersona FROM USUARIO WHERE NOMBRE=@Usuario) )    
set @Fecha=GETDATE()    
--set @turno=(select cod_turno from turno WHERE jornada=@jornada and   
--(  
--DATEDIFF(HOUR,CONVERT(VARCHAR(15),HORAINI,108),CONVERT(VARCHAR(15),GETDATE(),108))IN(-1,1)  
--OR   
--DATEDIFF(HOUR,CONVERT(VARCHAR(15),HoraFin,108),CONVERT(VARCHAR(15),GETDATE(),108))IN(-1,1)  
--)  
--)     
--print @turno    
if NOT EXISTS(select top 1 1 From asistenciatrabajadores where trabajador_id=@Usuario and docant=1)    
 select 'INGRESO'    
ELSE if not EXISTS(select top 1 1 From asistenciatrabajadores where trabajador_id=@Usuario and docant=2)    
 select 'SALIDA'    
else    
 select 'YA EXISTE'    

 GO
 -----------------------------------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE pr_iFormato( @contenido varchar(MAX))
AS
BEGIN 
	INSERT INTO Formato( contenido)
		VALUES ( @contenido)
END

GO

CREATE PROCEDURE pr_lFormato( @cod_Formato int)
AS
BEGIN 
	SELECT contenido
		 FROM Formato WHERE cod_Formato = @cod_Formato
END

-----------------------------------------------------------------------------------------------------------------------------------------------
GO

create proc pr_liturnoxUsuario
@dni varchar
as
select T.* from trabajadores U 
inner join horarios T 
where U.id =@dni

GO
