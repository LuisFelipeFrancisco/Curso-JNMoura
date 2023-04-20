/* 
let portaCor;
let ultimaPortaAzul = "azul-fechada";
let ultimaPortaBranca = "branca-fechada";
let ultimaPortaVermelha = "vermelha-fechada"; 
*/

/*
Cria um objeto com as imagens de cada porta, que tem as propriedades azul, branca e vermelha. (cores)
Cada cor tem as propriedades aberta e fechada, que são as imagens de cada porta.
Na função abrir/fechar, é criado um array-like com todos os inputs, depois é transformado em array com o Array.from.
Depois é filtrado o array para retornar apenas o input que está checked.
*/

const obj = {
    azul: {
        aberta: './img/porta-azul-aberta.jpg',
        fechada: './img/porta-azul-fechada.jpg',
    },
    branca: {
        aberta: './img/porta-branca-aberta.jpg',
        fechada: './img/porta-branca-fechada.jpg',
    },
    vermelha: {
        aberta: './img/porta-vermelha-aberta.jpg',
        fechada: './img/porta-vermelha-fechada.jpg',
    }
}

function getInputs(){
    const b = Array.from(document.querySelectorAll("input"));
    a = b.filter((item) => item.checked)
    return a[0].value;
}

function abrir(){
    getInputs();
    document.querySelector("#porta").src = obj[a[0].value].aberta;
}

function fechar(){
    getInputs();
    document.querySelector("#porta").src = obj[a[0].value].fechada;
}
/* 
function abrir(){
    // Criando um array-like com todos os inputs do html e transformando em array com o Array.from
    const b = Array.from(document.querySelectorAll("input"));
    // Filtrando o array para retornar apenas o input que está checked
    a = b.filter((item) => item.checked)
    if(a[0].value == "azul"){
        portaCor = "azul-aberta"
        document.querySelector("#porta").src = `./img/porta-${portaCor}.jpg`;
        ultimaPortaAzul = portaCor;
    }else if(a[0].value == "branca"){
        portaCor = "branca-aberta"
        document.querySelector("#porta").src = `./img/porta-${portaCor}.jpg`;
        ultimaPortaBranca = portaCor;
    }else if(a[0].value == "vermelha"){
        portaCor = "vermelha-aberta"
        document.querySelector("#porta").src = `./img/porta-${portaCor}.jpg`;
        ultimaPortaVermelha = portaCor;
    }
}

function fechar(){
    const b = Array.from(document.querySelectorAll("input"));
    a = b.filter((item) => item.checked)
    if(a[0].value == "azul"){
        portaCor = "azul-fechada"
        document.querySelector("#porta").src = `./img/porta-${portaCor}.jpg`;
        ultimaPortaAzul = portaCor;
    }else if(a[0].value == "branca"){
        portaCor = "branca-fechada"
        document.querySelector("#porta").src = `./img/porta-${portaCor}.jpg`;
        ultimaPortaBranca = portaCor;
    }else if(a[0].value == "vermelha"){
        portaCor = "vermelha-fechada"
        document.querySelector("#porta").src = `./img/porta-${portaCor}.jpg`;
        ultimaPortaVermelha = portaCor;
    }
}

function portaAzul(){
    document.querySelector("#porta").src = `./img/porta-${ultimaPortaAzul}.jpg`;
}

function portaBranca(){
    document.querySelector("#porta").src = `./img/porta-${ultimaPortaBranca}.jpg`;

}

function portaVermelha(){
    document.querySelector("#porta").src = `./img/porta-${ultimaPortaVermelha}.jpg`;
}

document.querySelector("#azul").onclick = portaAzul;
document.querySelector("#branca").onclick = portaBranca;
document.querySelector("#vermelha").onclick = portaVermelha; 
*/
document.querySelector("#btnAbrir").onclick = abrir;
document.querySelector("#btnFechar").onclick = fechar;
/* Tiosso
funciton abrir(){
    let cor = getCorPorta();
    setImagemPorta(cor, "aberta");
}

function fechar(){
    let cor = getCorPorta();
    setImagemPorta(cor, "fechada");
}

function getCorPorta(){
    return document.querySelector("input[name='cor']:checked").value;
}

function setImagemPorta(cor, estado){
    document.querySelector("#porta").src = `./img/porta-${cor}-${estado}.jpg`;
} 
*/