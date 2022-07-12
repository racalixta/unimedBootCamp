"use strict";
// aula08 - Sobre o tipo de variável any
let valorAny;
// o type 'any' é um tipo que pode receber qualquer tipo
valorAny = 3;
console.log(`number: ${valorAny}`);
valorAny = 'olá';
console.log(`string: ${valorAny}`);
valorAny = true;
console.log(`boolean: ${valorAny}`);
let valorString = 'valorStr';
let valorString2 = 'valorStr2-';
valorString = valorAny;
// funcionou mesmo valorAny sendo boolean (nesse momento) - any seria um coringa
// porem 'any' vai contra a parte principal do TypeScript
// demonstração do valor 'any'(contem boolean) entrando em um function q é apenas string
function somarString(string1, string2) {
    console.log(`valorString2 -> ${string1 + string2} <- valorAny`);
}
// demonstração no console
somarString(valorString2, valorAny);
