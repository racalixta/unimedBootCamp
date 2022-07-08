"use strict";
// aula06 - Relação entre tipos e variáveis
let button = document.querySelector('.btn');
let input1 = document.getElementById('input1');
let input2 = document.getElementById('input2');
let devePrintar = true;
let frase = 'O valor é: ';
function somarNumeros(num1, num2, devePrintar, frase) {
    let resultado = num1 + num2;
    if (devePrintar) {
        console.log(frase + resultado);
    }
    return num1 + num2;
}
if (button) {
    button.addEventListener('click', () => {
        if (input1 && input2) {
            console.log(somarNumeros(Number(input1.value), Number(input2.value), devePrintar, frase));
        }
    });
}
