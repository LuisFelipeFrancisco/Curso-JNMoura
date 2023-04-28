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
    body: JSON.stringify(getMedico()),
  })
    .then((resposta) => tratarReposta(resposta))
    .then((medico) => tratarRepostaPut(medico))
    .catch((erro) => exibirMensagemErro(erro));
}

function tratarRepostaPut(medico) {
  alert(`Médico ${medico.Nome} atualizado com sucesso!`);
  back();
}

function getMedico() {
  return {
    Codigo: getLabelCodigo().innerHTML,
    Nome: getInputNome().value,
    Crm: getInputCRM().value,
    DataNascimento: getInputDataNascimento().value,
  };
}

function getBaseURL() {
  return "https://localhost:44341/api/Medicos/";
}

function getById(codigo) {
  let endpoint = `${getBaseURL()}${codigo}`;
  fetch(endpoint)
    .then((resposta) => tratarReposta(resposta))
    .then((medico) => exibirMedico(medico))
    .catch((erro) => exibirMensagemErro(erro));
}

function tratarReposta(resposta) {
  if (resposta.status === 200) 
    return resposta.json();
  else 
    throw resposta.status;
}

function exibirMedico(medico) {
  getInputNome().value = medico.Nome;
  getInputCRM().value = medico.Crm;
  if (medico.DataNascimento != null)
    getInputDataNascimento().value = medico.DataNascimento.split("T")[0];
  getLabelCodigo().innerHTML = medico.Codigo;
}

function exibirMensagemErro(erro) {
  let mensagemCompleta = "";
  if (erro === 400) {
    mensagemCompleta = "Dados inválidos\nVerifique os campos obrigatórios e tente novamente.";
  } else if (erro === 404) {
    mensagemCompleta = "Médico não encontrado";
    back();
  } else
    mensagemCompleta = "Ocorreu um erro: " + erro + "\n Entre em contato com suporte.";
  alert(mensagemCompleta);
}

function getInputNome() {
  return document.querySelector("#Nome");
}

function getInputCRM() {
  return document.querySelector("#Crm");
}

function getInputDataNascimento() {
  return document.querySelector("#DataNascimento");
}

function getLabelCodigo() {
  return document.querySelector("#Codigo");
}
