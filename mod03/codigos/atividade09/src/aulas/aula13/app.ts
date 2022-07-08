// aula13 - any está de volta e sobre unknow

let anyPt2: any;
anyPt2 = 8;
anyPt2 = 'valorAny é como se fosse o JS normal';
anyPt2 = true;

let stringTest: string = 'controle';
stringTest = anyPt2;


let valorUnknow: unknown;
valorUnknow = 13;
valorUnknow = 'Ate aqui se parece com any';
valorUnknow = true;
valorUnknow = 'parte2 do str';

let stringTest2: string = 'controle';
//stringTest2 = valorUnknow;
// ^^ esse modo da erro, pois o unknow exige uma verificação do tipo, como mostra abaixo
if(typeof valorUnknow === 'string') {
  stringTest2 = valorUnknow;
}


