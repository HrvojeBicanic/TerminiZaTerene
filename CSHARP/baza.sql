
create table korisnici (
id int not null primary key identity(1,1),
ime varchar(45) not null,
prezime varchar(45) not null,
broj_mob varchar(45),
email varchar(45),
lozinka varchar(45)
);

create table termini (
id int not null primary key identity(1,1),
korisnik_id int not null,
pocetak varchar(45),
kraj varchar(45),
teren_id int not null,
cijena decimal(10,2)
);

create table tereni (
id int not null primary key identity(1,1),
naziv_terena varchar(45),
tip_terena varchar(45)
);

alter table termini add foreign key (korisnik_id) references korisnici(id);
alter table termini add foreign key (teren_id) references tereni(id);

select * from korisnici;
 -- 1 - 11
insert into korisnici(ime, prezime, email) values
('Bičanić','Hrvoje','chola.bog@gmail.com'),
('Renato', 'Gojtan', 'renato.gojtan@example.com'),
('Hrvoje', 'Matić', 'hrvoje.matić@example.com'),
('Ivana', 'Trdin', 'ivana.trdin@example.com'),
('Nikola', 'Virovac', 'nikola.virovac@example.com'),
('Luka', 'Pavlinušić', 'luka.pavlinusic@example.com'),
('Goran', 'Rogić', 'goran.rogic@example.com'),
('Danijela', 'Antić', 'danijela.antic@example.com'),
('Marin Matthew', 'Kuna', 'marinmatthew.kuna@example.com'),
('Marijana', 'Prpić', 'marijana.prpic@example.com'),
('Tomislav', 'Janković', 'tomislav.jankovic@example.com');

select * from tereni;
 --1 - 6
insert into tereni(naziv_terena, tip_terena) values 
('Teren 1', 'tenis'),
('Teren 2', 'košarka'),
('Teren 3', 'rukomet'),
('Teren 4', 'nogomet'),
('Dvorana A', 'vaterpolo'),
('Dvorana B', 'skvoš');

select * from termini;
insert into termini (korisnik_id, pocetak, kraj, teren_id, cijena) values
(1, '2024-06-08 12:00', '2024-06-08 12:55', 2, 20),
(2, '2024-06-08 13:00', '2024-06-08 13:55', 3, 15.50),
(3, '2024-06-08 23:30', '2024-06-09 00:30', 1, 10.50),
(4, '2024-06-10 14:00', '2024-06-10 15:30', 5, 30),
(5, '2024-06-11 12:00', '2024-06-11 13:00', 4, 20),
(6, '2024-06-11 17:20', '2024-06-11 18:20', 6, 16);