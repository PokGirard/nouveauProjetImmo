﻿go

/* -----------------------------------------------------------------------------
      TABLE : RDV
----------------------------------------------------------------------------- */

create table RDV
  (
     IDRDV smallint identity (1, 1)   ,
     IDVISITE smallint  not null  
     ,
     constraint PK_RDV primary key (IDRDV)
  ) 
go



/*      INDEX DE RDV      */



/* -----------------------------------------------------------------------------
      TABLE : BIEN
----------------------------------------------------------------------------- */

create table BIEN
  (
     IDBIEN smallint identity (1, 1)   ,
     IDVILLE int  not null  ,
     IDVENDEUR smallint  not null  ,
     SURFACE_HABITABLE int  not null  ,
     SURFACE_PARCELLE int  not null  ,
     NB_PIÈCES int  not null  ,
     NB_CHAMBRES int  not null  ,
     NB_SALLEDEBAIN int  not null  ,
     GARAGE bit  not null  ,
     CAVE bit  not null  ,
     PRIX_SOUHAITÉ int  not null  ,
     ADRESSE_BIEN varchar(60)  not null  ,
     CODE_POSTAL int not null  ,
     DATE_MISEENVENTE datetime  not null  ,
     STATUT char(32)  not null       CHECK (STATUT in ('DISPONIBLE', 'VENDU', 'RETIRE', 'SOUS-SEING')),
     ZONE_DE_SAISIE varchar(250)  null,  
     NB_VISITES smallint not null default 0 
     ,
     constraint PK_BIEN primary key (IDBIEN)
  ) 
go



/*      INDEX DE BIEN      */



/* -----------------------------------------------------------------------------
      TABLE : VILLE
----------------------------------------------------------------------------- */

create table VILLE
  (
     IDVILLE int identity (1, 1)   ,
     NOM_VILLE varchar(32)  not null  ,
     CODE_POSTAL int  not null  
     ,
     constraint PK_VILLE primary key (IDVILLE)
  ) 
go



/* -----------------------------------------------------------------------------
      TABLE : COMMERCIAL
----------------------------------------------------------------------------- */

create table COMMERCIAL
  (
     IDCOMMERCIAL smallint identity (1, 1)   ,
     NOM_COMMERCIAL varchar(20)  not null  ,
     PRENOM_COMMERCIAL varchar(20)  not null  ,
     TÉLÉPHONE_FIXE_PRO varchar(10)  not null  ,
     TÉLÉPHONE_MOBILE_PRO varchar(10)  not null  ,
     TÉLÉPHONE_PERSONNEL varchar(10)  null  ,
     EMAIL varchar(30)  not null  ,
     STATUT_COMMERCIAL char(32)  not null       CHECK (STATUT_COMMERCIAL in ('ACTIF', 'INACTIF'))
     ,
     constraint PK_COMMERCIAL primary key (IDCOMMERCIAL)
  ) 
go



/* -----------------------------------------------------------------------------
      TABLE : FICHE_DE_SOUHAITS
----------------------------------------------------------------------------- */

create table FICHE_DE_SOUHAITS
  (
     IDFICHESOUHAITS smallint identity (1, 1)   ,
     IDACHETEUR smallint  not null  ,
	 STATUT char(32) null CHECK(statut in ('EN COURS', 'OBSOLETE')) DEFAULT 'EN COURS',
     VILLE varchar(32) null,
     SURFACE_PARCELLE int  null  ,
     SURFACE_HABITABLE int  null  ,
     NB_PIÈCE int  null  ,
     NB_CHAMBRES int  null  ,
     NB_SALLEDEBAIN int  null  ,
     GARAGE bit  null  ,
     CAVE bit  null  ,
     BUDGET int  not null  
     ,
     constraint PK_FICHE_DE_SOUHAITS primary key (IDFICHESOUHAITS)
  ) 
go



/*      INDEX DE FICHE_DE_SOUHAITS      */



/* -----------------------------------------------------------------------------
      TABLE : VENDEUR
----------------------------------------------------------------------------- */

create table VENDEUR
  (
     IDVENDEUR smallint identity (1, 1)   ,
     IDVILLE int  not null  ,
     NOM_VENDEUR varchar(32)  not null  ,
     PRÉNOM_VENDEUR varchar(32)  not null  ,
     ADRESSE_VENDEUR varchar(32)  not null  ,
     TÉLÉPHONE_FIXE varchar(10)  not null  ,
     TÉLÉPHONE_MOBILE varchar(10) null  ,
     EMAIL varchar(20)  not null  ,
     CODE_POSTAL int not null  ,
     DATE_CREATION datetime NOT NULL DEFAULT (GETDATE()) 
     ,
     constraint PK_VENDEUR primary key (IDVENDEUR)
  ) 
go



/*      INDEX DE VENDEUR      */



/* -----------------------------------------------------------------------------
      TABLE : PROPOSITION_VISITE
----------------------------------------------------------------------------- */

create table PROPOSITION_VISITE
  (
     IDVISITE smallint identity (1, 1)   ,
     IDFICHESOUHAITS smallint  not null  ,
     IDBIEN smallint  not null  ,
     DATERDV datetime  not null  ,
	STATUT_PROPOSITION char(32) null CHECK(statut_proposition in ('ACCEPTEE', 'REFUSEE', 'EN ATTENTE')) DEFAULT 'EN ATTENTE',
     constraint PK_PROPOSITION_VISITE primary key (IDVISITE)
  ) 
go



/*      INDEX DE PROPOSITION_VISITE      */



/* -----------------------------------------------------------------------------
      TABLE : ACHETEUR
----------------------------------------------------------------------------- */

create table ACHETEUR
  (
     IDACHETEUR smallint identity (1, 1)   ,
     IDCOMMERCIAL smallint  not null  ,
     IDVILLE int  not null  ,
     NOM_ACHETEUR varchar(32)  not null  ,
     PRENOM_ACHETEUR varchar(32)  not null  ,
     ADRESSE varchar(32)  not null  ,
     EMAIL varchar(32)  not null  ,
     TÉLÉPHONE varchar(10)  not null  ,
     CODE_POSTAL int not null  ,
     TÉLÉPHONE_MOBILE varchar(10)  not null,
     DATE_CREATION datetime NOT NULL DEFAULT (GETDATE())    
     ,
     constraint PK_ACHETEUR primary key (IDACHETEUR)
  ) 
go



/*      INDEX DE ACHETEUR      */



/* -----------------------------------------------------------------------------
      TABLE : RECHERCHE_DANS
----------------------------------------------------------------------------- */

create table RECHERCHE_DANS
  (
     IDVILLE int  not null  ,
     IDFICHESOUHAITS smallint  not null  
     ,
     constraint PK_RECHERCHE_DANS primary key (IDVILLE, IDFICHESOUHAITS)
  ) 
go



/*      INDEX DE RECHERCHE_DANS      */



/* -----------------------------------------------------------------------------
      REFERENCES SUR LES TABLES
----------------------------------------------------------------------------- */



alter table RDV 
     add constraint FK_RDV_PROPOSITION_VISITE foreign key (IDVISITE) 
               references PROPOSITION_VISITE (IDVISITE)
go




alter table BIEN 
     add constraint FK_BIEN_VILLE foreign key (IDVILLE) 
               references VILLE (IDVILLE)
go




alter table BIEN 
     add constraint FK_BIEN_VENDEUR foreign key (IDVENDEUR) 
               references VENDEUR (IDVENDEUR)
go




alter table FICHE_DE_SOUHAITS 
     add constraint FK_FICHE_DE_SOUHAITS_ACHETEUR foreign key (IDACHETEUR) 
               references ACHETEUR (IDACHETEUR)
go




alter table VENDEUR 
     add constraint FK_VENDEUR_VILLE foreign key (IDVILLE) 
               references VILLE (IDVILLE)
go




alter table PROPOSITION_VISITE 
     add constraint FK_PROPOSITION_VISITE_FICHE_DE_SOUHAITS foreign key (IDFICHESOUHAITS) 
               references FICHE_DE_SOUHAITS (IDFICHESOUHAITS)
go




alter table PROPOSITION_VISITE 
     add constraint FK_PROPOSITION_VISITE_BIEN foreign key (IDBIEN) 
               references BIEN (IDBIEN)
go




alter table ACHETEUR 
     add constraint FK_ACHETEUR_COMMERCIAL foreign key (IDCOMMERCIAL) 
               references COMMERCIAL (IDCOMMERCIAL)
go




alter table ACHETEUR 
     add constraint FK_ACHETEUR_VILLE foreign key (IDVILLE) 
               references VILLE (IDVILLE)
go




alter table RECHERCHE_DANS 
     add constraint FK_RECHERCHE_DANS_VILLE foreign key (IDVILLE) 
               references VILLE (IDVILLE)
go




alter table RECHERCHE_DANS 
     add constraint FK_RECHERCHE_DANS_FICHE_DE_SOUHAITS foreign key (IDFICHESOUHAITS) 
               references FICHE_DE_SOUHAITS (IDFICHESOUHAITS)
go




/*
 -----------------------------------------------------------------------------
               FIN DE GENERATION
 -----------------------------------------------------------------------------
*/