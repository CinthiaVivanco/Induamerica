
-----FICHA DE PERSONAL------
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'fichasocioeconomicas') AND type in (N'U'))
DROP TABLE [fichasocioeconomicas];
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'derechohabientes') AND type in (N'U'))
DROP TABLE [derechohabientes];
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'trabajadores') AND type in (N'U'))
DROP TABLE [trabajadores];
GO

--IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'parientes') AND type in (N'U'))
--DROP TABLE [parientes];
--GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'locales') AND type in (N'U'))
DROP TABLE [locales];
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'contratos') AND type in (N'U'))
DROP TABLE [contratos];
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'tipocontratotrabajadores') AND type in (N'U'))
DROP TABLE [tipocontratotrabajadores];
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'ciudades') AND type in (N'U'))
DROP TABLE [ciudades];
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'empresas') AND type in (N'U'))
DROP TABLE [empresas];
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'tipovias') AND type in (N'U'))
DROP TABLE [tipovias];
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'tipozonas') AND type in (N'U'))
DROP TABLE [tipozonas];
GO

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'tipocontratos') AND type in (N'U'))
DROP TABLE [tipocontratos];
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'tipopagos') AND type in (N'U'))
DROP TABLE [tipopagos];
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'ocupaciontrabajos') AND type in (N'U'))
DROP TABLE [ocupaciontrabajos];
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'tipodocumentos') AND type in (N'U'))
DROP TABLE [tipodocumentos];
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'motivobajas') AND type in (N'U'))
DROP TABLE [motivobajas];
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'carreras') AND type in (N'U'))
DROP TABLE [carreras];
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'instituciones') AND type in (N'U'))
DROP TABLE [instituciones];
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'tipoinstituciones') AND type in (N'U'))
DROP TABLE [tipoinstituciones];
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'regimeninstituciones') AND type in (N'U'))
DROP TABLE [regimeninstituciones];
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'distritos') AND type in (N'U'))
DROP TABLE [distritos];
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'provincias') AND type in (N'U'))
DROP TABLE [provincias];
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'departamentos') AND type in (N'U'))
DROP TABLE [departamentos];
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'nacionalidades') AND type in (N'U'))
DROP TABLE [nacionalidades];
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'tipotrabajadores') AND type in (N'U'))
DROP TABLE [tipotrabajadores];
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'categoriacupacionals') AND type in (N'U'))
DROP TABLE [categoriacupacionals];
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'cargos') AND type in (N'U'))
DROP TABLE [cargos];
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'cargos') AND type in (N'U'))
DROP TABLE [unidades];
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'areas') AND type in (N'U'))
DROP TABLE [areas];
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'gerencias') AND type in (N'U'))
DROP TABLE [gerencias];
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'periodicidads') AND type in (N'U'))
DROP TABLE [periodicidads];
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'regimenpensionarios') AND type in (N'U'))
DROP TABLE [regimenpensionarios];
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'situacions') AND type in (N'U'))
DROP TABLE [situacions];
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'jornadalaborals') AND type in (N'U'))
DROP TABLE [jornadalaborals];
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'estadocivils') AND type in (N'U'))
DROP TABLE [estadocivils];
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'entidadfinancieras') AND type in (N'U'))
DROP TABLE [entidadfinancieras];
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'situacionespeciales') AND type in (N'U'))
DROP TABLE [situacionespeciales];
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'cusspps') AND type in (N'U'))
DROP TABLE [cusspps];
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'retencionjudicials') AND type in (N'U'))
DROP TABLE [retencionjudicials];
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'regimensaluds') AND type in (N'U'))
DROP TABLE [regimensaluds];
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'codigoeps') AND type in (N'U'))
DROP TABLE [codigoeps];
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'situaciones') AND type in (N'U'))
DROP TABLE [situaciones];
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'situacioneducativas') AND type in (N'U'))
DROP TABLE [situacioneducativas];
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'regimenlaborales') AND type in (N'U'))
DROP TABLE [regimenlaborales];
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'categoriaocupacionales') AND type in (N'U'))
DROP TABLE [categoriaocupacionales];
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'ocupaciones') AND type in (N'U'))
DROP TABLE [ocupaciones];

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'situacionespeciales') AND type in (N'U'))
DROP TABLE [situacionespeciales];
GO

---DERECHO HABIENTE

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'tipodocumentoacreditas') AND type in (N'U'))
DROP TABLE [tipodocumentoacreditas];
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'vinculofamiliares') AND type in (N'U'))
DROP TABLE [vinculofamiliares];
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'tipobajas') AND type in (N'U'))
DROP TABLE [tipobajas];
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'paises') AND type in (N'U'))
DROP TABLE [paises];
GO

---FICHA SOCIOECONÓMICA

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'tipoviviendas') AND type in (N'U'))
DROP TABLE [tipoviviendas];
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'casapartes') AND type in (N'U'))
DROP TABLE [casapartes];
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'construccionmateriales') AND type in (N'U'))
DROP TABLE [construccionmateriales];
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'servicios') AND type in (N'U'))
DROP TABLE [servicios];
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'centromedicos') AND type in (N'U'))
DROP TABLE [centromedicos];
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'frecuenciamedicos') AND type in (N'U'))
DROP TABLE [frecuenciamedicos];
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'frecuenciaexamenes') AND type in (N'U'))
DROP TABLE [frecuenciaexamenes];
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'laboratorioexamenes') AND type in (N'U'))
DROP TABLE [laboratorioexamenes];

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'enfermedades') AND type in (N'U'))
DROP TABLE [enfermedades];
GO

CREATE TABLE tipodocumentos (
  [id] varchar(20) NOT NULL,
  [identificador] varchar(20) NULL,
  [descripcion] varchar(100) NOT NULL,
  [descripcionabreviado] varchar(100) NOT NULL,
  PRIMARY KEY  ([id])
) ;
GO 

CREATE TABLE tipozonas (
  [id]  varchar(20) NOT NULL,
  [descripcion] varchar(100) NOT NULL,
  PRIMARY KEY  ([id])
) ;
GO

CREATE TABLE tipovias (
  [id]  varchar(20) NOT NULL,
  [tipo] varchar(50) NOT NULL,
  PRIMARY KEY  ([id]),
  [tipozona_id] varchar(20) NOT NULL,
  FOREIGN KEY (tipozona_id) REFERENCES tipozonas(id)
) ;
GO

CREATE TABLE motivobajas (
  [id]  varchar(20)  not NULL,
  [codigo] varchar(20)  not NULL,
  [descripcion] varchar(150) not NULL ,
  [descripcionabreviada] varchar(150) not NULL ,
  PRIMARY KEY  ([id])
) ;
GO

CREATE TABLE nacionalidades (
  [id]  varchar(20) NOT NULL,
  [codigo] varchar(20) NOT NULL,
  [nombre] varchar(50) NOT NULL,
  PRIMARY KEY  ([id])
) ;
GO

CREATE TABLE paises (
  [id]  varchar(20) NOT NULL,
  [codigo] varchar(20) NOT NULL,
  [nombre] varchar(50) NOT NULL,
  PRIMARY KEY  ([id])
) ;
GO

CREATE TABLE departamentos (
  [id]  varchar(20) NOT NULL,
  [nombre] varchar(50) NOT NULL,
  PRIMARY KEY  ([id])
) ;
GO

CREATE TABLE provincias (
  [id]  varchar(20) NOT NULL,
  [ubigeo]  varchar(20) NOT NULL,
  [nombre] varchar(50) NOT NULL,
  PRIMARY KEY  ([id]),
  [departamento_id] varchar(20) NOT NULL,
  FOREIGN KEY (departamento_id) REFERENCES departamentos(id)
) ;
GO

CREATE TABLE distritos (
  [id]  varchar(20) NOT NULL,
  [nombre] varchar(50) NOT NULL,
  PRIMARY KEY  ([id]),
  [provincia_id] varchar(20) NOT NULL,
  FOREIGN KEY (provincia_id) REFERENCES provincias(id)
) ;
GO


CREATE TABLE tipotrabajadores (
  [id] varchar(20) NOT NULL,
  [codigo] varchar(50) NOT NULL,
  [descripcion] varchar(150) NOT NULL,
  [descripcionabreviada] varchar(150) NOT NULL,
  [sectorprivado] varchar(15) NOT NULL,
  [sectorpublico] varchar(15) NOT NULL,
  [otrasentidades] varchar(15) NOT NULL,
  PRIMARY KEY  ([id])
) ;
GO


CREATE TABLE categoriacupacionals (
  [id]  varchar(20) NOT NULL,
  [codigo] varchar(50) NOT NULL,
  [descripcion] varchar(100) NOT NULL,
  [sectorprivado] varchar(15) NOT NULL,
  [sectorpublico] varchar(15) NOT NULL,
  [otrasentidades] varchar(15) NOT NULL,
  PRIMARY KEY  ([id])
) ;
GO


CREATE TABLE ocupaciontrabajos (
  [id]  varchar(20) NOT NULL,
  [codigo] varchar(20) NOT NULL,
  [nombre] varchar(100) NOT NULL,
  PRIMARY KEY  ([id]),
  [categoriacupacional_id] varchar(20) NOT NULL,
  FOREIGN KEY (categoriacupacional_id) REFERENCES categoriacupacionals(id)
) ;
GO

CREATE TABLE gerencias (
  [id] varchar(20) NOT NULL,
  [nombre] varchar(200) NOT NULL,
  PRIMARY KEY  ([id]),
) ;
GO

CREATE TABLE areas (
  [id]  varchar(20) NOT NULL,
  [nombre] varchar(200) NOT NULL,
  PRIMARY KEY  ([id]),
  [gerencia_id] varchar(20) NOT NULL,
  FOREIGN KEY (gerencia_id) REFERENCES gerencias(id)
) ;
GO


CREATE TABLE unidades (
  [id]  varchar(20) NOT NULL,
  [nombre] varchar(200) NOT NULL,
  PRIMARY KEY  ([id]),
  [area_id] varchar(20) NOT NULL,
  FOREIGN KEY (area_id) REFERENCES areas(id)
) ;
GO

CREATE TABLE cargos (
  [id]  varchar(20) NOT NULL,
  [nombre] varchar(200) NOT NULL,
  PRIMARY KEY  ([id]),
  [unidad_id] varchar(20) NULL,
  FOREIGN KEY (unidad_id) REFERENCES unidades(id)
) ;
GO


--MENSUAL, QUINCENAL, SEMANAL, DIARIA, OTROS

CREATE TABLE periodicidads (
  [id] varchar(20) NOT NULL,
  [descripcion] varchar(100) NOT NULL,
  PRIMARY KEY  ([id])
) ;
GO

--EFECTIVO, DEPÓSITO EN CUENTA, OTROS

CREATE TABLE tipopagos (
  [id] varchar(20) NOT NULL,
  [descripcion] varchar(100) NOT NULL,
  PRIMARY KEY  ([id])
) ;
GO


CREATE TABLE tipocontratos (
  [id] varchar(20) NOT NULL,
  [codigo] varchar(30) NOT NULL,
  [descripcion] varchar(100) NOT NULL,
  [descripcionabreviada] varchar(100) NOT NULL,
  PRIMARY KEY  ([id])
) ;
GO


CREATE TABLE regimeninstituciones (
  [id] varchar(20) NOT NULL,
  [codigo] varchar(100) NOT NULL,
  [nombre] varchar(100) NOT NULL,
  PRIMARY KEY  ([id])
) ;
GO

CREATE TABLE tipoinstituciones (
  [id] varchar(20) NOT NULL,
  [codigo]  varchar(20) NOT NULL,
  [nombre]  varchar(100) NOT NULL,
  PRIMARY KEY  ([id]),
  [regimeninstitucion_id] varchar(20) NOT NULL,
  FOREIGN KEY (regimeninstitucion_id) REFERENCES regimeninstituciones(id)
) ;
GO

CREATE TABLE instituciones (
  [id] varchar(20) NOT NULL,
  [codigo]  varchar(20) NOT NULL,
  [nombre]  varchar(100) NOT NULL,
  PRIMARY KEY  ([id]),
  [tipoinstitucion_id] varchar(20) NOT NULL,
  FOREIGN KEY (tipoinstitucion_id) REFERENCES tipoinstituciones(id)
  
) ;
GO

CREATE TABLE carreras (
  [id] varchar(20) NOT NULL,
  [codigo]  varchar(20) NOT NULL,
  [nombre] varchar(100) NOT NULL,
  PRIMARY KEY  ([id]),
  [institucion_id] varchar(20) NOT NULL,
  FOREIGN KEY (institucion_id) REFERENCES instituciones(id)
) ;
GO


CREATE TABLE situaciones (
  [id] varchar(20) NOT NULL,
  [descripcion] varchar(100) NOT NULL ,
  [descripcionabreviada] varchar(100) NOT NULL ,
  PRIMARY KEY  ([id])
) ;
GO



CREATE TABLE jornadalaborals (
  [id] varchar(20) NOT NULL, 
  [descripcion] varchar(100) NOT NULL,
  PRIMARY KEY  ([id])
) ;
GO



CREATE TABLE estadocivils (
  [id] varchar(20) NOT NULL, 
  [nombre] varchar(100) NOT NULL,
  PRIMARY KEY  ([id])
) ;
GO

/*
CREATE TABLE sedes (
  [id] varchar(20) NOT NULL, 
  [nombre] varchar(100) NOT NULL,
  PRIMARY KEY  ([id])
) ;
*/
GO


CREATE TABLE entidadfinancieras (
  [id] varchar(20) NOT NULL,
  [codigo] varchar(20) NOT NULL ,
  [entidad] varchar(100) NOT NULL,
  PRIMARY KEY  ([id])
) ;
GO


CREATE TABLE regimensaluds (
  [id] varchar(20) NOT NULL,
  [codigo] varchar(20) NOT NULL ,
  [descripcion] varchar(100) NOT NULL ,
  [descripcionabreviada] varchar(100) NOT NULL ,
  PRIMARY KEY  ([id])
) ;
GO

CREATE TABLE regimenpensionarios (
  [id] varchar(20) NOT NULL,
  [numero] varchar(50) NOT NULL ,
  [descripcion] varchar(100) NOT NULL ,
  [descripcionabreviada] varchar(100) NOT NULL,
  [sectorprivado] varchar(15) NULL,
  [sectorpublico] varchar(15) NULL,
  [otrasentidades] varchar(15) NULL,
  PRIMARY KEY  ([id])
) ;
GO


CREATE TABLE codigoeps (
  [id] varchar(20) NOT NULL,
  [ruc] varchar(100) NOT NULL ,
  [descripcion] varchar(100) NOT NULL ,
  PRIMARY KEY  ([id])
) ;
GO

CREATE TABLE situacioneducativas (
  [id] varchar(20) NOT NULL,
  [descripcion] varchar(100) NOT NULL ,
  [descripcionabreviada] varchar(100) NOT NULL ,
  PRIMARY KEY  ([id])
) ;
GO

CREATE TABLE regimenlaborales (
  [id] varchar(20) NOT NULL,
  [descripcion] varchar(100) NOT NULL ,
  [descripcionabreviada] varchar(100) NOT NULL ,
  PRIMARY KEY  ([id])
) ;
GO

CREATE TABLE categoriaocupacionales (
  [id] varchar(20) NOT NULL,
  [codigo] varchar(20) NOT NULL,
  [descripcion] varchar(100) NOT NULL ,
  [sectorpublico] varchar(100) NOT NULL ,
  [sectorprivado] varchar(100) NOT NULL ,
  [otrasentidades] varchar(100) NOT NULL ,
  PRIMARY KEY  ([id])
) ;
GO

CREATE TABLE ocupaciones (
  [id] varchar(20) NOT NULL,
  [codigo] varchar(20) NOT NULL,
  [descripcion] varchar(100) NOT NULL ,
  PRIMARY KEY  ([id])
) ;
GO

CREATE TABLE situacionespeciales (
  [id] varchar(20) NOT NULL,
  [descripcion] varchar(100) NOT NULL ,
  [descripcionabreviada] varchar(100) NOT NULL,
  PRIMARY KEY  ([id])
) ;

GO

CREATE TABLE ciudades(
  [id] varchar(20) NOT NULL,
  [descripcion]  varchar(50) NULL,
  [zona]  varchar(50) NULL,
  [activo] bit NULL,
  PRIMARY KEY  ([id]),
  
)  ;
GO


CREATE TABLE empresas(
  [id] varchar(20) NOT NULL,
  [descripcion]  varchar(50) NULL,
  [abreviatura]  varchar(50) NULL,
  [activo] bit NULL,
  PRIMARY KEY  ([id]),
)  ;
GO

CREATE TABLE locales(
	[id] varchar(20) NOT NULL,
	[identificador] varchar(20) NULL,
	[nombre] varchar(80) NULL,
	[nombreabreviado] varchar(80) NULL,
	[direccion] varchar(200) NULL,
	[telefono] varchar(15) NULL,
	[fax] varchar(15) NULL,
	[email] varchar(50) NULL,
	[descripcion] varchar(80) NULL,
	[prefijoLocal] varchar(10) NULL,
	[activo] [bit] NULL,
    PRIMARY KEY ([id]),
	[ciudad_id] varchar(20) NOT NULL,
	FOREIGN KEY (ciudad_id) REFERENCES ciudades(id),
	[empresa_id] varchar(20) NOT NULL,
	FOREIGN KEY (empresa_id) REFERENCES empresas(id)
)  ;
GO


/*
CREATE TABLE establecimientolaborals (
  [id] varchar(20) NOT NULL,
  [codigo] varchar(20) NOT NULL,
  [descripcion] varchar(200) NOT NULL ,
  [descripcionabreviada] varchar(100) NOT NULL,
  PRIMARY KEY  ([id]),
  [empresa_id] varchar(20) NULL,
  FOREIGN KEY (empresa_id) REFERENCES empresas(id)
) ;
*/
GO

CREATE TABLE trabajadores (
  [apellidopaterno] varchar(100) NOT NULL,
  [apellidomaterno] varchar(100) NOT NULL,
  [id] varchar(20) NOT NULL,
  [dni] varchar(50) NOT NULL,
  [fechanacimiento] date NULL,
  [nombres] varchar(100) NOT NULL,
  [sexo] int NOT NULL,
  [telefono] varchar(20) NOT NULL,
  [email] varchar(100) NOT NULL,
  [nombrevia] varchar(100) NOT NULL,
  [numerovia] varchar(20) NOT NULL,
  [nombrezona] varchar(100) NOT NULL,
  [referencia] varchar(100)  NULL,
  [interior] varchar(20) NOT NULL,
  [remuneracion] int NOT NULL,
  [numerocuenta] varchar(100) NOT NULL,
  [discapacidad] int NOT NULL,
  [sindicalizado] int NOT NULL,
  [departamento_id] varchar(20) NOT NULL,
  [provincia_id] varchar(20) NOT NULL,
  [gerencia_id] varchar(20) NOT NULL,
  [area_id] varchar(20) NOT NULL,
  [unidad_id] varchar(20) NULL,
  [afiliadoeps] int NOT NULL,
  [essaludvida] int NOT NULL,
  [senati] int NOT NULL,
  [sctrsalud] int NOT NULL,
  [sctrpensiones] int NOT NULL,
  [domiciliado] int NOT NULL,
  [estudiosperu] int  NULL,
  [cussp] varchar(20)  NULL,
  [regimeninstitucion_id] varchar(20) NULL,
  [tipoinstitucion_id] varchar(20) NULL,
  [institucion_id] varchar(20)  NULL,
  [añoegreso] int  NULL,
  [asignacionfamiliar] int NOT NULL,
  [rentaquinta] int NOT NULL,
  [quintaexonerada] int  NULL,
  [fechainicio] date NOT NULL,
  [fechafin] date NOT NULL,
  [activo]  int NOT NULL default 1,
  [template] varchar(max) NULL,
  [template10] varchar(max) NULL,
  [mar_huella] bit NULL,
  [mar_dni] bit NULL,
  [huella_foto] image NULL,
  [tiene] varchar(10) default 'NO' NULL,
  PRIMARY KEY ([id]),
  [tipodocumento_id] varchar(20) NOT NULL,
  FOREIGN KEY (tipodocumento_id) REFERENCES tipodocumentos(id),
  [estadocivil_id] varchar(20) NOT NULL,
  FOREIGN KEY (estadocivil_id) REFERENCES estadocivils(id),
  [nacionalidad_id] varchar(20) NOT NULL,
  FOREIGN KEY (nacionalidad_id) REFERENCES nacionalidades(id),
  [tipovia_id] varchar(20) NOT NULL,
  FOREIGN KEY (tipovia_id) REFERENCES tipovias(id),
  [tipozona_id] varchar(20) NOT NULL,
  FOREIGN KEY (tipozona_id) REFERENCES tipozonas(id),
  [pais_id] varchar(20) NOT NULL,
  FOREIGN KEY (pais_id) REFERENCES paises(id),
  [tipotrabajador_id] varchar(20) NOT NULL,
  FOREIGN KEY (tipotrabajador_id) REFERENCES tipotrabajadores(id),
  [motivobaja_id] varchar(20) NOT NULL,
  FOREIGN KEY (motivobaja_id) REFERENCES motivobajas(id),
  [tipocontrato_id] varchar(20) NOT NULL,
  FOREIGN KEY (tipocontrato_id) REFERENCES tipocontratos(id),
  [tipopago_id] varchar(20) NOT NULL,
  FOREIGN KEY (tipopago_id) REFERENCES tipopagos(id),
  [periodicidad_id] varchar(20) NOT NULL,
  FOREIGN KEY (periodicidad_id) REFERENCES periodicidads(id),
  [cargo_id] varchar(20) NOT NULL,
  FOREIGN KEY (cargo_id) REFERENCES cargos(id),
  [jornadalaboral_id] varchar(20) NOT NULL,
  FOREIGN KEY (jornadalaboral_id) REFERENCES jornadalaborals(id),
  [entidadfinanciera_id] varchar(20) NOT NULL,
  FOREIGN KEY (entidadfinanciera_id) REFERENCES entidadfinancieras(id),
  [regimensalud_id] varchar(20) NOT NULL,
  FOREIGN KEY (regimensalud_id) REFERENCES regimensaluds(id),
  [regimenpensionario_id] varchar(20) NOT NULL,
  FOREIGN KEY (regimenpensionario_id) REFERENCES regimenpensionarios(id),
  [distrito_id] varchar(20) NOT NULL,
  FOREIGN KEY (distrito_id) REFERENCES distritos(id),
  [situacion_id] varchar(20) NOT NULL,
  FOREIGN KEY (situacion_id) REFERENCES situaciones(id),
  [codigoeps_id] varchar(20) NOT NULL,
  FOREIGN KEY (codigoeps_id) REFERENCES codigoeps(id),
  [situacioneducativa_id] varchar(20) NOT NULL,
  FOREIGN KEY (situacioneducativa_id) REFERENCES situacioneducativas(id),
  [carrera_id] varchar(20) NULL,
  FOREIGN KEY (carrera_id) REFERENCES carreras(id),
  [regimenlaboral_id] varchar(20) NOT NULL,
  FOREIGN KEY (regimenlaboral_id) REFERENCES regimenlaborales(id),
  [categoriaocupacional_id] varchar(20) NOT NULL,
  FOREIGN KEY (categoriaocupacional_id) REFERENCES categoriaocupacionales(id),
  [ocupacion_id] varchar(20) NOT NULL,
  FOREIGN KEY (ocupacion_id) REFERENCES ocupaciones(id),
  [situacionespecial_id] varchar(20) NOT NULL,
  FOREIGN KEY (situacionespecial_id) REFERENCES situacionespeciales(id),
  [local_id] varchar(20) NOT NULL,
  FOREIGN KEY (local_id) REFERENCES locales(id)
  /*
  [fechaingreso] datetime NOT NULL,
  [fechacese] datetime NULL,

  */
) ;
GO

---FICHA DERECHO HABIENTE


CREATE TABLE vinculofamiliares (
  [id] varchar(20) NOT NULL,
  [codigo] varchar(20) NULL,
  [descripcion] varchar(100) NOT NULL,
  [descripcionabreviado] varchar(100) NOT NULL,
  PRIMARY KEY  ([id])
) ;
GO

CREATE TABLE tipodocumentoacreditas(
  [id] varchar(20) NOT NULL,
  [codigo] varchar(20) NULL,
  [descripcion] varchar(100) NOT NULL,
  [descripcionabreviado] varchar(100) NOT NULL,
  PRIMARY KEY  ([id]),
  [vinculofamiliar_id] varchar(20) NOT NULL,
  FOREIGN KEY (vinculofamiliar_id) REFERENCES vinculofamiliares(id)
) ;
GO 

GO

CREATE TABLE tipobajas (
  [id] varchar(20) NOT NULL,
  [codigo] varchar(20) NOT NULL,
  [descripcion] varchar(100) NOT NULL ,
  [descripcionabreviado] varchar(100) NOT NULL,
  PRIMARY KEY  ([id])
) ;

GO

CREATE TABLE derechohabientes (
  [id] varchar(20) NOT NULL,
  [dnihabiente] varchar(20) NOT NULL,
  [fechanacimiento] date NOT NULL,
  [apellidopaterno] varchar(100) NOT NULL,
  [apellidomaterno] varchar(100) NOT NULL,
  [nombres] varchar(100) NOT NULL,
  [sexo] int NOT NULL,
  [dniacredita] varchar(50) NOT NULL,
  [fechainicio] date NOT NULL,
  [fechafin] date NOT NULL,
  [numeroresolucion] varchar(20) NOT NULL,
  [nombrevia] varchar(100) NOT NULL,
  [numerovia] varchar(20) NOT NULL,
  [nombrezona] varchar(100) NOT NULL,
  [referencia] varchar(100) NOT NULL,
  [interior] varchar(20)  NULL,
  [departamento_id] varchar(20) NOT NULL,
  [provincia_id] varchar(20) NOT NULL,
  [vinculofamiliar_id] varchar(20)  NULL,
  [activo]  int NOT NULL default 1,
  PRIMARY KEY ([id]),
  [tipodocumento_id] varchar(20) NOT NULL,
  FOREIGN KEY (tipodocumento_id) REFERENCES tipodocumentos(id),
  [tipodocumentoacredita_id] varchar(20) NOT NULL,
  FOREIGN KEY (tipodocumentoacredita_id) REFERENCES tipodocumentoacreditas(id),
  [tipobaja_id] varchar(20) NOT NULL,
  FOREIGN KEY (tipobaja_id) REFERENCES tipobajas(id),
  [distrito_id] varchar(20) NOT NULL,
  FOREIGN KEY (distrito_id) REFERENCES distritos(id),
  [tipovia_id] varchar(20) NOT NULL,
  FOREIGN KEY (tipovia_id) REFERENCES tipovias(id),
  [tipozona_id] varchar(20) NOT NULL,
  FOREIGN KEY (tipozona_id) REFERENCES tipozonas(id),
  [trabajador_id] varchar(20) NOT NULL,
  FOREIGN KEY (trabajador_id) REFERENCES trabajadores(id)
) ;
GO

--FICHA SOCIOECONÒMICA
GO

CREATE TABLE tipoviviendas (
  [id] varchar(20) NOT NULL,
  [descripcion] varchar(100) NOT NULL ,
  PRIMARY KEY  ([id])
) ;
GO

CREATE TABLE casapartes (
  [id] varchar(20) NOT NULL,
  [descripcion] varchar(100) NOT NULL ,
  PRIMARY KEY  ([id])
) ;
GO

CREATE TABLE construccionmateriales (
  [id] varchar(20) NOT NULL,
  [descripcion] varchar(100) NOT NULL ,
  PRIMARY KEY  ([id])
) ;
GO

CREATE TABLE servicios (
  [id] varchar(20) NOT NULL,
  [descripcion] varchar(100) NOT NULL ,
  PRIMARY KEY  ([id])
) ;
GO

CREATE TABLE centromedicos (
  [id] varchar(20) NOT NULL,
  [descripcion] varchar(100) NOT NULL ,
  PRIMARY KEY  ([id])
) ;
GO


CREATE TABLE frecuenciamedicos (
  [id] varchar(20) NOT NULL,
  [descripcion] varchar(100) NOT NULL ,
  PRIMARY KEY  ([id])
) ;
GO

CREATE TABLE frecuenciaexamenes (
  [id] varchar(20) NOT NULL,
  [descripcion] varchar(100) NOT NULL ,
  PRIMARY KEY  ([id])
) ;
GO


CREATE TABLE enfermedades (
  [id] varchar(20) NOT NULL,
  [descripcion] varchar(100) NOT NULL ,
  PRIMARY KEY  ([id])
) ;
GO

CREATE TABLE fichasocioeconomicas (
  [id] varchar(20) NOT NULL,
  [religion] varchar(20) NOT NULL,
  [gruposanguineo] varchar(20) NOT NULL,
  [tallapantalon] varchar(20) NOT NULL,
  [tallacamisa] varchar(20) NOT NULL,
  [tallapolo] varchar(20) NOT NULL,
  [tallazapato] varchar(20) NOT NULL,
  [callesreferencia] varchar(100) NOT NULL,
  [telefonofijo] int NOT NULL,
  [telefonoemergencia] int NOT NULL,
  [referenciafamiliar] varchar(100) NOT NULL,
  [ingresomensual] int NOT NULL,
  [otroingreso] int NOT NULL,
  [negociopropio] int NULL,
  [deudas] int NOT NULL,
  [estadoconstruccion] int NULL,
  [laboratorioclinico] int NULL,
  [observacion] varchar(100) NULL,
  [tipovivienda_id] varchar(20) NOT NULL,
  FOREIGN KEY (tipovivienda_id) REFERENCES tipoviviendas(id),
  [casaparte_id] varchar(20) NOT NULL,
  FOREIGN KEY (casaparte_id) REFERENCES casapartes(id),
  [construccionmaterial_id] varchar(20) NOT NULL,
  FOREIGN KEY (construccionmaterial_id) REFERENCES construccionmateriales(id),
  [servicio_id] varchar(20) NOT NULL,
  FOREIGN KEY (servicio_id) REFERENCES servicios(id),
  [centromedico_id] varchar(20) NOT NULL,
  FOREIGN KEY (centromedico_id) REFERENCES centromedicos(id),
  [frecuenciamedico_id] varchar(20) NOT NULL,
  FOREIGN KEY (frecuenciamedico_id) REFERENCES frecuenciamedicos(id),
  [frecuenciaexamen_id] varchar(20) NOT NULL,
  FOREIGN KEY (frecuenciaexamen_id) REFERENCES frecuenciaexamenes(id),
  [enfermedad_id] varchar(20) NOT NULL,
  FOREIGN KEY (enfermedad_id) REFERENCES enfermedades(id),
  [trabajador_id] varchar(20) NOT NULL,
  FOREIGN KEY (trabajador_id) REFERENCES trabajadores(id)
) ;
GO

--CONTRATO DEL TRABAJADOR

CREATE TABLE tipocontratotrabajadores(
	[id] varchar(20) NOT NULL,
	[descripcion] varchar(50) NOT NULL,
    PRIMARY KEY ([id])
)  ;
GO

CREATE TABLE contratos(
	[id] varchar(20) NOT NULL,
	[fechainicio] date NOT NULL,
	[fechafin] date NOT NULL,
	[empresa] varchar(50) NULL,
	[observacion] varchar(50) NULL,
	[estado]  int NOT NULL default 1,
    PRIMARY KEY ([id]),
	[tipocontratotrabajador_id] varchar(20) NULL,
	FOREIGN KEY (tipocontratotrabajador_id) REFERENCES tipocontratotrabajadores(id),
	[trabajador_id] varchar(20) NOT NULL,
    FOREIGN KEY (trabajador_id) REFERENCES trabajadores(id)
)  ;
GO

/*
CREATE TABLE parientes (
  [id] varchar(20) NOT NULL,
  [dnipariente] int NOT NULL,
  [fechanacimiento] date NOT NULL,
  [apellidopaterno] varchar(100) NOT NULL,
  [apellidomaterno] varchar(100) NOT NULL,
  [nombres] varchar(100) NOT NULL,
  [sexo] int NOT NULL,
  [parentesco] int  NULL,
  [activo]  int NOT NULL default 1,
  PRIMARY KEY ([id]),
  [tipodocumento_id] varchar(20) NOT NULL,
  FOREIGN KEY (tipodocumento_id) REFERENCES tipodocumentos(id),
  [trabajador_id] varchar(20) NOT NULL,
  FOREIGN KEY (trabajador_id) REFERENCES trabajadores(id)
) ;
GO
*/


