"use strict";
// aula14 - como funciona o tipo never e o comando throw
// o type never é um código que foi interrompido abruptamente antes do final
function jogaErro(erro, codigo) {
    throw { error: erro, code: codigo };
}
jogaErro('ERROR!', 505);
