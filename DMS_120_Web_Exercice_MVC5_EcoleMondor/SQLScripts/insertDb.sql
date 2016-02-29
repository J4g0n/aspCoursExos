use DBEcoleMondor

go
	insert into etudiant (
		nom, 
		prenom,
		addresse,
		telephone
	) values (
		'Sancho',
		'Pança',
		'35 allee des miradors',
		'0675757575'
	)
go

go
	insert into etudiant (
		nom, 
		prenom,
		addresse,
		email,
		telephone
	) values (
		'Don',
		'Quijote',
		'35 allee des miradors',
		'don@gmail.com',
		'0676767676'
	)
go

go
	insert into etudiant (
		nom, 
		prenom,
		addresse,
		telephone
	) values (
		'Gabriel',
		'Garcia Lorca',
		'55 rue des Vautours',
		'0676777879'
	)
go

go
	insert into formateur (
		nom, 
		prenom,
		addresse,
		telephone,
		specialite
	) values (
		'Ernest',
		'Hemingway',
		'33 avenue de la Havane',
		'0607080910',
		'litterature'
	)
go

go
	insert into cours (
		idFormateur, 
		libelle,
		specialite,
		duree
	) values (
		1,
		'Litterature espagnole du moyen age à nos jours',
		'litterature',
		35
	)
go

go
	insert into classe (
		idCours, 
		idEtudiant
	) values (
		1,
		1
	)
go

go
	insert into classe (
		idCours, 
		idEtudiant
	) values (
		1,
		2
	)
go


