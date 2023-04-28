function getBaseURL(){
  return 'https://localhost:44341/api/medicos/';
}

function montarTr(medico){
  return `<tr><td>${medico.Codigo}</td>
              <td>${medico.Nome}</td>
              <td>${converteData(medico.DataNascimento)}</td>
              <td>${medico.Crm}</td>
              <td><a class='pure-menu-link' href="Javascript:editar(${medico.Codigo})">Editar</a></td>
              <td><a class='pure-menu-link' href="Javascript:desejaExcluir(${medico.Codigo})">Excluir</a></td></tr>`;
}

function converteData(data){
  if (data == null)
    return '';
  else{ 
    // return data.split("T")[0].split("-").reverse().join("/");
    let dataFormatada = new Date(data);
    return dataFormatada.toLocaleDateString();
  }
}

function getTabelaMedico(){
  return document.querySelector("#dadosTabelaMedico");
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
  getTabelaMedico().innerHTML = "";
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
    .then((medico) => exibirMedico(medico))
    .catch((erro) => exibirMensagemErro(erro));
}

function exibirMedico(medico){
  getTabelaMedico().innerHTML = montarTr(medico);
}

function getAll() {
  let endpoint = getBaseURL();
  fetch(endpoint)
    .then((response) => tratarRetorno(response))
    .then((medicos) => exibirMedicos(medicos))
    .catch((erro) => exibirMensagemErro(erro));
}

function exibirMedicos(medicos) {
  let trs = "";
  medicos.forEach((medico) => {
    trs += montarTr(medico);
    getTabelaMedico().innerHTML = trs;
  });
}

function exibirMensagemErro(erro) {
  if (erro === 404 || erro === 400)
    alert('Médico não encontrado.');
  else
    alert('Ocorreu um erro ao processar a requisição:\n' + erro + '\nEntre em contato com o suporte.');
}

function create() {
  document.location = "create.html";
}

function editar(codigo) {
  document.location = `edit.html?codigo=${codigo}`;
}

function desejaExcluir(codigo) {
  if (confirm("Deseja realmente excluir o médico?")) {
    excluir(codigo);
  }
}

function excluir(codigo) {
  let endpoint = `${getBaseURL()}${codigo}`;
  fetch(endpoint, {
    method: "DELETE",
  })
    .then((response) => tratarRespostaExcluir(response))
    .catch((erro) => exibirMensagemErro(erro));
}

function tratarRespostaExcluir(response) {
  if (response.status === 200) {
    alert("Médico excluído com sucesso!");
    get();
  } else throw response.status;
}
