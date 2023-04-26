function get() {
  let endpoint = "https://localhost:44341/api/Medicos";
  fetch(endpoint)
    .then((response) => response.json()) // Transforma a resposta em JSON
    .then((medicos) => {
      let trs = '';
      medicos.forEach((medico) => {
        trs += `<tr><td>${medico.Codigo}</td>
                <td>${medico.Nome}</td>
                <td>${medico.DataNascimento}</td>
                <td>${medico.Crm}</tr></tr>`;
        document.querySelector("#dadosTabelaMedico").innerHTML = trs;
      });
    });
}
