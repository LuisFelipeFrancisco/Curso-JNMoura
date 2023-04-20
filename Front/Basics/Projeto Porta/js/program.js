const porta = new Porta();

function abrir(){
    porta.abrir();
    porta.pintar(getCorPorta());
    setImagemPorta();
}

function fechar(){
    porta.fechar();
    porta.pintar(getCorPorta());
    setImagemPorta();
}

function getCorPorta(){
    return document.querySelector('input[name="cor"]:checked').value;
}

function setImagemPorta(){
    imagem.src = `./img/porta-${porta.getCor()}-${porta.getEstado()}.jpg`;
}

document.querySelector('#btnAbrir').onclick = abrir;
document.querySelector('#btnFechar').onclick = fechar;