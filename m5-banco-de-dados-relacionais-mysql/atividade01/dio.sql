/* criando a tabela */
CREATE TABLE pessoa (
  id INT NOT NULL PRIMARY KEY AUTOINCREMENT,
  nome VARCHAR(30) NOT NULL,
  nascimento DATE
)

/* inserindo novas pessoas*/
INSERT INTO pessoa (nome, nascimento) VALUES ('Nathally', '1990-05-22')
INSERT INTO pessoa (nome, nascimento) VALUES ('Diogo', '1996-09-13')
INSERT INTO pessoa (nome, nascimento) VALUES ('Maria', '2000-02-08')


/* editando */
UPDATE pessoas SET nome=’Nathally Souza’ WHERE id=1;

/* deletando */
DELETE FROM pessoas WHERE id=5;

/* ordernado */
SELECT * FROM `pessoa` ORDER BY nome /*normal*/
SELECT * FROM `pessoa` ORDER BY nome DESC /* descrescente */


/* adicionando uma nova seção*/
ALTER TABLE `pessoa` ADD `genero` VARCHAR(1) NOT NULL AFTER `nascimento`;


/* ATUALIZANDO o genero das pessoas*/
UPDATE pessoa SET genero='F' WHERE id=1;
UPDATE pessoa SET genero='M' WHERE id=2;
UPDATE pessoa SET genero='F' WHERE id=3;
UPDATE pessoa SET genero='M' WHERE id=4;
UPDATE pessoa SET genero='M' WHERE id=6;

/*agrupando pelo genero e contando a qnt de ids por genero*/
SELECT COUNT(id), genero FROM `pessoa` GROUP BY genero;


