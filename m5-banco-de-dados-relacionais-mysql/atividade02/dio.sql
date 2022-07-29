/*
  UTILIZANDO O COMMAND LINE pelo xampp terminal

  mysql -u root

  show databases;

  use dio_mysql;

  show tables;






*/

/*aula01        ----------------------------------------------------------------- */
CREATE TABLE cursos(id_cursos INT NOT NULL PRIMARY KEY AUTOINCREMENT, nome VARCHAR(10));

INSERT INTO cursos (nome) VALUES ('MySQL');
INSERT INTO cursos (nome) VALUES ('HTML');
INSERT INTO cursos (nome) VALUES ('CSS');

SELECT * FROM cursos;

UPDATE cursos SET nome='HTML 5' WHERE id_cursos=2;


/*aula02       -----------------------------------------------------------------   */
INSERT INTO cursos (nome) VALUES ('Economia');

SELECT * FROM cursos WHERE nome='Economia';

DELETE FROM cursos WHERE nome='Economia';

/* cirando uma nova coluna */
ALTER TABLE cursos ADD carga_horaria INT(2);

/* definiu a CH p/ todos*/
UPDATE cursos SET carga_horaria=20;

UPDATE cursos SET carga_horaria=40 WHERE id_cursos=2;

/*

  DELETANDO UMA TABLE

MariaDB [dio_mysql]> show tables;
+---------------------+
| Tables_in_dio_mysql |
+---------------------+
| cursos              |
| pessoa              |
| pessoas             |
+---------------------+

DROP TABLE pessoas;

MariaDB [dio_mysql]> show tables;



  DELETANDO UM DATABASE

DROP DATABASE nome;

*/



/*aula03       -----------------------------------------------------------------   */

/*
  criou-se a tabela de videos e a tabela author

  apos fazer as modificções p/ receber o id_author na tabela videos em author:

  isso na tabela videos
*/

SELECT * FROM `videos` JOIN author ON videos.fk_author = author.id_author;

/* para pegar apenas titulo e nome do author */
SELECT videos.title, author.name FROM `videos` JOIN author ON videos.fk_author = author.id_author;

/*depois de criar a tabela seo e as modificoes p/ fazer a relação com a tabela videos*/

/* juntando as tabelas videos e seo, onde videos.fk_seo é igual a seo.id_seo*/
SELECT * FROM `videos` JOIN seo ON videos.fk_seo = seo.id_seo;

/* buscando apenas o videos.title e seo.category */
SELECT videos.title, seo.category FROM `videos` JOIN seo ON videos.fk_seo = seo.id_seo;

/* buscando o anterior e juntando o nome do author do video*/
SELECT videos.title, author.name, seo.category FROM `videos` JOIN seo ON videos.fk_seo = seo.id_seo 
JOIN author ON videos.fk_author = author.id_author;


/* pos criacao das tabelas playlist de videos_playlist, juntando todas as informações*/
SELECT playlist.name_playlist, videos.title FROM `playlist` 
JOIN videos_playlist ON playlist.id_playlist = videos_playlist.fk_playlist 
JOIN videos ON videos.id_video = videos_playlist.fk_videos;

/* juntando o author na busca acima*/
SELECT playlist.name_playlist, videos.title, author.name FROM `playlist` 
JOIN videos_playlist ON playlist.id_playlist = videos_playlist.fk_playlist 
JOIN videos ON videos.id_video = videos_playlist.fk_videos
JOIN author ON videos.fk_author = author.id_author;


/* buscando o author da playlist e o nome da playlist*/
SELECT author.name, playlist.name_playlist FROM playlist JOIN author ON playlist.fk_author = author.id_author;




