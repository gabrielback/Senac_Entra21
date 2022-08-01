const listaRepositorios = document.getElementById('lista-repositorios');
const img_Foto = document.getElementById('foto');
const bio = document.getElementById('bio')
const fotoDoUsuario = document.getElementById('foto')
const userName = document.getElementById('name')

const getUserRepositories = (user) => {
    fetch(`http://api.github.com/users/${user}/repos`)
        .then(async res => {
            if (!res.ok) {
                throw new Error(res.status)
            }
            let repositories = await res.json()
            listaRepositorios.insertAdjacentHTML("beforebegin", "<h1>My Git Repositories</h1>")
            repositories.map(repository => {
                let privacy = repository.private ? "privado" : "publico"
                date = Intl.DateTimeFormat('pt-br').format(new Date(repository.created_at))

                listaRepositorios.innerHTML += ` 
                <div onclick="loadGithub(this)" class="repositorio ${privacy}">
                <h1>${repository.name}</h1>
                <p>${privacy}</p>
                <div>
                    <p class="language">${repository.language ? repository.language : ""}<p>
                    <p class="date">Data de criação: ${date}</p>
                <div>
            <div>
            `
            })
        })
        .then(
            fetch('../json/content.json')
                .then(response => response.json())
                .then(data => {
                    let dashboard = document.getElementById('dashboard')
                    dashboard.insertAdjacentHTML("afterbegin", `<h1>${data[0].title}</h1><div><iframe id="pbi"></iframe><div>`)
                    let powerBI = document.getElementById('pbi')
                    powerBI.src = data[0].url
                })
                .then(
                    fetch(`https://api.github.com/users/gabrielback`)
                        .then(response => response.json())
                        .then(data => {
                            document.querySelector('.content').insertAdjacentHTML("afterbegin",
                            `
                            <div class="header">
                            <div style="display: flex;">
                            <img id="foto" src="${data.avatar_url}">
                            <div id="user-name"></div>
                            </div>
                            </div>
                            `
                            )
                            // renderiza_foto(data.avatar_url)
                            document.getElementById('user-name').innerHTML = `
                            
                            <h1>${data.name}</h1>
                            `
                        })
                )
        )
}

const loadGithub = (e) => {
    
    // window.location.assign("https://github.com/gabrielback/aluraJava")
}

getUserRepositories('gabrielback')

// exibir_load(true)

const url = (data) => {
    return data.url
}


function appendImageLanguage(imageLink) {
    let img = ""
    imageLink.forEach(data => {
        data = data.toLocaleLowerCase()
        img = `<img src="https://raw.githubusercontent.com/abrahamcalf/programming-languages-logos/master/src/${data}/${data}_48x48.png"></img>`
    })
    console.log(img)
}



function getLanguageOnGithub(repository) {
    fetch(repository.languages_url)
        .then(response => response.json())
        .then(data => Object.keys(data))
}

function renderiza_foto(foto) {
    img_Foto.src = `${foto}`
}



// fetch(`https://api.github.com/users/${user}`)
// .then(response => response.json())
// .then(user => {
    // renderiza_foto(user.avatar_url)
    // console.log(user)
//     fetch(user.repos_url)
//     .then(response => response.json())
//     .then(repositorios => {
//         renderizarRepositorios(repositorios)

    // })
// }).catch( error => { // para status de erro
//     console.error('algo deu errado na requisição', error);

// }).finally(() => {
//     // exibir_load(false)
//     console.warn('Sempre cai aqui')
// })