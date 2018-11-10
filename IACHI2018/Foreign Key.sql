-------------------------------------------------------------------FICHA TRABAJADOR-----------------------------------------------------------------------------------------------


ALTER TABLE tipovias
ADD FOREIGN KEY (tipozona_id) REFERENCES tipozonas(id);
GO

ALTER TABLE provincias
ADD FOREIGN KEY (departamento_id) REFERENCES departamentos(id);
GO

ALTER TABLE distritos
ADD FOREIGN KEY (provincia_id) REFERENCES provincias(id);
GO

ALTER TABLE ocupaciontrabajos
ADD FOREIGN KEY (categoriacupacional_id) REFERENCES categoriacupacionals(id);
GO

ALTER TABLE areas
ADD FOREIGN KEY (gerencia_id) REFERENCES gerencias(id);
GO

ALTER TABLE unidades
ADD FOREIGN KEY (area_id) REFERENCES areas(id);
GO

ALTER TABLE cargos
ADD FOREIGN KEY (unidad_id) REFERENCES unidades(id);
GO

ALTER TABLE tipoinstituciones
ADD FOREIGN KEY (regimeninstitucion_id) REFERENCES regimeninstituciones(id);
GO

ALTER TABLE instituciones
ADD FOREIGN KEY (tipoinstitucion_id) REFERENCES tipoinstituciones(id);
GO

ALTER TABLE carreras
ADD FOREIGN KEY (institucion_id) REFERENCES instituciones(id);
GO

ALTER TABLE locales
ADD FOREIGN KEY (empresa_id) REFERENCES empresas(id);

GO
ALTER TABLE locales
ADD FOREIGN KEY (ciudad_id) REFERENCES ciudades(id);
GO

ALTER TABLE locales
ADD FOREIGN KEY (establecimiento_id) REFERENCES establecimientolaborals(id);
GO


ALTER TABLE trabajadores
ADD FOREIGN KEY (tipodocumento_id) REFERENCES tipodocumentos(id);
GO

ALTER TABLE trabajadores
ADD FOREIGN KEY (estadocivil_id) REFERENCES estadocivils(id);
GO

ALTER TABLE trabajadores
ADD FOREIGN KEY (nacionalidad_id) REFERENCES nacionalidades(id);
GO

ALTER TABLE trabajadores
ADD FOREIGN KEY (tipovia_id) REFERENCES tipovias(id);
GO

ALTER TABLE trabajadores
ADD FOREIGN KEY (tipozona_id) REFERENCES tipozonas(id);
GO

ALTER TABLE trabajadores
ADD FOREIGN KEY (pais_id) REFERENCES paises(id);
GO

ALTER TABLE trabajadores
ADD FOREIGN KEY (tipotrabajador_id) REFERENCES tipotrabajadores(id);
GO

ALTER TABLE trabajadores
ADD FOREIGN KEY (motivobaja_id) REFERENCES motivobajas(id);
GO

ALTER TABLE trabajadores
ADD FOREIGN KEY (entidadfinanciera_id) REFERENCES entidadfinancieras(id);
GO

ALTER TABLE trabajadores
ADD FOREIGN KEY (regimensalud_id) REFERENCES regimensaluds(id);
GO

ALTER TABLE trabajadores
ADD FOREIGN KEY (regimenpensionario_id) REFERENCES regimenpensionarios(id);
GO

ALTER TABLE trabajadores
ADD FOREIGN KEY (distrito_id) REFERENCES distritos(id);
GO

ALTER TABLE trabajadores
ADD FOREIGN KEY (situacion_id) REFERENCES situaciones(id);
GO

ALTER TABLE trabajadores
ADD FOREIGN KEY (codigoeps_id) REFERENCES codigoeps(id);
GO

ALTER TABLE trabajadores
ADD FOREIGN KEY (situacioneducativa_id) REFERENCES situacioneducativas(id);
GO

ALTER TABLE trabajadores
ADD FOREIGN KEY (carrera_id) REFERENCES carreras(id);
GO

ALTER TABLE trabajadores
ADD FOREIGN KEY (regimenlaboral_id) REFERENCES regimenlaborales(id);
GO

ALTER TABLE trabajadores
ADD FOREIGN KEY (categoriaocupacional_id) REFERENCES categoriaocupacionales(id);
GO

ALTER TABLE trabajadores
ADD FOREIGN KEY (ocupacion_id) REFERENCES ocupaciones(id);
GO

ALTER TABLE trabajadores
ADD FOREIGN KEY (situacionespecial_id) REFERENCES situacionespeciales(id);
GO

ALTER TABLE trabajadores
ADD FOREIGN KEY (local_id) REFERENCES locales(id);
GO

ALTER TABLE trabajadores
ADD FOREIGN KEY (horario_id) REFERENCES horarios(id);
GO

ALTER TABLE users
ADD FOREIGN KEY (trabajador_id) REFERENCES trabajadores(id);
GO

ALTER TABLE users
ADD FOREIGN KEY (rol_id) REFERENCES rols(id);
GO

ALTER TABLE users
ADD FOREIGN KEY (trabajador_id) REFERENCES trabajadores(id);
GO

ALTER TABLE opciones
ADD FOREIGN KEY (grupoopcion_id) REFERENCES grupoopciones(id);
GO

ALTER TABLE rolopciones
ADD FOREIGN KEY (rol_id) REFERENCES rols(id);
GO

ALTER TABLE rolopciones
ADD FOREIGN KEY (opcion_id) REFERENCES opciones(id);
GO
-----------------------------------------------------------------------FICHA DERECHO HABIENTE--------------------------------------------------------------------


ALTER TABLE tipodocumentoacreditas
ADD FOREIGN KEY (vinculofamiliar_id) REFERENCES vinculofamiliares(id);
GO


ALTER TABLE derechohabientes
ADD FOREIGN KEY (tipodocumento_id) REFERENCES tipodocumentos(id);
GO

ALTER TABLE derechohabientes
ADD FOREIGN KEY (tipodocumentoacredita_id) REFERENCES tipodocumentoacreditas(id);
GO

ALTER TABLE derechohabientes
ADD FOREIGN KEY (tipobaja_id) REFERENCES tipobajas(id);
GO

ALTER TABLE derechohabientes
ADD FOREIGN KEY (distrito_id) REFERENCES distritos(id);
GO

ALTER TABLE derechohabientes
ADD FOREIGN KEY (tipovia_id) REFERENCES tipovias(id);
GO

ALTER TABLE derechohabientes
ADD FOREIGN KEY (tipozona_id) REFERENCES tipozonas(id);
GO

ALTER TABLE derechohabientes
ADD FOREIGN KEY (trabajador_id) REFERENCES trabajadores(id);
GO

----------------------------------------------------------------------FICHA SOCIOECONÒMICA--------------------------------------------------------------------------------------

ALTER TABLE fichasocioeconomicas
ADD FOREIGN KEY (tipovivienda_id) REFERENCES tipoviviendas(id);
GO

ALTER TABLE fichasocioeconomicas
ADD FOREIGN KEY (construccionmaterial_id) REFERENCES construccionmateriales(id);
GO

ALTER TABLE fichasocioeconomicas
ADD FOREIGN KEY (centromedico_id) REFERENCES centromedicos(id);
GO

ALTER TABLE fichasocioeconomicas
ADD FOREIGN KEY (frecuenciamedico_id) REFERENCES frecuenciamedicos(id);
GO

ALTER TABLE fichasocioeconomicas
ADD FOREIGN KEY (frecuenciaexamen_id) REFERENCES frecuenciaexamenes(id);
GO

ALTER TABLE fichasocioeconomicas
ADD FOREIGN KEY (trabajador_id) REFERENCES trabajadores(id);
GO

ALTER TABLE detallefichacasapartes
ADD FOREIGN KEY (fichasocioeconomica_id) REFERENCES fichasocioeconomicas(id);
GO

ALTER TABLE detallefichacasapartes
ADD FOREIGN KEY (casaparte_id) REFERENCES casapartes(id);
GO

ALTER TABLE detallefichaenfermedades
ADD FOREIGN KEY (fichasocioeconomica_id) REFERENCES fichasocioeconomicas(id);
GO

ALTER TABLE detallefichaenfermedades
ADD FOREIGN KEY (enfermedad_id) REFERENCES enfermedades(id);
GO

ALTER TABLE detallefichaservicios
ADD FOREIGN KEY (fichasocioeconomica_id) REFERENCES fichasocioeconomicas(id);
GO

ALTER TABLE detallefichaservicios
ADD FOREIGN KEY (servicio_id) REFERENCES servicios(id);
GO


----------------------------------------------------------------------CONTRATO DEL TRABAJADOR--------------------------------------------------------------------

ALTER TABLE contratos
ADD FOREIGN KEY (trabajador_id) REFERENCES trabajadores(id);
GO

ALTER TABLE contratos
ADD FOREIGN KEY (tipocontrato_id) REFERENCES tipocontratos(id);
GO

ALTER TABLE contratos
ADD FOREIGN KEY (tipopago_id) REFERENCES tipopagos(id);
GO

ALTER TABLE contratos
ADD FOREIGN KEY (periodicidad_id) REFERENCES periodicidads(id);
GO

ALTER TABLE contratos
ADD FOREIGN KEY (cargo_id) REFERENCES cargos(id);
GO

ALTER TABLE detallejornadalaborals
ADD FOREIGN KEY (contrato_id) REFERENCES contratos(id);
GO

ALTER TABLE detallejornadalaborals
ADD FOREIGN KEY (jornadalaboral_id) REFERENCES jornadalaborals(id);
GO

ALTER TABLE contratos
ADD FOREIGN KEY (formato_id) REFERENCES formatos(id);
GO
