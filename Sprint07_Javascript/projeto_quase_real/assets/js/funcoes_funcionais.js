let vetorProduto = []


/*
    filter, map, reduce
    filter : passa por todo o vetor e filtra produtos com determinada característica.
    map : Faz o mapeamento em cada elemento do array e executa a função.
    return reduce : Filtra os elemento  e retorna um valor único baseado na função que percorre o array. 
    sintaxe reduce array.reduce(previousValue, InitialValue)
*/

const converterEmDolar = (elemento) => {
    const newElemento = {...elemento}
    newElemento.preco = (newElemento.preco / 5.43).toFixed(2)
    return newElemento
}
const produtos_em_dolar = vetorProduto.map(converterEmDolar)

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

const btnFiltraApenasEstoque = document.getElementById('filtro01')

let estadoFiltrado = false;

const vetorFiltrado = vetorProduto.filter(emEstoque);
const filtrarProduto = () => {
    
    estadoFiltrado = !estadoFiltrado
    
    if(estadoFiltrado == true){
        exibirProdutos(vetorFiltrado)
        btnFiltraApenasEstoque.classList.add('selected')
        btnFiltraApenasEstoque.innerText = `filtrando Em estoque`
        
    }else{
        exibirProdutos(vetorProduto)
        btnFiltraApenasEstoque.classList.remove('selected')
        btnFiltraApenasEstoque.innerText = 'Filtrar'
    }
};
btnFiltraApenasEstoque.onclick = filtrarProduto

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


//
let estadoMedia = false;


// TODO ; REFATORAR

const filtrarMedia = () => {
    estadoMedia = !estadoMedia
    
    let newArray = estadoFiltrado ? [...vetorFiltrado] : [...vetorProduto]

    newArray = estadoEmDolar ? newArray.map(converterEmDolar) : newArray
    console.log(newArray.reduce(somaPrecos, 0))
    // console.log(newArray.reduce(somaPrecos, 0))
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
