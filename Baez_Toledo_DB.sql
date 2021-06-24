
Create database Predio;
GO
USE Predio;
GO

CREATE TABLE Roles(
	Id SMALLINT PRIMARY KEY  IDENTITY(1,1) NOT NULL,
	Nombre VARCHAR(100) NOT NULL,
);
GO

CREATE TABLE Usuarios(
	Legajo INT PRIMARY KEY IDENTITY(1000,1) NOT NULL,
	Rol SMALLINT NOT NULL FOREIGN KEY REFERENCES Roles(Id),
	Nombre VARCHAR(50) NOT NULL,
	Apellido VARCHAR(50) NOT NULL,
	Email VARCHAR(100) NOT NULL UNIQUE,
	Telefono VARCHAR(40) NOT NULL,
);
GO

CREATE TABLE TipoCanchas(
	Id SMALLINT PRIMARY KEY  IDENTITY(1,1) NOT NULL,
	Nombre VARCHAR(100) NOT NULL,
);
GO 

CREATE TABLE Canchas(
	Id SMALLINT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Nombre varchar(40) not null,
	Precio DECIMAL NOT NULL CHECK(Precio > 0),
	IdTipoCancha SMALLINT FOREIGN KEY REFERENCES TipoCanchas(Id),
	Descripcion VARCHAR(200) NOT NULL,
	UrlImagen VARCHAR(1000) NOT NULL,
);
GO

CREATE TABLE Suscripciones(
	Id SMALLINT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	LegajoUsario INT FOREIGN KEY REFERENCES Usuarios(Legajo) NOT NULL,
	FechaInicio DATE CHECK( FechaInicio <= GETDATE() ) NOT NULL,
	Fechafin DATE NOT NULL,
);
GO

CREATE TABLE Alquileres(
	
	Id INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	LegajoUsuario INT FOREIGN KEY REFERENCES Usuarios(Legajo) NOT NULL,
	IdCancha SMALLINT FOREIGN KEY REFERENCES Canchas(Id) NOT NULL,
	Precio Decimal NOT NULL CHECK( Precio > 0 ),
	Horas SMALLINT NOT NULL CHECK (Horas > 0 ),
	Fecha DATE NOT NULL,
	Estado SMALLINT NOT NULL,
);
GO




INSERT INTO Canchas (Nombre,IdTipoCancha,Descripcion,Precio,UrlImagen)
VALUES('BOQUITA',1,'La bombonera ubicada en la rivera',20000,'https://www.canchasupergol.com/uploads/1/3/3/7/133786110/canchas-sinteticas-americas-68_orig.png')
GO
INSERT INTO Canchas (Nombre,IdTipoCancha,Descripcion,Precio,UrlImagen)
VALUES('Cancha de 11',1,'La bombonera ubicada en la rivera',5000,'https://www.canchasupergol.com/uploads/1/3/3/7/133786110/canchas-sinteticas-americas-68_orig.png')



