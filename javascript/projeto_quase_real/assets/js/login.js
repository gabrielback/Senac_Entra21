let elementoLogin = document.getElementById('login');
let elementoSenha = document.getElementById('senha');

// const verificarLogin = (login, senha) => login == 'maria' && senha == '' ? true : false;

const verificarLogin = (login, senha) => {
    if(login == 'maria' && senha == '') {
        localStorage.setItem('usuarioLogado', 'maria')
        localStorage.setItem('sobrenomeUsuarioLogado', 'Da Silva')
        return true
    }
        return false
}

const apresentaMensagemErro = () => alert('Não foi possível logar!');

const realizarLogin = () => {
    const login = elementoLogin.value;
    const senha = elementoSenha.value;
    if (verificarLogin(login, senha)) {
        // window.location.href = './views/home.html';
        window.location.assign("./views/home.html");
    }else {

        apresentaMensagemErro();
    }
}