drop database projet_recepisse;
create database projet_recepisse;
use projet_recepisse;

drop table if exists agent;
create table agent(
matricule int primary key auto_increment not null,
site varchar(60),
direction varchar(60),
service varchar(60),
nom_dsi varchar(60),
prenom_dsi varchar(60),
nom_utilisateur varchar(60),
prenom_utilisateur varchar(60))engine=innodb;

drop table if exists materiel;
create table materiel(
id int primary key auto_increment not null,
etat_materiel varchar(60),
type_equipement int)engine=innodb;

drop table if exists site;
create table site(
code_site int primary key auto_increment not null,
nom_site varchar(60),
cle_agent_utilisateur int not null)engine=innodb;

drop table if exists inventaire;
create table inventaire(
num_inventaire int primary key auto_increment not null,
num_serie int,
type int)engine=innodb;
alter table inventaire
add constraint fk_inventaire_materiel
foreign key(num_inventaire) references materiel(id);

drop table if exists service;
create table service(
code_service int primary key auto_increment not null,
nom_service varchar(60),
code_direction int,
agent varchar(60))engine=innodb;

drop table if exists direction;
create table direction(
code_direction int primary key auto_increment not null,
nom_direction varchar(60),
service varchar(60))engine=innodb;

drop table if exists recepisse;
create table recepisse(
matricule int primary key auto_increment not null,
num_inventaire int,
date_retour_estime int,
date_retour_reel int,
statut varchar(60))engine=innodb;
alter table recepisse
add constraint fk_recepisse_matricule
foreign key(matricule) references agent(matricule);

drop table if exists agentMateriel;
create table agentMateriel(
date_attribution int)engine=innodb;
alter table agentMateriel
add constraint fk_agentMateriel_materiel
foreign key(date_attribution) references materiel(id);
alter table agentMateriel
add constraint fk_agentMateriel_matricule
foreign key(date_attribution) references agent(matricule);
