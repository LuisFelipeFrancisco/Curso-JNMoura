/* 
function calcular() {
    var num1 = Number(document.querySelector('input[id="num1"]').value);
    var num2 = Number(document.querySelector('input[id="num2"]').value);
    var operacao = document.querySelector('select[id="operacao"]').value;
    var resultado;
    if (operacao == "somar") {
        resultado = num1 + num2;
    } else if (operacao == "subtrair") {
        resultado = num1 - num2;
    } else if (operacao == "multiplicar") {
        resultado = num1 * num2;
    } else if (operacao == "dividir") {
        resultado = num1 / num2;
    }
    document.querySelector('#resultado').value = resultado;
}

Com Switch
function calcular() {
    var num1 = Number(document.querySelector('input[id="num1"]').value);
    var num2 = Number(document.querySelector('input[id="num2"]').value);
    var operacao = document.querySelector('select[id="operacao"]').value;
    var resultado;
    switch (operacao) {
        case "somar":
            resultado = num1 + num2;
            break;
        case "subtrair":
            resultado = num1 - num2;
            break;
        case "multiplicar":
            resultado = num1 * num2;
            break;
        case "dividir":
            resultado = num1 / num2;
            break;
    }
    document.querySelector('#resultado').value = resultado;
}
*/

function getNum1() {
    return document.getElementById("num1").value;
}

function getNum2() {
    return document.getElementById("num2").value;
}

function somar() {
    let resultado = Number(getNum1()) + Number(getNum2());
    document.getElementById("resultado").value = resultado;
}

function subtrair() {
    let resultado = Number(getNum1()) - Number(getNum2());
    document.getElementById("resultado").value = resultado;
}

function multiplicar() {
    let resultado = Number(getNum1()) * Number(getNum2());
    document.getElementById("resultado").value = resultado;
}

function dividir() {
    let resultado = Number(getNum1()) / Number(getNum2());
    document.getElementById("resultado").value = resultado;
}