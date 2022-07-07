let elemento_usuario_logado = document.getElementById("usuario-logado");

const nome_usuario_logado = localStorage.getItem('usuarioLogado');
const sobrenomeUsuarioLogado = localStorage.getItem('sobrenomeUsuarioLogado');

elemento_usuario_logado.innerText = `Olá ${nome_usuario_logado} ${sobrenomeUsuarioLogado}`;

const logout = () => {
    localStorage.clear();
    window.location.assign("../index.html");
}

const loadContent = () => {
    
}