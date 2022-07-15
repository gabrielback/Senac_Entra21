// exibir_load(true)
let produtos = []
fetch('../json/hobbies.json')
.then(response => response.json())
.then(data => {
    vetorProduto = data ;
    exibirProdutos(data);
    produtos = data
    // console.log(data);
})
.catch( error => { // para status de erro
    console.error('algo deu errado na requisição', error);
    document.getElementsByName('#erro').innerHTML = "Algo não está certo";

} 
).finally(() => {
    // exibir_load(false)
    console.warn('Sempre cai aqui')
})
