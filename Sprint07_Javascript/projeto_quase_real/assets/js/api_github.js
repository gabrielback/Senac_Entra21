const img_Foto = document.getElementById('foto');
const userImage = document.getElementById('foto')
const userName = document.getElementById('name')
const githubUserName = "gabrielback"



const getUserRepositories = (user) => {
    fetch(`http://api.github.com/users/${user}/repos`)
    .then(async res => {
        if (!res.ok) {
            throw new Error(res.status)
        }
        let repo = await res.json()
        renderizarRepositorios(repo)
    })
    .then(
        fetch('../json/content.json')
        .then(response => response.json())
        .then(data => {
            renderizarDashboard(data)
        })
        .then(
            fetch(`https://api.github.com/users/${githubUserName}`)
            .then(response => response.json())
            .then(data => {
                renderizarUsuario(data)
            })
        )
    )
}
getUserRepositories(githubUserName)


const url = data => data.url

const renderiza_foto = (foto) => img_Foto.src = `${foto}`

const renderizarRepositorios = repositories => {
    const conteudoGithub = document.querySelector('.conteudoGithub');
    conteudoGithub.insertAdjacentHTML("afterbegin", `<h1>My Git Repositories</h1><div id="lista-repositorios">`)
    let listaDeRepositorios = conteudoGithub.firstChild.nextSibling
    repositories.map(repository => {
        let privacy = repository.private ? "private" : "public"
        console.log("repository",repository)
        let updatedAt = Intl.DateTimeFormat('pt-br').format(new Date(repository.updated_at))
        
        listaDeRepositorios.innerHTML += 
        ` 
        <div onclick="loadGithub(this)" class="repositorio ${privacy}">
        <h1>${repository.name}</h1>
        <p>${privacy}</p>
        <div>
        <p class="language">${repository.language ? repository.language : ""}<p>
        <p class="date">Last update: ${updatedAt}</p>
        <div>
        <div>
        `
    })
    conteudoGithub.innerHTML += "</div>"
}

const renderizarDashboard = data => {
    let dashboard = document.getElementById('dashboard')
    dashboard.insertAdjacentHTML("afterbegin", `<h1>${data[0].title}</h1><div><iframe id="pbi" width="100%" height="100%" src="" frameborder="0" allowFullScreen="true"></iframe><div>`)
    let powerBI = document.getElementById('pbi')
    powerBI.src = data[0].url
}

const renderizarUsuario = data => {
        document.querySelector('.content').insertAdjacentHTML(
            "afterbegin",
            `
            <div class="header">
            <div style="display: flex;">
            <img id="foto" src="${data.avatar_url}">
            <div id="user-name"></div>
            </div>
            </div>
            `
            )
            document.getElementById('user-name').innerHTML =
            `
            <h1>${data.name}</h1>
            `
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
            
            
            
            
// Não implementado

// const appendImageLanguage = imageLink => {
    //     let img = ""
    //     imageLink.forEach(data => {
        //         data = data.toLocaleLowerCase()
        //         img = `<img src="https://raw.githubusercontent.com/abrahamcalf/programming-languages-logos/master/src/${data}/${data}_48x48.png"></img>`
        //     })
        //     console.log(img)
        // }
        
        
        
        // const getLanguageOnGithub = repository => {
            //     fetch(repository.languages_url)
            //     .then(response => response.json())
            //     .then(data => Object.keys(data))
            // }
            
            // exibir_load(true)
            
//
// const loadGithub = e => console.log(e);
// loadGithub()
// // window.location.assign(`https://github.com/${githubUserName}/aluraJava`)
