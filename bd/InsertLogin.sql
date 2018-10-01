--INSERCIONES DE LOGIN

INSERT INTO rols (id, nombre, activo) VALUES
('ARCHICEN000000000001','Super Admin', 1)
GO

INSERT INTO users (id, nombre, apellido,dni, name, email, password, activo, rol_id, trabajador_id) VALUES
('ARCHICEN000000000001', 'Cinthia Mirella', 'Vivanco Gonzales','44404775','admin','cinthia.1390.6@gmail.com','eyJpdiI6Ik9PNGhlR0d0bjFlVFwvZ1pCZTdtdFVBPT0iLCJ2YWx1ZSI6InA5UVl1NzF1U3ZkOFwvdmQxcU9UUHR3PT0iLCJtYWMiOiIwNzg3YTlhNjhjNjU3ZjkwN2Y2ZWM5M2IyYjI5OGQzYjZhOGZhMGMyMzIzZmMwN2ZjYTc5ODg3ODkyOGVlMzVmIn0='
, 1,'ARCHICEN000000000001','ARCHICEN000000000001')
GO
INSERT INTO grupoopciones (id, nombre,icono, orden,activo) VALUES
('ARCHICEN000000000001', 'Usuarios','mdi-accounts-alt',1, 1),
('ARCHICEN000000000002', 'Personal','mdi-account-outline',2, 1),
('ARCHICEN000000000003', 'Asistencia','mdi-accounts-alt',3, 1);

GO
INSERT INTO opciones (id, nombre,descripcion, pagina,activo, grupoopcion_id) VALUES
('ARCHICEN000000000001', 'Usuarios','Usuarios','gestion-de-usuarios', 1, 'ARCHICEN000000000001'),
('ARCHICEN000000000002', 'Roles','Roles','gestion-de-roles', 1,  'ARCHICEN000000000001'),
('ARCHICEN000000000003', 'Permisos','Permisos','gestion-de-permisos', 1, 'ARCHICEN000000000001'),

('ARCHICEN000000000004', 'Ficha Trabajador','Personal','gestion-de-trabajador', 1, 'ARCHICEN000000000002'),
('ARCHICEN000000000005', 'Reportes','Reportes','gestion-de-reportes', 1, 'ARCHICEN000000000002'),

('ARCHICEN000000000006', 'Horario','Horario','gestion-de-horario', 1, 'ARCHICEN000000000003');
GO

INSERT INTO rolopciones (id, orden,ver, anadir,modificar, eliminar,todas, rol_id, opcion_id) VALUES
('ARCHICEN000000000001', 1, 1, 1, 1, 1, 1, 'ARCHICEN000000000001', 'ARCHICEN000000000001'),
('ARCHICEN000000000002', 2, 1, 1, 1, 1, 1, 'ARCHICEN000000000001', 'ARCHICEN000000000002'),
('ARCHICEN000000000003', 3, 1, 1, 1, 1, 1, 'ARCHICEN000000000001', 'ARCHICEN000000000003'),
('ARCHICEN000000000004', 4, 1, 1, 1, 1, 1, 'ARCHICEN000000000001', 'ARCHICEN000000000004'),
('ARCHICEN000000000005', 5, 1, 1, 1, 1, 1, 'ARCHICEN000000000001', 'ARCHICEN000000000005'),
('ARCHICEN000000000006', 6, 1, 1, 1, 1, 1, 'ARCHICEN000000000001', 'ARCHICEN000000000006');

