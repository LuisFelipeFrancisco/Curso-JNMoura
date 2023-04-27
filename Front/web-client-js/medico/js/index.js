function getBaseURL(){
  return 'https://localhost:44341/api/medicos/';
}

function montarTr(medico){
  return `<tr><td>${medico.Codigo}</td>
              <td>${medico.Nome}</td>
              <td>${medico.DataNascimento}</td>
              <td>${medico.Crm}</tr></tr>`;
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

function create(){
  document.location = "create.html";
}