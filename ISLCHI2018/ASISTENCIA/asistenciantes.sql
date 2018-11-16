IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'asistenciadiarias') AND type in (N'U'))
DROP TABLE [asistenciadiarias];
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'asistenciatrabajadores') AND type in (N'U'))
DROP TABLE [asistenciatrabajadores];
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'horariotrabajadores') AND type in (N'U'))
DROP TABLE [horariotrabajadores];
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'horariotrabajadoresclonados') AND type in (N'U'))
DROP TABLE [horariotrabajadoresclonados];
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'horarios') AND type in (N'U'))
DROP TABLE [horarios];
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'semanas') AND type in (N'U'))
DROP TABLE [semanas];
GO

CREATE TABLE asistenciadiarias (
  [trabajador_id]	varchar(20) NOT NULL,
  [alias]			varchar(200) NULL, 
  [hora]			varchar(5) NULL,
  [estadoaviso]		varchar(20) NULL,
  [fecha]			date NOT NULL,
  [fechatime]		datetime NOT NULL
);
GO


CREATE TABLE semanas (
  [id]				varchar(20) NOT NULL,
  [numero]			int NOT NULL,
  [fechainicio]		date NOT NULL,
  [fechafin]		date NOT NULL,
  [activo]		int NOT NULL default 1,
  [created_at]  timestamp NOT NULL,
  PRIMARY KEY  ([id])
)  ;
GO

CREATE TABLE horarios (
  [id]					varchar(20) NOT NULL,
  [nombre]				varchar(100) NOT NULL,
  [horainicio]			varchar(5) NOT NULL,
  [horafin]				varchar(5) NOT NULL,
  [refrigerioinicio]	varchar(5) NULL,
  [refrigeriofin]		varchar(5) NULL,
  [horaslaboradas]		int NOT NULL,
  [refrigerio]			int NOT NULL,
  [marcacion]			int NOT NULL, -- cantidad de marcaciones
  [activo]				int NOT NULL default 1,
  [created_at]			timestamp NOT NULL,
  PRIMARY KEY  ([id])
);
GO

INSERT INTO horarios (id, nombre,horainicio, horafin, refrigerioinicio, refrigeriofin,horaslaboradas,refrigerio,marcacion) VALUES
('PRMAECEN000000000001', 'Full Time', '08:00', '17:30', '13:00', '14:00',8,1,4),
('PRMAECEN000000000002', 'Part Time', '08:00', '12:00', '', '',4,0,2);


GO

CREATE TABLE horariotrabajadoresclonados (
  [id]					varchar(20) NOT NULL,
  [luh]					int NULL default 0,   -- lunes (si tiene horario)
  [lud]					date NOT NULL,		  -- lunes (fecha)
  [hlu]					varchar(20) NOT NULL, -- idhorario de lunes
  [rhlu]				varchar(20) NOT NULL, -- rango de hora del horario

  [mah]					int NULL default 0,
  [mad]					date NOT NULL,
  [hma]					varchar(20) NOT NULL,
  [rhma]				varchar(20) NOT NULL,

  [mih]					int NULL default 0,
  [mid]					date NOT NULL,
  [hmi]					varchar(20) NOT NULL,
  [rhmi]				varchar(20) NOT NULL,

  [juh]					int NULL default 0,
  [jud]					date NOT NULL,
  [hju]					varchar(20) NOT NULL,
  [rhju]				varchar(20) NOT NULL,

  [vih]					int NULL default 0,
  [vid]					date NOT NULL,
  [hvi]					varchar(20) NOT NULL,
  [rhvi]				varchar(20) NOT NULL,

  [sah]					int NULL default 0,
  [sad]					date NOT NULL,
  [hsa]					varchar(20) NOT NULL,
  [rhsa]				varchar(20) NOT NULL,

  [doh]					int NULL default 0,
  [dod]					date NOT NULL,
  [hdo]					varchar(20) NOT NULL,
  [rhdo]				varchar(20) NOT NULL,

  [activo]				int NOT NULL default 1,
  [trabajador_id]		varchar(20) NOT NULL,
  [semana_id]			varchar(20) NOT NULL
);
GO

CREATE TABLE horariotrabajadores (
  [id]					varchar(20) NOT NULL,
  [luh]					int NULL default 0,   -- lunes (si tiene horario)
  [lud]					date NOT NULL,		  -- lunes (fecha)
  [hlu]					varchar(20) NOT NULL, -- idhorario de lunes
  [rhlu]				varchar(20) NOT NULL, -- rango de hora del horario

  [mah]					int NULL default 0,
  [mad]					date NOT NULL,
  [hma]					varchar(20) NOT NULL,
  [rhma]				varchar(20) NOT NULL,

  [mih]					int NULL default 0,
  [mid]					date NOT NULL,
  [hmi]					varchar(20) NOT NULL,
  [rhmi]				varchar(20) NOT NULL,

  [juh]					int NULL default 0,
  [jud]					date NOT NULL,
  [hju]					varchar(20) NOT NULL,
  [rhju]				varchar(20) NOT NULL,

  [vih]					int NULL default 0,
  [vid]					date NOT NULL,
  [hvi]					varchar(20) NOT NULL,
  [rhvi]				varchar(20) NOT NULL,

  [sah]					int NULL default 0,
  [sad]					date NOT NULL,
  [hsa]					varchar(20) NOT NULL,
  [rhsa]				varchar(20) NOT NULL,

  [doh]					int NULL default 0,
  [dod]					date NOT NULL,
  [hdo]					varchar(20) NOT NULL,
  [rhdo]				varchar(20) NOT NULL,

  [activo]				int NOT NULL default 1,
  [created_at]			timestamp NOT NULL,
  [trabajador_id]		varchar(20) NOT NULL,
  FOREIGN KEY (trabajador_id) REFERENCES trabajadores(id),
  [semana_id]			varchar(20) NOT NULL,
  FOREIGN KEY (semana_id) REFERENCES semanas(id),
  PRIMARY KEY			([id])
);
GO


CREATE TABLE asistenciatrabajadores (
  [id]					varchar(20) NOT NULL,

  [lumi]				varchar(5) NULL default '', -- lunes marcacion inicio
  [lumf]				varchar(5) NULL default '', -- lunes marcacion final
  [lumri]				varchar(5) NULL default '', -- lunes marcacion refrigerio inicial
  [lumrf]				varchar(5) NULL default '', -- lunes marcacion refrigerio final
  [lud]					date NOT NULL,				-- lunes (fecha)
  [hlu]					varchar(20) NOT NULL,		-- idhorario de lunes
  [lucant]				int NOT NULL default 0,		-- cantidad de marcacion del sistema
  [lucantmarc]			int NOT NULL,				-- cantidad de marcacion del horario

  [mami]				varchar(5) NULL default '',
  [mamf]				varchar(5) NULL default '',
  [mamri]				varchar(5) NULL default '',
  [mamrf]				varchar(5) NULL default '',
  [mad]					date NOT NULL,
  [hma]					varchar(20) NOT NULL,		
  [macant]				int NOT NULL default 0,		
  [macantmarc]			int NOT NULL,				

  [mimi]				varchar(5) NULL default '',
  [mimf]				varchar(5) NULL default '',
  [mimri]				varchar(5) NULL default '',
  [mimrf]				varchar(5) NULL default '',
  [mid]					date NOT NULL,
  [hmi]					varchar(20) NOT NULL,		
  [micant]				int NOT NULL default 0,		
  [micantmarc]			int NOT NULL,	

  [jumi]				varchar(5) NULL default '',
  [jumf]				varchar(5) NULL default '',
  [jumri]				varchar(5) NULL default '',
  [jumrf]				varchar(5) NULL default '',
  [jud]					date NOT NULL,
  [hju]					varchar(20) NOT NULL,		
  [jucant]				int NOT NULL default 0,		
  [jucantmarc]			int NOT NULL,	

  [vimi]				varchar(5) NULL default '',
  [vimf]				varchar(5) NULL default '',
  [vimri]				varchar(5) NULL default '',
  [vimrf]				varchar(5) NULL default '',
  [vid]					date NOT NULL,
  [hvi]					varchar(20) NOT NULL,		
  [vicant]				int NOT NULL default 0,		
  [vicantmarc]			int NOT NULL,

  [sami]				varchar(5) NULL default '',
  [samf]				varchar(5) NULL default '',
  [samri]				varchar(5) NULL default '',
  [samrf]				varchar(5) NULL default '',
  [sad]					date NOT NULL,
  [hsa]					varchar(20) NOT NULL,		
  [sacant]				int NOT NULL default 0,		
  [sacantmarc]			int NOT NULL,

  [domi]				varchar(5) NULL default '',
  [domf]				varchar(5) NULL default '',
  [domri]				varchar(5) NULL default '',
  [domrf]				varchar(5) NULL default '',
  [dod]					date NOT NULL,
  [hdo]					varchar(20) NOT NULL,		
  [docant]				int NOT NULL default 0,		
  [docantmarc]			int NOT NULL,

  [activo]				int NOT NULL default 1,
  [created_at]			timestamp NOT NULL,
  [horariotrabajador_id]	varchar(20) NOT NULL,
  FOREIGN KEY (horariotrabajador_id) REFERENCES horariotrabajadores(id),
  [trabajador_id]			varchar(20) NOT NULL,
  FOREIGN KEY (trabajador_id) REFERENCES trabajadores(id),
  [semana_id]				varchar(20) NOT NULL,
  FOREIGN KEY (semana_id) REFERENCES semanas(id),
  PRIMARY KEY			([id])
);
GO



GO
INSERT [dbo].[semanas] ([id], [numero], [fechainicio], [fechafin], [activo]) VALUES (N'PRMAECEN000000000001', 1, CAST(0xB63D0B00 AS Date), CAST(0xBC3D0B00 AS Date), 1)
INSERT [dbo].[semanas] ([id], [numero], [fechainicio], [fechafin], [activo]) VALUES (N'PRMAECEN000000000002', 2, CAST(0xBD3D0B00 AS Date), CAST(0xC33D0B00 AS Date), 1)
INSERT [dbo].[semanas] ([id], [numero], [fechainicio], [fechafin], [activo]) VALUES (N'PRMAECEN000000000003', 3, CAST(0xC43D0B00 AS Date), CAST(0xCA3D0B00 AS Date), 1)
INSERT [dbo].[semanas] ([id], [numero], [fechainicio], [fechafin], [activo]) VALUES (N'PRMAECEN000000000004', 4, CAST(0xCB3D0B00 AS Date), CAST(0xD13D0B00 AS Date), 1)
INSERT [dbo].[semanas] ([id], [numero], [fechainicio], [fechafin], [activo]) VALUES (N'PRMAECEN000000000005', 5, CAST(0xD23D0B00 AS Date), CAST(0xD83D0B00 AS Date), 1)
INSERT [dbo].[semanas] ([id], [numero], [fechainicio], [fechafin], [activo]) VALUES (N'PRMAECEN000000000006', 6, CAST(0xD93D0B00 AS Date), CAST(0xDF3D0B00 AS Date), 1)
INSERT [dbo].[semanas] ([id], [numero], [fechainicio], [fechafin], [activo]) VALUES (N'PRMAECEN000000000007', 7, CAST(0xE03D0B00 AS Date), CAST(0xE63D0B00 AS Date), 1)
INSERT [dbo].[semanas] ([id], [numero], [fechainicio], [fechafin], [activo]) VALUES (N'PRMAECEN000000000008', 8, CAST(0xE73D0B00 AS Date), CAST(0xED3D0B00 AS Date), 1)
INSERT [dbo].[semanas] ([id], [numero], [fechainicio], [fechafin], [activo]) VALUES (N'PRMAECEN000000000009', 9, CAST(0xEE3D0B00 AS Date), CAST(0xF43D0B00 AS Date), 1)
INSERT [dbo].[semanas] ([id], [numero], [fechainicio], [fechafin], [activo]) VALUES (N'PRMAECEN000000000010', 10, CAST(0xF53D0B00 AS Date), CAST(0xFB3D0B00 AS Date), 1)
INSERT [dbo].[semanas] ([id], [numero], [fechainicio], [fechafin], [activo]) VALUES (N'PRMAECEN000000000011', 11, CAST(0xFC3D0B00 AS Date), CAST(0x023E0B00 AS Date), 1)
INSERT [dbo].[semanas] ([id], [numero], [fechainicio], [fechafin], [activo]) VALUES (N'PRMAECEN000000000012', 12, CAST(0x033E0B00 AS Date), CAST(0x093E0B00 AS Date), 1)
INSERT [dbo].[semanas] ([id], [numero], [fechainicio], [fechafin], [activo]) VALUES (N'PRMAECEN000000000013', 13, CAST(0x0A3E0B00 AS Date), CAST(0x103E0B00 AS Date), 1)
INSERT [dbo].[semanas] ([id], [numero], [fechainicio], [fechafin], [activo]) VALUES (N'PRMAECEN000000000014', 14, CAST(0x113E0B00 AS Date), CAST(0x173E0B00 AS Date), 1)
INSERT [dbo].[semanas] ([id], [numero], [fechainicio], [fechafin], [activo]) VALUES (N'PRMAECEN000000000015', 15, CAST(0x183E0B00 AS Date), CAST(0x1E3E0B00 AS Date), 1)
INSERT [dbo].[semanas] ([id], [numero], [fechainicio], [fechafin], [activo]) VALUES (N'PRMAECEN000000000016', 16, CAST(0x1F3E0B00 AS Date), CAST(0x253E0B00 AS Date), 1)
INSERT [dbo].[semanas] ([id], [numero], [fechainicio], [fechafin], [activo]) VALUES (N'PRMAECEN000000000017', 17, CAST(0x263E0B00 AS Date), CAST(0x2C3E0B00 AS Date), 1)
INSERT [dbo].[semanas] ([id], [numero], [fechainicio], [fechafin], [activo]) VALUES (N'PRMAECEN000000000018', 18, CAST(0x2D3E0B00 AS Date), CAST(0x333E0B00 AS Date), 1)
INSERT [dbo].[semanas] ([id], [numero], [fechainicio], [fechafin], [activo]) VALUES (N'PRMAECEN000000000019', 19, CAST(0x343E0B00 AS Date), CAST(0x3A3E0B00 AS Date), 1)
INSERT [dbo].[semanas] ([id], [numero], [fechainicio], [fechafin], [activo]) VALUES (N'PRMAECEN000000000020', 20, CAST(0x3B3E0B00 AS Date), CAST(0x413E0B00 AS Date), 1)
INSERT [dbo].[semanas] ([id], [numero], [fechainicio], [fechafin], [activo]) VALUES (N'PRMAECEN000000000021', 21, CAST(0x423E0B00 AS Date), CAST(0x483E0B00 AS Date), 1)
INSERT [dbo].[semanas] ([id], [numero], [fechainicio], [fechafin], [activo]) VALUES (N'PRMAECEN000000000022', 22, CAST(0x493E0B00 AS Date), CAST(0x4F3E0B00 AS Date), 1)
INSERT [dbo].[semanas] ([id], [numero], [fechainicio], [fechafin], [activo]) VALUES (N'PRMAECEN000000000023', 23, CAST(0x503E0B00 AS Date), CAST(0x563E0B00 AS Date), 1)
INSERT [dbo].[semanas] ([id], [numero], [fechainicio], [fechafin], [activo]) VALUES (N'PRMAECEN000000000024', 24, CAST(0x573E0B00 AS Date), CAST(0x5D3E0B00 AS Date), 1)
INSERT [dbo].[semanas] ([id], [numero], [fechainicio], [fechafin], [activo]) VALUES (N'PRMAECEN000000000025', 25, CAST(0x5E3E0B00 AS Date), CAST(0x643E0B00 AS Date), 1)
INSERT [dbo].[semanas] ([id], [numero], [fechainicio], [fechafin], [activo]) VALUES (N'PRMAECEN000000000026', 26, CAST(0x653E0B00 AS Date), CAST(0x6B3E0B00 AS Date), 1)
INSERT [dbo].[semanas] ([id], [numero], [fechainicio], [fechafin], [activo]) VALUES (N'PRMAECEN000000000027', 27, CAST(0x6C3E0B00 AS Date), CAST(0x723E0B00 AS Date), 1)
INSERT [dbo].[semanas] ([id], [numero], [fechainicio], [fechafin], [activo]) VALUES (N'PRMAECEN000000000028', 28, CAST(0x733E0B00 AS Date), CAST(0x793E0B00 AS Date), 1)
INSERT [dbo].[semanas] ([id], [numero], [fechainicio], [fechafin], [activo]) VALUES (N'PRMAECEN000000000029', 29, CAST(0x7A3E0B00 AS Date), CAST(0x803E0B00 AS Date), 1)
INSERT [dbo].[semanas] ([id], [numero], [fechainicio], [fechafin], [activo]) VALUES (N'PRMAECEN000000000030', 30, CAST(0x813E0B00 AS Date), CAST(0x873E0B00 AS Date), 1)
INSERT [dbo].[semanas] ([id], [numero], [fechainicio], [fechafin], [activo]) VALUES (N'PRMAECEN000000000031', 31, CAST(0x883E0B00 AS Date), CAST(0x8E3E0B00 AS Date), 1)
INSERT [dbo].[semanas] ([id], [numero], [fechainicio], [fechafin], [activo]) VALUES (N'PRMAECEN000000000032', 32, CAST(0x8F3E0B00 AS Date), CAST(0x953E0B00 AS Date), 1)
INSERT [dbo].[semanas] ([id], [numero], [fechainicio], [fechafin], [activo]) VALUES (N'PRMAECEN000000000033', 33, CAST(0x963E0B00 AS Date), CAST(0x9C3E0B00 AS Date), 1)
INSERT [dbo].[semanas] ([id], [numero], [fechainicio], [fechafin], [activo]) VALUES (N'PRMAECEN000000000034', 34, CAST(0x9D3E0B00 AS Date), CAST(0xA33E0B00 AS Date), 1)
INSERT [dbo].[semanas] ([id], [numero], [fechainicio], [fechafin], [activo]) VALUES (N'PRMAECEN000000000035', 35, CAST(0xA43E0B00 AS Date), CAST(0xAA3E0B00 AS Date), 1)
INSERT [dbo].[semanas] ([id], [numero], [fechainicio], [fechafin], [activo]) VALUES (N'PRMAECEN000000000036', 36, CAST(0xAB3E0B00 AS Date), CAST(0xB13E0B00 AS Date), 1)
INSERT [dbo].[semanas] ([id], [numero], [fechainicio], [fechafin], [activo]) VALUES (N'PRMAECEN000000000037', 37, CAST(0xB23E0B00 AS Date), CAST(0xB83E0B00 AS Date), 1)
INSERT [dbo].[semanas] ([id], [numero], [fechainicio], [fechafin], [activo]) VALUES (N'PRMAECEN000000000038', 38, CAST(0xB93E0B00 AS Date), CAST(0xBF3E0B00 AS Date), 1)
INSERT [dbo].[semanas] ([id], [numero], [fechainicio], [fechafin], [activo]) VALUES (N'PRMAECEN000000000039', 39, CAST(0xC03E0B00 AS Date), CAST(0xC63E0B00 AS Date), 1)
INSERT [dbo].[semanas] ([id], [numero], [fechainicio], [fechafin], [activo]) VALUES (N'PRMAECEN000000000040', 40, CAST(0xC73E0B00 AS Date), CAST(0xCD3E0B00 AS Date), 1)
INSERT [dbo].[semanas] ([id], [numero], [fechainicio], [fechafin], [activo]) VALUES (N'PRMAECEN000000000041', 41, CAST(0xCE3E0B00 AS Date), CAST(0xD43E0B00 AS Date), 1)
INSERT [dbo].[semanas] ([id], [numero], [fechainicio], [fechafin], [activo]) VALUES (N'PRMAECEN000000000042', 42, CAST(0xD53E0B00 AS Date), CAST(0xDB3E0B00 AS Date), 1)
INSERT [dbo].[semanas] ([id], [numero], [fechainicio], [fechafin], [activo]) VALUES (N'PRMAECEN000000000043', 43, CAST(0xDC3E0B00 AS Date), CAST(0xE23E0B00 AS Date), 1)
INSERT [dbo].[semanas] ([id], [numero], [fechainicio], [fechafin], [activo]) VALUES (N'PRMAECEN000000000044', 44, CAST(0xE33E0B00 AS Date), CAST(0xE93E0B00 AS Date), 1)
INSERT [dbo].[semanas] ([id], [numero], [fechainicio], [fechafin], [activo]) VALUES (N'PRMAECEN000000000045', 45, CAST(0xEA3E0B00 AS Date), CAST(0xF03E0B00 AS Date), 1)
INSERT [dbo].[semanas] ([id], [numero], [fechainicio], [fechafin], [activo]) VALUES (N'PRMAECEN000000000046', 46, CAST(0xF13E0B00 AS Date), CAST(0xF73E0B00 AS Date), 1)
INSERT [dbo].[semanas] ([id], [numero], [fechainicio], [fechafin], [activo]) VALUES (N'PRMAECEN000000000047', 47, CAST(0xF83E0B00 AS Date), CAST(0xFE3E0B00 AS Date), 1)
INSERT [dbo].[semanas] ([id], [numero], [fechainicio], [fechafin], [activo]) VALUES (N'PRMAECEN000000000048', 48, CAST(0xFF3E0B00 AS Date), CAST(0x053F0B00 AS Date), 1)
INSERT [dbo].[semanas] ([id], [numero], [fechainicio], [fechafin], [activo]) VALUES (N'PRMAECEN000000000049', 49, CAST(0x063F0B00 AS Date), CAST(0x0C3F0B00 AS Date), 1)
INSERT [dbo].[semanas] ([id], [numero], [fechainicio], [fechafin], [activo]) VALUES (N'PRMAECEN000000000050', 50, CAST(0x0D3F0B00 AS Date), CAST(0x133F0B00 AS Date), 1)
INSERT [dbo].[semanas] ([id], [numero], [fechainicio], [fechafin], [activo]) VALUES (N'PRMAECEN000000000051', 51, CAST(0x143F0B00 AS Date), CAST(0x1A3F0B00 AS Date), 1)
INSERT [dbo].[semanas] ([id], [numero], [fechainicio], [fechafin], [activo]) VALUES (N'PRMAECEN000000000052', 52, CAST(0x1B3F0B00 AS Date), CAST(0x213F0B00 AS Date), 1)
INSERT [dbo].[semanas] ([id], [numero], [fechainicio], [fechafin], [activo]) VALUES (N'PRMAECEN000000000053', 53, CAST(0x223F0B00 AS Date), CAST(0x283F0B00 AS Date), 1)

