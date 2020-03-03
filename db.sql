use master 

create database Biblioteca

create table Libro
(
idLibro int primary key identity not null, 
titulo varchar(100) not null, 
editorial varchar(100) not null,
fechaPublicacion date not null, 
pais varchar(50) not null, 
isbn varchar(20) not null,
imageUrl varchar(100)
)

create table Autor
(
idAutor int primary key identity not null,
nombre varchar(100) not null unique,
sexo varchar(10) not null, 
fechaAlta date not null, 
pais varchar(50) not null
)

create table LibroAutor
(
idLibro int  not null, 
idAutor int  not null, 
numPaginas int not null,

constraint fk_libro foreign key (idLibro) references Libro(idLibro),
constraint fk_autor foreign key (idAutor) references Autor(idAutor)

)
use Biblioteca
SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE='BASE TABLE'
select * from autor

insert into autor(nombre, sexo, fechaAlta, pais) values ('Clifford A. Shaffer', 'Masculino', getdate(), 'Estados Unidos')
insert into autor(nombre, sexo, fechaAlta, pais) values ('D.S Malik', 'Masculino', getdate(), 'Estados Unidos')
insert into autor(nombre, sexo, fechaAlta, pais) values ('Hans Petter Langtangen', 'Masculino', getdate(), 'Noruega')
insert into autor(nombre, sexo, fechaAlta, pais) values ('Svein Linge', 'Masculino', getdate(), 'Noruega')
insert into autor(nombre, sexo, fechaAlta, pais) values ('Jorge A. Villalobos S', 'Masculino', getdate(), 'Mexico')

create proc ObtenerAutores
as
begin
select nombre from Autor
end 

create proc ObtenerLibros
as
begin
select * from Libro
end

create proc InsertarLibro
@titulo varchar(100), 
@editorial varchar(100),
@fechaPublicacion date, 
@pais varchar(50), 
@isbn varchar(20), 
@imageUrl varchar(100)
as
begin
--begin transaction 

--begin try
insert into Libro (titulo, editorial, fechaPublicacion, pais, isbn, imageUrl) values (@titulo, @editorial, @fechaPublicacion, @pais, @isbn, @imageUrl)
select SCOPE_IDENTITY()
--commit
--end try
--begin catch
--rollback
--end catch
--end
end


