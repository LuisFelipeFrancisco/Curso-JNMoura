function back(){
    document.location.href = "index.html";
}

function getDados(){
    return {
        Nome: getInputNome().value,
        Crm: getInputCrm().value,
        DataNascimento: getInputDataNascimento().value,
    };
}

function getInputNome(){
    return document.querySelector("#Nome");
}

function getInputCrm(){
    return document.querySelector("#Crm");
}

function getInputDataNascimento(){
    return document.querySelector("#DataNascimento");
}

function post(){
    let endpoint = "https://localhost:44341/api/Medicos";
    let dados = getDados();
    fetch(endpoint, {
        method: "POST",
        headers: {
            "Content-Type": "application/json"
        },
        body: JSON.stringify(dados)
    })
    .then(response => tratarRetorno(response))
    .catch(error => exibirMensagemErro(error));
}

function tratarRetorno(response){
    if (response.status === 200){
      exibirMensagemSucesso();
      back();
    } else
        throw response.status;
}

function exibirMensagemSucesso(){
    alert("Médico cadastrado com sucesso!");
}

function exibirMensagemErro(erro){
    if (erro === 400 || erro === 404)
        alert("Dados inválidos\nVerifique os campos obrigatorios e tente novamente.");
    else
        alert("Ocorreu um erro\n" + erro + "\nEntre em contato com o suporte.");
}