// a função gets é implementada dentro do sistema para ler as entradas(inputs) dos dados e a função print para imprimir a saída(output) de dados.
// Abaixo segue um exemplo de código que você pode ou não utilizar

const lines = 9230.01;
const salary = Number(lines);
let percent;

//TODO: Complete os espaços em branco com uma possível solução para o problema

if (salary <= 400.00) {
  percent = 15;
} else if (salary >= 400.01 && salary <= 800.00) {
  percent = 12;
} else if (salary >= 800.01 && salary <= 1200.00) {
  percent = 10;
} else if (salary >= 1200.01 && salary <= 2000.00) {
  percent = 7;
} else {
  percent = 4;
}

const reajust = (salary * percent) / 100;
const newSalary = salary + reajust;
console.log("Novo salario: " + newSalary.toFixed(2));
console.log("Reajuste ganho: " + reajust.toFixed(2));
console.log("Em percentual: " + percent + " %");


/*
0 - 400.00                  15%
400.01 - 800.00             12%
800.01 - 1200.00            10%
1200.01 - 2000.00           7%
Acima de 2000.00            4%
*/