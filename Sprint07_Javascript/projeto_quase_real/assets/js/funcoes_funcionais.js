let vetorProduto = [
    {
        "produto": "Produto 01",
        "preco": 3.65,
        "descrição": "Loren ipsum!",
        "em_stock": true,
        "img": "assets/imgs/img001.jpg"
    },
    {
        "produto": "Produto 02",
        "preco": 100.00,
        "descrição": "Loren ipsum! Not ipsum!",
        "em_stock": false,
        "img": "assets/imgs/img002.jpg"
    },
    {
        "produto": "Produto 03",
        "preco": 0.90,
        "descrição": "Loren ipsum! Not ipsum!",
        "em_stock": true,
        "img": "assets/imgs/img003.jpg"
    },
    {
        "produto": "Produto 04",
        "preco": 0.90,
        "descrição": "Loren ipsum! Not ipsum!",
        "em_stock": true,
        "img": "assets/imgs/img003.jpg"
    },
    {
        "produto": "Produto 05",
        "preco": 0.90,
        "descrição": "Loren ipsum! Not ipsum!",
        "em_stock": true,
        "img": "assets/imgs/img003.jpg"
    },
    {
        "produto": "Produto 06",
        "preco": 0.90,
        "descrição": "Loren ipsum! Not ipsum!",
        "em_stock": true,
        "img": "assets/imgs/img003.jpg"
    },
    {
        "produto": "Produto 07",
        "preco": 0.90,
        "descrição": "Loren ipsum! Not ipsum!",
        "em_stock": true,
        "img": "assets/imgs/img003.jpg"
    },
    {
        "produto": "Produto 08",
        "preco": 0.90,
        "descrição": "Loren ipsum! Not ipsum!",
        "em_stock": true,
        "img": "assets/imgs/img003.jpg"
    }
]

/*
    filter, map, reduce
    filter : passa por todo o vetor e filtra produtos com determinada característica.
    map : Faz o mapeamento em cada elemento do array e executa a função.
    return reduce : Filtra os elemento  e retorna um valor único baseado na função que percorre o array. 
    sintaxe reduce array.reduce(previousValue, InitialValue)
*/

const converterEmDolar = (array) => {
    const newArray = {...array}
    newArray.preco = newArray.preco / 5.43
    return newArray
}
const produtos_em_dolar = vetorProduto.map(converterEmDolar)

////////////////////////////////////////////////////////////////////


const apenasEmEstoque = (elemento) => {
    console.log(elemento)
    return elemento.produto
}
// console.log(vetorProduto.map(apenasEmEstoque))



const convertToDolar = (elemento) => {
    soma += elemento.preco = elemento.preco / 5.43
    return soma
}
console.log(vetorProduto.map(convertToDolar))


////////////////////////////////////////////////////////////////////

const emEstoque = (elemento) => {
        return elemento.em_estoque === true;
    }

    const retornaNomeProdutos = (elemento) => {
    return elemento.produto + "---" + elemento.preco
}

const nomeProdutos = vetorProduto.map(retornaNomeProdutos)

/*
 Reduce - fazer um calculo com todos os elementos retornando um único valor.
 */

const somaPrecos = (totalizador, elemento) => {
    return totalizador + elemento.preco

}

// const media_preco = vetorProduto.reduce(somaPrecos, 0)

/*
for(valor of vetor)
for(index in vetor)
*/

const divListaProduto = document.getElementById('lista-produtos')

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

const filtrarEmEstoque = document.getElementById('filtro01')

let estadoFiltrado = false;

const vetorFiltrado = vetorProduto.filter(emEstoque);
const filtrarProduto = () => {
    
    estadoFiltrado = !estadoFiltrado
    
    if(estadoFiltrado == true){
        exibirProdutos(vetorFiltrado)
        filtrarEmEstoque.classList.add('selected')
        filtrarEmEstoque.innerText = `filtrando Em estoque`
        
    }else{
        exibirProdutos(vetorProduto)
        filtrarEmEstoque.classList.remove('selected')
        filtrarEmEstoque.innerText = 'Filtrar'
    }
};
filtrarEmEstoque.onclick = filtrarProduto

/*TODO*/ // REFATORAR

const btnPrecoEmDolar = document.getElementById('preco_em_dolar')

let estadoEmDolar = false


const filtrarDolar = () => {
    estadoEmDolar = !estadoEmDolar

    let newArray = estadoFiltrado ? [...vetorFiltrado] : [...vetorProduto]

    if(estadoEmDolar && estadoFiltrado){
        
        btnPrecoEmDolar.classList.add('selected')
        exibirProdutos(newArray.map(converterEmDolar))
        
    }else if(estadoEmDolar && estadoFiltrado == false){
        
        btnPrecoEmDolar.classList.add('selected')
        exibirProdutos(newArray.map(converterEmDolar))
        
    }else {
        
        btnPrecoEmDolar.classList.remove('selected')
        exibirProdutos(newArray)
        
    }
}
btnPrecoEmDolar.onclick = filtrarDolar


const btnMedia = document.getElementById('btn_media')

const divMedia = document.getElementById('div_media')


let estadoMedia = false;


// TODO ; REFATORAR

const filtrarMedia = () => {
    estadoMedia = !estadoMedia
    
    let newArray = estadoFiltrado ? [...vetorFiltrado] : [...vetorProduto]

    newArray = estadoEmDolar ? newArray.map(converterEmDolar) : newArray
    if(estadoMedia){

        btnMedia.classList.add('selected')
        divMedia.style.display = 'block'
        divMedia.innerHTML = newArray.reduce(somaPrecos, 0)

    }else{

        divMedia.style.display = 'none'
        divMedia.innerHTML = ''
        btnMedia.classList.remove('selected')

    }
}
btnMedia.onclick = filtrarMedia


//filtrar teclas e retornar elementos filtrados
window.addEventListener("keydown", (event) => {
    let keyPressed = event.key.toUpperCase()
    switch (keyPressed) {
        case 'D':
        filtrarDolar()
        break;
        case 'M':
        filtrarMedia()   
        break;
        case 'F':
        filtrarProduto()
        break;
    }
} )
