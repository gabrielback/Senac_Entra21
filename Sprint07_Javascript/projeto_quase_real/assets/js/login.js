let elementoLogin = document.getElementById('login');
let elementoSenha = document.getElementById('senha');
const apresentaMensagemErro = () => alert('Não foi possível logar!');


const verificarLogin = (login, senha) => {
    if(login == 'gabriel' && senha == '') {
        localStorage.setItem('usuarioLogado', 'Gabriel')
        localStorage.setItem('sobrenomeUsuarioLogado', 'Back')
        return true
    }
        return false
}


const realizarLogin = () => {
    const login = elementoLogin.value.toLowerCase();
    console.log(login)
    const senha = elementoSenha.value;
    if (verificarLogin(login, senha)) {
        // window.location.href = './views/home.html';
        window.location.assign("./views/home.html");
    }else {
        apresentaMensagemErro();
    }
}