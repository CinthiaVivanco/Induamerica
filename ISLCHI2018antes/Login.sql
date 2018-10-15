
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'rolopciones') AND type in (N'U'))
DROP TABLE [rolopciones];
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'rolopciones') AND type in (N'U'))
DROP TABLE [rolopciones];
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'opciones') AND type in (N'U'))
DROP TABLE [opciones];
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'users') AND type in (N'U'))
DROP TABLE [users];
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'rols') AND type in (N'U'))
DROP TABLE [rols];
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'grupoopciones') AND type in (N'U'))
DROP TABLE [grupoopciones];
GO


CREATE TABLE grupoopciones (
  [id] varchar(20) NOT NULL,
  [nombre]  varchar(100) NOT NULL,
  [icono]  varchar(100) NOT NULL,
  [orden]  int NOT NULL,
  [activo]  int NOT NULL default 1,
  [created_at]  timestamp NOT NULL,
  --[updated_at]  timestamp DEFAULT NULL,
  PRIMARY KEY  ([id])
)  ;
GO

CREATE TABLE rols(
  [id] varchar(20) NOT NULL,
  [nombre]  varchar(100) NOT NULL,
  [activo]  int NOT NULL default 1,
  [created_at]  timestamp NOT NULL,
  --[updated_at]  timestamp DEFAULT NULL,
  PRIMARY KEY  ([id])
)  ;
GO

CREATE TABLE users (
  [id] varchar(20) NOT NULL,
  [nombre]  varchar(100) NOT NULL,
  [apellido]  varchar(100) NOT NULL,
  [dni]  varchar(8)  NOT NULL,
  [name]  varchar(50)  NOT NULL,
  [email]  varchar(191) NOT NULL,
  [password]  varchar(256)  NOT NULL,
  [activo]  int NOT NULL default 1,
  [created_at] timestamp NOT NULL,
  --[updated_at] timestamp DEFAULT NULL,
  PRIMARY KEY  ([id]),
  [rol_id] varchar(20)NOT NULL,
  FOREIGN KEY  (rol_id) REFERENCES rols(id),
  [trabajador_id] varchar(20) NULL,
  FOREIGN KEY (trabajador_id) REFERENCES trabajadores(id)
);
GO


CREATE TABLE opciones (
  [id] varchar(20) NOT NULL,
  [nombre] varchar(100) NOT NULL,
  [descripcion] varchar(200) NOT NULL,
  [pagina] varchar(100) NOT NULL,
  [activo] int NOT NULL default 1,
  [created_at] timestamp NOT NULL,
  --[updated_at] timestamp DEFAULT NULL,
  [grupoopcion_id] varchar(20)NOT NULL,
  PRIMARY KEY ([id]),
  FOREIGN KEY (grupoopcion_id) REFERENCES grupoopciones(id)
)  ;
GO

CREATE TABLE rolopciones (
  [id] varchar(20) NOT NULL,
  [orden] int NOT NULL,
  [ver] int NOT NULL,
  [anadir] int NOT NULL,
  [modificar] int NOT NULL,
  [eliminar] int NOT NULL,
  [todas] int NOT NULL,
  [created_at] timestamp NOT NULL,
  --[updated_at] timestamp DEFAULT NULL,
  [rol_id] varchar(20)NOT NULL,
  [opcion_id] varchar(20)NOT NULL,
  PRIMARY KEY  ([id]),
  FOREIGN KEY  (rol_id) REFERENCES rols(id),
  FOREIGN KEY  (opcion_id) REFERENCES opciones(id)
) ;
GO












