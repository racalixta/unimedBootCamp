// aula07 - Lidando om objeto, enum e interface
// comentado p/ n dar erro TS

/*
const pessoa = {
  nome: 'Mariana',
  idade: 28,
  profissao: 'Desenvolvedora'
}

//pessoa.idade = '29';
// ^^ irá dar erro pois mudou o tipo de dado, começou number e foi p/ string

pessoa.idade = 25; 
// da certo pq mudou o tipo 
//----------------------------------------------------------------------------------

// exemplo para demontrar os "Problemas" nesse modo de criaçao
let andre: (nome: string, idade: number, profissao: string) => {
  nome: 'andre',
  idade: 34,
  profissao: 'Professor'
}

let paula: (nome: string, idade: number, profissao: string) => {
  nome: 'Julia',
  idade: 34,
  profissao: 'Designer'
}

//----------------------------------------------------------------------------------
// basicamente o enum é um grupo criado pelo dev, p/ se ter constantes
enum Profissao {
  Professora,
  Atriz,
  Desenvolvedora,
  Designer
}

interface Pessoa {
  nome: string,
  idade: number,
  profissao?: Profissao
}

// p/ criar-se listas, deve-se colocar o tipo e []: string[], number[], ...
interface Estudante extends Pessoa {
  materias: string[],
}

const vanessa: Pessoa = {
  nome: 'Vanessa',
  idade: 23,
  profissao: Profissao.Desenvolvedora
}

const maria: Pessoa = {
  nome: 'Maria',
  idade: 27,
  profissao: Profissao.Desenvolvedora
}

const jessica: Estudante = {
  nome: 'Jessica',
  idade: 20,
  profissao: Profissao.Desenvolvedora,
  materias: ['Matemática 1','Programação']
}

const monica: Estudante = {
  nome: 'Monica',
  idade: 19,
  materias: ['Matemática 3','Derivada', 'Física']
}

// -------------------------------------------------------------------

function listar(lista: string[]) {
  for(const item of lista) {
    console.log('-> ', item);
  }
}

listar(monica.materias);

*/


