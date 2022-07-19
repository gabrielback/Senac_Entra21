// exibir_load(true)

async function getData(){
    await fetch('https://economia.awesomeapi.com.br/json/daily/USD-BRL')
    .then( response => response.json())
    .then(data => {
        dolar = parseFloat(data[0].bid).toFixed(2)
    })

    await fetch('../json/hobbies.json')
        .then(response => response.json())
        .then(data => {
            vetorProduto = data ;
            vetorFiltrado = data.filter(emEstoque)
            vetorProdutoEmDolar = data.map(converterEmDolar)
            vetorFiltradoEmDolar = data.filter(emEstoque).map(converterEmDolar)
            exibirProdutos(data);
    
        })
        .catch( error => { // para status de erro
            console.error('algo deu errado na requisição', error);
            document.getElementsByName('#erro').innerHTML = "Algo não está certo";
            
        } 
        ).finally(() => {
            // exibir_load(false)
            console.warn('finally')
        })
        
    
}    

getData()

// // .then(data => {
//     dolar = parseFloat(data[0].bid).toFixed(2)    
// })
