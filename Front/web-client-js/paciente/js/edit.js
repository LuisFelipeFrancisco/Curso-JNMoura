window.onload = function () {
  let parametros = new URLSearchParams(window.location.search);
  let codigo = parametros.get("codigo");
  getById(codigo);
};

function back() {
    document.location = "index.html";
}

function put() {
    let endpoint = `${getBaseURL()}${getLabelCodigo().innerHTML}`;
    fetch(endpoint, {
        method: "PUT",
        headers: {
            "Content-Type": "application/json",
        },
        body: JSON.stringify(getPaciente()),
    })
        .then((resposta) => tratarReposta(resposta))
        .then((paciente) => tratarRepostaPut(paciente))
        .catch((erro) => exibirMensagemErro(erro));
}

function tratarRepostaPut(paciente) {
    alert(`Paciente ${paciente.Nome} atualizado com sucesso!`);
    back();
}

function getPaciente() {
    return {
        Codigo: getLabelCodigo().innerHTML,
        Nome: getInputNome().value,
        Email: getInputEmail().value,
    };
}

function getBaseURL() {
    return "https://localhost:44341/api/Pacientes/";
}

function getById(codigo) {
    let endpoint = `${getBaseURL()}${codigo}`;
    fetch(endpoint)
        .then((resposta) => tratarReposta(resposta))
        .then((paciente) => exibirPaciente(paciente))
        .catch((erro) => exibirMensagemErro(erro));
}

function tratarReposta(resposta) {
    if (resposta.status === 200)
        return resposta.json();
    else
        throw resposta.status;
}

function exibirPaciente(paciente) {
    getInputNome().value = paciente.Nome;
    getInputEmail().value = paciente.Email;
    getLabelCodigo().innerHTML = paciente.Codigo;
}

function exibirMensagemErro(erro) {
    let mensagemCompleta = "";
    switch (erro) {
        case 404:
            mensagemCompleta = "Paciente não encontrado!";
            break;
        case 400:
            mensagemCompleta = "Dados inválidos\nVerifique os campos obrigatórios e tente novamente.";
            break;
        default:
            mensagemCompleta = "Ocorreu um erro: " + erro + "\n Entre em contato com suporte.";
            break;
    }
    alert(mensagemCompleta);
}

function getInputNome() {
    return document.querySelector("#Nome");
}

function getInputEmail() {
    return document.querySelector("#Email");
}

function getLabelCodigo() {
    return document.querySelector("#Codigo");
}