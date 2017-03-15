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
	adresse     VARCHAR (400) NOT NULL ,
	code_postal VARCHAR (25) NOT NULL ,
	CONSTRAINT prk_constraint_client PRIMARY KEY NONCLUSTERED (id_client)
);


/*------------------------------------------------------------
-- Table: commande
------------------------------------------------------------*/
CREATE TABLE commande(
	id_commande   INT IDENTITY (1,1) NOT NULL ,
	date_commande DATETIME  ,
	id_client     INT  NOT NULL ,
	CONSTRAINT prk_constraint_commande PRIMARY KEY NONCLUSTERED (id_commande)
);


/*------------------------------------------------------------
-- Table: produit
------------------------------------------------------------*/
CREATE TABLE produit(
	id_produit  INT IDENTITY (1,1) NOT NULL ,
	nom         VARCHAR (25) NOT NULL ,
	description VARCHAR (400) NOT NULL ,
	prix        DECIMAL (8,2)  NOT NULL ,
	CONSTRAINT prk_constraint_produit PRIMARY KEY NONCLUSTERED (id_produit)
);


/*------------------------------------------------------------
-- Table: comprend
------------------------------------------------------------*/
CREATE TABLE comprend(
	id_commande INT  NOT NULL ,
	id_produit  INT  NOT NULL ,
	CONSTRAINT prk_constraint_comprend PRIMARY KEY NONCLUSTERED (id_commande,id_produit)
);



ALTER TABLE commande ADD CONSTRAINT FK_commande_id_client FOREIGN KEY (id_client) REFERENCES client(id_client);
ALTER TABLE comprend ADD CONSTRAINT FK_comprend_id_commande FOREIGN KEY (id_commande) REFERENCES commande(id_commande);
ALTER TABLE comprend ADD CONSTRAINT FK_comprend_id_produit FOREIGN KEY (id_produit) REFERENCES produit(id_produit);
