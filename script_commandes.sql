/*------------------------------------------------------------
*        Script SQLSERVER 
------------------------------------------------------------*/
/*------------------------------------------------------------
-- Table: client
------------------------------------------------------------*/
CREATE TABLE client(
	nom         VARCHAR (40) NOT NULL ,
	id_client   INT IDENTITY (1,1) NOT NULL ,
	prenom      VARCHAR (25) NOT NULL ,
	adresse     VARCHAR (400)  ,
	code_postal VARCHAR (25) NOT NULL ,
	id_commande INT  NOT NULL ,
	CONSTRAINT prk_constraint_client PRIMARY KEY NONCLUSTERED (id_client)
);


/*------------------------------------------------------------
-- Table: produit
------------------------------------------------------------*/
CREATE TABLE produit(
	id_produit  INT IDENTITY (1,1) NOT NULL ,
	nom         VARCHAR (25) NOT NULL ,
	description VARCHAR (400)  ,
	prix        DECIMAL (25,0)   ,
	CONSTRAINT prk_constraint_produit PRIMARY KEY NONCLUSTERED (id_produit)
);


/*------------------------------------------------------------
-- Table: commande
------------------------------------------------------------*/
CREATE TABLE commande(
	id_commande   INT IDENTITY (1,1) NOT NULL ,
	date_commande DATETIME  ,
	CONSTRAINT prk_constraint_commande PRIMARY KEY NONCLUSTERED (id_commande)
);


/*------------------------------------------------------------
-- Table: comprend
------------------------------------------------------------*/
CREATE TABLE comprend(
	quantite    INT   ,
	id_commande INT  NOT NULL ,
	id_produit  INT  NOT NULL ,
	CONSTRAINT prk_constraint_comprend PRIMARY KEY NONCLUSTERED (id_commande,id_produit)
);



ALTER TABLE client ADD CONSTRAINT FK_client_id_commande FOREIGN KEY (id_commande) REFERENCES commande(id_commande);
ALTER TABLE comprend ADD CONSTRAINT FK_comprend_id_commande FOREIGN KEY (id_commande) REFERENCES commande(id_commande);
ALTER TABLE comprend ADD CONSTRAINT FK_comprend_id_produit FOREIGN KEY (id_produit) REFERENCES produit(id_produit);
