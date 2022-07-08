// aula06 - Relação entre tipos e variáveis

let button = document.querySelector('.btn') as HTMLButtonElement;
let input1 = document.getElementById('input1') as HTMLInputElement;
let input2 = document.getElementById('input2') as HTMLInputElement;
let devePrintar = true;
let frase = 'O valor é: '

function somarNumeros(num1: number, num2: number, devePrintar: Boolean, frase: string) {
  let resultado = num1 + num2;
  if(devePrintar) {
    console.log(frase + resultado)
  }
  return num1 + num2;
}


if(button) {
  button.addEventListener('click', () => {
    if(input1 && input2){
      console.log(somarNumeros(Number(input1.value), Number(input2.value), devePrintar, frase));
    }
  });

}

