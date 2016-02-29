use DBEcoleMondor

go
	create table etudiant (
		id int primary key identity,
		nom varchar(50) not null,	
		prenom varchar(50) not null,
		addresse varchar(50) not null,
		email varchar(50),
		telephone varchar(50) not null
	)
go

go
	create table formateur (
		id int primary key identity,
		nom varchar(50) not null,	
		prenom varchar(50) not null,
		addresse varchar(50) not null,
		telephone varchar(50) not null,
		email varchar(50),
		specialite varchar(50) not null
	)
go

go
	create table cours (
		id int primary key identity,
		idFormateur int foreign key references formateur not null,
		specialite varchar(50) not null,
		libelle varchar(50) not null,
		duree int not null,
	)
go

go
	create table classe (
		id int primary key identity,
		idCours int foreign key references cours on delete cascade not null,
		idEtudiant int foreign key references etudiant on delete cascade not null
	)
go