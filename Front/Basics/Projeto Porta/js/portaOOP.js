/* Orientado a Objetos */
class Porta{
    constructor(){
        this.estado = '';
        this.cor = '';
    }

    abrir(){
        this.estado = 'aberta';
    }

    fechar(){
        this.estado = 'fechada';
    }

    pintar(cor){
        this.cor = cor;
    }

    getCor(){
        return this.cor;
    }

    getEstado(){
        return this.estado;
    }
}