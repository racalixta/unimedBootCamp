// aula09 - definição de tipos de variáveis personalizados
// comentado p/ o TS n dar erro 

// um type criado pelo DEV
type input = number | string;

function somarValores(input1: input, input2: input) {
  if(typeof input1 === 'string' && typeof input2 === 'string') {
    return `string1: ${input1.toString()},  string2: ${input2.toString()}`;
  } else {
    return `Soma Number: ${Number(input1) + Number(input2)}`
  }
}

console.log(somarValores(3, 5));

console.log(somarValores('abra', 'kadabra'));

console.log(somarValores('doisTipos', 1));







