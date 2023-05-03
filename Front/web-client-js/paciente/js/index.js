function getBaseURL(){
    return 'https://localhost:44341/api/Pacientes/';
}

function montarTr(paciente){
    return `<tr><td>${paciente.Codigo}</td>
                <td>${paciente.Nome}</td>
                <td>${paciente.Email}</td>
                <td><a class='pure-menu-link' href="Javascript:editar(${paciente.Codigo})">Editar</a></td>
                <td><a class='pure-menu-link' href="Javascript:desejaExcluir(${paciente.Codigo})">Excluir</a></td></tr>`;
}

function getTabelaPaciente(){
    return document.querySelector("#dadosTabelaPaciente");
}

function getInputs(){
    return document.querySelector("#codigo");
}

function tratarRetorno(response){
    if (response.status === 200)
        return response.json();
    else
        throw response.status;
}

function get(){
    getTabelaPaciente().innerHTML = "";
    let id = getInputs().value;
    if (id == "") {
        getAll();
    } else {
        getId(id);
    }
}

function getId(id){
    let endpoint = getBaseURL() + id;
    fetch(endpoint)
        .then((response) => tratarRetorno(response))
        .then((paciente) => exibirPaciente(paciente))
        .catch((erro) => exibirMensagemErro(erro));
}

function exibirPaciente(paciente){
    getTabelaPaciente().innerHTML = montarTr(paciente);
}

function getAll(){
    let endpoint = getBaseURL();
    fetch(endpoint)
        .then((response) => tratarRetorno(response))
        .then((pacientes) => exibirPacientes(pacientes))
        .catch((erro) => exibirMensagemErro(erro));
}

function exibirPacientes(pacientes){
    pacientes.forEach((paciente) => {
        getTabelaPaciente().innerHTML += montarTr(paciente);
    });
}

function exibirMensagemErro(erro){
    if (erro == 404 || erro == 400)
        alert("Paciente não encontrado!");
    else
    alert('Ocorreu um erro ao processar a requisição:\n' + erro + '\nEntre em contato com o suporte.');
}

function create(){
    document.location = "create.html";
}

function editar(codigo){
    document.location = "edit.html?codigo=" + codigo;
}

function desejaExcluir(codigo){
    if (confirm("Deseja excluir o paciente?")){
        excluir(codigo);
    }
}

function excluir(codigo){
    let endpoint = `${getBaseURL()}${codigo}`;
    fetch(endpoint, {method: "DELETE"})
        .then((response) => tratarRespostaExcluir(response))
        .catch((erro) => exibirMensagemErro(erro));
}

function tratarRespostaExcluir(response){
    if (response.status == 200){
        alert("Paciente excluído com sucesso!");
        get();
    } else throw response.status;
}