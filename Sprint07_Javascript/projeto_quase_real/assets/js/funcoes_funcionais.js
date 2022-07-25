let vetorProduto = [];
let vetorFiltrado = [];
let vetorProdutoEmDolar = [];
let vetorFiltradoEmDolar = [];

const converterEmDolar = function (array) {

    const newArray = { ...array }

    newArray.preco = Number(parseFloat(newArray.preco / dolar))

    return newArray

}

const produtos_em_dolar = vetorProduto.map(converterEmDolar)


const emEstoque = (elemento) => {
    return elemento.em_estoque === true;
}


const retornaNomeProdutos = (elemento) => {
    return elemento.produto + "---" + elemento.preco
}


const somaPrecos = (totalizador, elemento) => {
    return totalizador + elemento.preco

}


const divListaProduto = document.getElementById('lista-produtos')

for (let elemento of vetorProduto) {
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
    for (let elemento of vetor) {
        let moneySign = estadoEmDolar ? '$ ' : 'R$ '
        let divProduto = `
        <div class="produto">       
        <h1>${elemento.produto}</h1>           
        <p>${elemento.descrição}</p>           
        <h5>${moneySign}${elemento.preco.toFixed(2)}</h5>
        </div>`;

        divListaProduto.innerHTML += divProduto;
    }
}


const btn_filtrar = document.getElementById('filtro01')

let estadoFiltrado = false;

const filtrarProduto = () => {

    if (estadoFiltrado == true) {
        estadoEmDolar ? exibirProdutos(vetorFiltradoEmDolar) : exibirProdutos(vetorFiltrado)
        btn_filtrar.classList.add('selected')
        btn_filtrar.innerText = `Em estoque`
    } else {
        estadoEmDolar ? exibirProdutos(vetorFiltradoEmDolar) : exibirProdutos(vetorProduto)
        btn_filtrar.classList.remove('selected')
        btn_filtrar.innerText = 'Filtrar'
    }
    filtrarDolar()
    exibirMedia()
};
btn_filtrar.onclick = () => {
    estadoFiltrado = !estadoFiltrado
    filtrarProduto()
}


const btnPrecoEmDolar = document.getElementById('preco_em_dolar')

let estadoEmDolar = false

const filtrarDolar = () => {

    if (estadoEmDolar && estadoFiltrado) {

        btnPrecoEmDolar.classList.add('selected')
        console.log('l')
        exibirProdutos(vetorFiltradoEmDolar)

    } else if (estadoEmDolar && estadoFiltrado == false) {

        btnPrecoEmDolar.classList.add('selected')
        exibirProdutos(vetorProdutoEmDolar)
    } else if (estadoEmDolar == false && estadoFiltrado == true) {

        btnPrecoEmDolar.classList.remove('selected')
        exibirProdutos(vetorFiltrado)
    } else {

        btnPrecoEmDolar.classList.remove('selected')
        exibirProdutos(vetorProduto)

    }
    exibirMedia()
}
btnPrecoEmDolar.onclick = () => {
    estadoEmDolar = !estadoEmDolar
    filtrarDolar()
}



const btnMedia = document.getElementById('btn_media')

const divMedia = document.getElementById('div_media')

let estadoMedia = false;

const exibirMedia = () => {

    let newArray = estadoFiltrado ? [...vetorFiltrado] : [...vetorProduto]
    let moneySign = estadoEmDolar ? '$ ' : 'R$ '
    newArray = estadoEmDolar ? newArray.map(converterEmDolar) : newArray

    if (estadoMedia) {
        btnMedia.classList.add('selected')
        divMedia.style.display = 'block'
        divMedia.innerHTML = `${moneySign}${parseFloat(newArray.reduce(somaPrecos, 0)).toFixed(2)}`

    } else {

        divMedia.style.display = 'none'
        divMedia.innerHTML = ''
        btnMedia.classList.remove('selected')

    }
}
btnMedia.onclick = () => {
    estadoMedia = !estadoMedia
    exibirMedia()
}


window.addEventListener("keydown", (event) => {
    let keyPressed = event.key.toUpperCase()
    switch (keyPressed) {
        case 'D':
            btnPrecoEmDolar.click()
            break;
        case 'M':
            btnMedia.click()
            break;
        case 'F':
            btn_filtrar.click()
            break;
    }
})
