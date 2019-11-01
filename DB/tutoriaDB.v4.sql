CREATE DATABASE Tutoria;
go;
USE Tutoria;
go;

CREATE TABLE Rol (
	RolID	INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	Nombre	VARCHAR(150) NOT NULL,
	Descripcion	VARCHAR(300) not null
);

CREATE TABLE Entidad (	
	EntidadID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	RolID		INT NOT NULL,
	estaActivo	INT NOT NULL DEFAULT 1, /*0 inactivo - 1 activo*/
	FOREIGN KEY (RolID) REFERENCES Rol (RolID)
);

CREATE TABLE Persona (
	EntidadID INT NOT NULL PRIMARY KEY,
	Nombre		VARCHAR(150) NOT NULL,
	Apellido	VARCHAR(150) NOT NULL,
	FechaNacimiento		DATE NOT NULL DEFAULT '1500-05-05',
	DNI				CHAR(8) NOT NULL,
	FOREIGN KEY (EntidadID) REFERENCES Entidad(EntidadID)
);

CREATE TABLE Acceso (
	EntidadID INT NOT NULL PRIMARY KEY,
	CodigoInstitucional VARCHAR(12) NOT NULL,
	Pass 	VARCHAR(150) NOT NULL,
	FOREIGN KEY (EntidadID) REFERENCES Persona(EntidadID)
);

CREATE TABLE Contacto (
	EntidadID				INT NOT NULL PRIMARY KEY,
	Telefono				VARCHAR(15) NOT NULL,
	CorreoPersonal			VARCHAR(100) NOT NULL,
	CorreoInstitucional		VARCHAR(100) NOT NULL,
	Direccion				VARCHAR(300) NOT NULL,
	FOREIGN KEY (EntidadID) REFERENCES Persona(EntidadID)	
);

CREATE TABLE Facultad (
	FacultadID	INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	Nombre		VARCHAR(150) not null,
	Acronimo	VARCHAR(10) not null
);

CREATE TABLE Escuela (
	EscuelaID		INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	Nombre			VARCHAR(150) NOT NULL,
	Acronimo		varchar(10) NOT NULL,
	FacultadID		INT NOT NULL,
	FOREIGN KEY (FacultadID) REFERENCES Facultad (FacultadID)
);

CREATE TABLE Ciclo (
	CicloID		INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	Nombre		VARCHAR(150) NOT NULL,
	Anio		INT NOT NULL
);

CREATE TABLE EntidadCiclo (
	EntidadCicloID	INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	EntidadID		INT NOT NULL,
	CicloID			INT NOT NULL,
	FOREIGN KEY (EntidadID) REFERENCES Entidad (EntidadID),
	FOREIGN KEY (CicloID) REFERENCES Ciclo (CicloID)
);

CREATE TABLE Alumno (
	AlumnoID 			INT NOT NULL PRIMARY KEY,	
	EscuelaID			INT NOT NULL,
	CreditoAprobado		INT NOT NULL,
	FOREIGN KEY (AlumnoID) REFERENCES Entidad(EntidadID),
	FOREIGN KEY (EscuelaID) REFERENCES Escuela(EscuelaID)
);

CREATE TABLE Docente(
	DocenteID		INT NOT NULL PRIMARY KEY,
	EscuelaID		INT NOT NULL,
	Titulo			VARCHAR(100) NOT NULL,
	FOREIGN KEY (DocenteID) REFERENCES Entidad(EntidadID),
	FOREIGN KEY (EscuelaID) REFERENCES Escuela(EscuelaID)
);

CREATE TABLE Especialidad (
	EspecialidadID	INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	Nombre			VARCHAR(150) NOT NULL,
	Descripcion		VARCHAR(300) NOT NULL
);

CREATE TABLE EspecialidadDocente (
	EspecialidadDocenteID	INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	DocenteID 				INT NOT NULL,
	EspecialidadID			INT NOT NULL,
	FOREIGN KEY (EspecialidadID) REFERENCES Especialidad(EspecialidadID),
	FOREIGN KEY (DocenteID) REFERENCES Docente(DocenteID)
);

CREATE TABLE Asesor (
	AsesorID		INT NOT NULL PRIMARY KEY,
	Disponibilidad	INT NOT NULL DEFAULT 1, /*no disponible 0, disponible 1*/
	FOREIGN KEY (AsesorID) REFERENCES Docente(DocenteID)
	
);

CREATE TABLE ActividadTipo (
	ActividadTipoID		INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	Nombre				VARCHAR(150) NOT NULL,
	CreditoRequerido	INT	NOT NULL
);

CREATE TABLE Actividad (
	ActividadID		INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	Finalizada		INT NOT NULL,
	AlumnoID		INT NOT NULL,
	Titulo			VARCHAR(200) NOT NULL,
	Resumen			VARCHAR(500) NOT NULL,
	Descripcion		VARCHAR(300) NOT NULL,	
	AsesorID 		INT NOT NULL,
	ActividadTipoID INT NOT NULL, /*Tesis, Articulo, Practicas, etc.*/
	FOREIGN KEY (AlumnoID) REFERENCES Alumno(AlumnoID),
	FOREIGN KEY (AsesorID) REFERENCES Asesor(AsesorID),
	FOREIGN KEY (ActividadTipoID) REFERENCES ActividadTipo(ActividadTipoID)
);

CREATE TABLE MedallaTipo (
	MedallaTipoID	INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	Nombre			VARCHAR(150) NOT NULL,	/*oficiales, libres, etc*/
	Descripcion		VARCHAR(300) NOT NULL
);

CREATE TABLE Medalla (
	MedallaID		INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	Nombre			VARCHAR(150) NOT NULL,
	ImagenURL		VARCHAR(300) NOT NULL,
	MedallaTipoID	INT NOT NULL,
	Descripcion		VARCHAR(300) NOT NULL,	
	FOREIGN KEY (MedallaTipoID) REFERENCES MedallaTipo(MedallaTipoID)
);

CREATE TABLE Entregable (
	EntregableID	INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	ActividadID		INT NOT NULL,
	Descripcion		VARCHAR(300) NOT NULL,
	Comentario		VARCHAR(300) NOT NULL,	
	NumeroOrden		INT NOT NULL,
	FechaAprobado	DATE NOT NULL DEFAULT '1500-05-05',
	FOREIGN KEY (ActividadID) REFERENCES Actividad(ActividadID)
);

CREATE TABLE EntregableEstado (
	EntregableEstadoID		INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	DocumentoURL			VARCHAR(300) NOT NULL,
	Fecha					DATE NOT NULL DEFAULT '1500-05-05',
	ComentarioAlumno		VARCHAR(300) NOT NULL,
	ComentarioDocente		VARCHAR(300) NOT NULL,
	Estado					INT NOT NULL /*enviado 0, corregir 1, aprobado 3*/
);

CREATE TABLE EntregableHistoria(
	EntregableHistoriaID	INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	EntregableEstadoID		INT NOT NULL,
	EntregableID			INT NOT NULL,
	FOREIGN KEY (EntregableEstadoID) REFERENCES EntregableEstado(EntregableEstadoID),
	FOREIGN KEY (EntregableID) REFERENCES Entregable(EntregableID)
);

CREATE TABLE EntregableMedalla (
	EntregableMedallaID		INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	EntregableID			INT NOT NULL,
	MedallaID				INT NOT NULL,
	Fecha					DATE NOT NULL DEFAULT '1500-05-05',
	FOREIGN KEY (EntregableID) REFERENCES Entregable(EntregableID),
	FOREIGN KEY (MedallaID) REFERENCES Medalla(MedallaID)	
);