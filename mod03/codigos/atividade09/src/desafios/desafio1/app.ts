/*
desafio 1 - Como podemos rodar isso em um arquivo .ts sem causar erros? 

let employee = {};
employee.code = 10;
employee.name = "John";
*/

// primeiro modo

let employee = {
  code: 10,
  name: 'John'
}

// segundo modo

let employee2: {code: number, name: string} = {
  code: 20,
  name: 'John'
}

// terceiro modo

interface Employee {
  code: number,
  name: string
}

let employee3: Employee = {
  code: 30,
  name: 'John'
 }


