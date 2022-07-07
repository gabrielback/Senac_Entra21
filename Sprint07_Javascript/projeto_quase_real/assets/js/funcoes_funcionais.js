const vetorProduto = 
[
    {
        "produto": "Produto 01",
        "preco": 3.65,
        "descrição": "Loren ipsum!",
        "em_estoque": true,
        "img": "assets/imgs/img001.jpg"
    },
    {
        "produto": "Produto 02",
        "preco": 100.00,
        "descrição": "Loren ipsum! Not ipsum!",
        "em_estoque": false,
        "img": "assets/imgs/img002.jpg"
    },
    {
        "produto": "Produto 03",
        "preco": 0.90,
        "descrição": "Loren ipsum! Not ipsum!",
        "em_estoque": true,
        "img": "assets/imgs/img003.jpg"
    },
    {
        "produto": "Produto 04",
        "preco": 0.90,
        "descrição": "Loren ipsum! Not ipsum!",
        "em_estoque": false,
        "img": "assets/imgs/img003.jpg"
    },
    {
        "produto": "Produto 05",
        "preco": 0.90,
        "descrição": "Loren ipsum! Not ipsum!",
        "em_estoque": false,
        "img": "assets/imgs/img003.jpg"
    },
    {
        "produto": "Produto 06",
        "preco": 0.90,
        "descrição": "Loren ipsum! Not ipsum!",
        "em_estoque": true,
        "img": "assets/imgs/img003.jpg"
    },
    {
        "produto": "Produto 07",
        "preco": 0.90,
        "descrição": "Loren ipsum! Not ipsum!",
        "em_estoque": false,
        "img": "assets/imgs/img003.jpg"
    },
    {
        "produto": "Produto 08",
        "preco": 0.90,
        "descrição": "Loren ipsum! Not ipsum!",
        "em_estoque": true,
        "img": "assets/imgs/img003.jpg"
    }
];

/*
    filter, map, reduce
    filter : passa por todo o vetor e filtra produtos com determinada característica.
    map : Faz o mapeamento em cada elemento do array e executa a função.
    return reduce : Filtra os elemento  e retorna um valor único baseado na função que percorre o array. 
    sintaxe reduce array.reduce(previousValue, InitialValue)
*/

const filtroMaiorQue10 = vetorProduto.filter(
    (elemento) => {
        return elemento.preco < 10;
        
    }
)

const emEstoque = (elemento) => {
        return elemento.em_estoque === true;
    }



console.log('filtrar em estoque : ',emEstoque)



const converterDolar = (elemento) => {
    const newElemento = {...elemento}
    newElemento.preco = newElemento.preco / 5.43
    return newElemento
}
const produtos_em_dolar = vetorProduto.map(converterDolar)
console.log('produtos em dolar: ',produtos_em_dolar)


const retornaNomeProdutos = (elemento) => {
    return elemento.produto + "---" + elemento.preco
}

const nomeProdutos = vetorProduto.map(retornaNomeProdutos)

console.log('nome produtos' + nomeProdutos)



 /*
 Reduce - fazer um calculo com todos os elementos retornando um único valor.
 */

const somaPrecos = (totalizador, elemento) => {
    return totalizador + elemento.preco
}


const media_preco = vetorProduto.reduce(somaPrecos, 0)

console.log('reduce :', media_preco)
console.log('reduce: media', media_preco / vetorProduto.length)

const divListaProduto = document.getElementById('lista-produtos')

/*
    for(valor of vetor)
    for(index in vetor)
*/

for(let elemento of vetorProduto){
const divProduto = `
    <div class="produto">
    <h1>${elemento.produto}</h1>
    <p>${elemento.descrição}</p>
    <h5>${elemento.preco}</h5>
    </div>
    `;
    divListaProduto.innerHTML += divProduto;

}



const exibirProdutos = (vetor) => {

    divListaProduto.innerText = '';
    for(let elemento of vetor){
        const divProduto = `
        <div class="produto">
        <h1>${elemento.produto}</h1>
        <p>${elemento.descrição}</p>
        <h5>${elemento.preco}</h5>
        </div>
        `;
        divListaProduto.innerHTML += divProduto;
        
    }
}
let estadoFiltroEstoque = false;

const btnFiltraApenasEstoque = document.getElementById('filtro01')
console.log(btnFiltraApenasEstoque)
btnFiltraApenasEstoque.onclick = () => {

    estadoFiltroEstoque = !estadoFiltroEstoque
    const vetorFiltrado = vetorProduto.filter(emEstoque);

    if(estadoFiltroEstoque == true){
        exibirProdutos(vetorFiltrado)
        btnFiltraApenasEstoque.innerText = `filtrando Em estoque`
                
    }else{
        exibirProdutos(vetorProduto)
        btnFiltraApenasEstoque.innerText = 'Filtrar'

    }

};

let estadoValorEmDolar = false
const divPrecoEmDolar = document.getElementById('div_preco_em_dolar')
const btnPrecoEmDolar = document.getElementById('preco_em_dolar')


btnPrecoEmDolar.onclick = () => {
    vetorProduto.map()
    converterDolar
    
}
