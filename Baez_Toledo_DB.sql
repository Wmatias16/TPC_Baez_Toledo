USE master
GO
DROP DATABASE Predio
GO
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
	Contraseña VARCHAR(100) NOT NULL,
	Telefono VARCHAR(40) NOT NULL,
	Estado BIT NOT NULL DEFAULT 1
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
	Descripcion VARCHAR(500) NOT NULL,
	UrlImagen VARCHAR(1000) NOT NULL,
	Estado bit not null DEFAULT 1
);
GO

CREATE TABLE EstadoAlquileres(
	id  SMALLINT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	NOMBRE VARCHAR(50) NOT NULL
)
GO


CREATE TABLE Alquileres(	
	Id INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	LegajoUsuario INT FOREIGN KEY REFERENCES Usuarios(Legajo) NOT NULL,
	IdCancha SMALLINT FOREIGN KEY REFERENCES Canchas(Id) NOT NULL,
	Precio Decimal NOT NULL CHECK( Precio > 0 ),
	Horas SMALLINT NOT NULL CHECK (Horas > 0 ),
	HoraAlquilada varchar(5) NOT NULL,
	Fecha DATE NOT NULL,
	Estado SMALLINT NOT NULL ,
);
GO

INSERT INTO EstadoAlquileres(NOMBRE) VALUES('Pendiente de Pago')
GO
INSERT INTO EstadoAlquileres(NOMBRE) VALUES('Finalizado')
GO
INSERT INTO EstadoAlquileres(NOMBRE) VALUES('Pendiente de Confirmación')
GO
INSERT INTO EstadoAlquileres(NOMBRE) VALUES('Cancelado')
GO
INSERT INTO EstadoAlquileres(NOMBRE) VALUES('Pago')
GO
INSERT INTO Roles(Nombre)
VALUES('Administrador')
GO
INSERT INTO Roles(Nombre)
VALUES('Cliente')
GO

INSERT INTO TipoCanchas(Nombre)
VALUES('Futbol 5')
GO
INSERT INTO TipoCanchas(Nombre)
VALUES('Futbol 7')
GO
INSERT INTO TipoCanchas(Nombre)
VALUES('Futbol 9')
GO
INSERT INTO TipoCanchas(Nombre)
VALUES('Futbol 11')
GO
INSERT INTO TipoCanchas(Nombre)
VALUES('Futsal')
GO



INSERT INTO Usuarios(Rol,Nombre,Apellido,Email,Contraseña,Telefono)
VALUES(1,'Root','admin','root.admin@gmail.com','Admin123','1133337741')
GO
INSERT INTO Canchas (Nombre,IdTipoCancha,Descripcion,Precio,UrlImagen)
VALUES('sintetico',1,'Cancha sintetica al aire libre',20000,'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRum7joL-Aou9dYMGpXKqKI2Q6zizYgNh_WOw&usqp=CAU')
GO
INSERT INTO Canchas (Nombre,IdTipoCancha,Descripcion,Precio,UrlImagen)
VALUES('Sintetico Techado',2,'Cancha de futbol sintetica Techada simil cesped',5000,'https://www.canchasupergol.com/uploads/1/3/3/7/133786110/canchas-sinteticas-americas-68_orig.png')
GO
INSERT INTO Canchas (Nombre,IdTipoCancha,Descripcion,Precio,UrlImagen)
VALUES('cemento Techado',5,'Cancha de Futsal techada cemento',5000,'https://lh3.googleusercontent.com/NeauYt7fEt8YA7yEcYkr6JTKctGaIY2w5dC9S3ooqpL93knAv9nxbPDNY1XRIwrsHLKw7Pen=w1080-h608-p-no-v0')
GO
INSERT INTO Canchas (Nombre,IdTipoCancha,Descripcion,Precio,UrlImagen)
VALUES('Cesped',2,'Cancha de futbol cesped techada',5000,'https://i2.wp.com/lacalleclub.com/wp-content/uploads/2018/11/alquiler-cancha-futbol-la-calle-proximamente-2.jpg?fit=1500%2C750')
GO

select * from EstadoAlquileres;