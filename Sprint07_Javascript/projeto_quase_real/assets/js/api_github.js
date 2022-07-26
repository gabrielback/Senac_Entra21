const user = "vinirteixeira"
const repo = document.getElementById('lista-repositorios');
const img_Foto = document.getElementById('foto');
const bio = document.getElementById('bio')
const fotoDoUsuario = document.getElementById('foto')
const linkRepositorios = `http://api.github.com/users/${user}/repos`


const getGithubAPI = (user) => {
    fetch(`http://api.github.com/users/${user}/repos`)
        .then(async res => {
            if (!res.ok) {
                throw new Error(res.status)
            }
            repositorios = await res.json()

            repositorios.map(repositorio => {
                let privacidade = repositorio.private ? "privado" : "publico"
                date = Intl.DateTimeFormat('pt-br').format(new Date(repositorio.created_at))
                repo.innerHTML += ` 
            <div class="repositorio ${privacidade}">
            <h1>${repositorio.name}</h1>
            <p>${privacidade}</p>
                <div>
                    <p class="language">${repositorio.language ? repositorio.language : ""}<p>
                    <p class="date">Data de criação: ${date}</p>
                <div>
            <div>
            `

                console.log(repositorio)
            })

        })
}

getGithubAPI('github')
// getGithubAPI('gabrielback')
// renderizaDiretorios()



$.ajax({ 
    type: 'GET', 
    url: 'http://api.github.com/users/gabrielback/repos', 
    crossDomain: true, 
    dataType: 'json', 
    success: function() { 
      console.log(arguments[0]); 
      console.log("ajax function",arguments); 

    }, 
    error: function() { 
      console.log("ajax function",arguments); 
    } 
  });
 


// $.ajax({
//     type: "get",
//     xhrFields: { withCredentials:true },
//     url: "http://apiendpoint.com",
//     success: function(data)
//     {
//      console.log(data);
//     }
// })


// $({
//     url: 'http://api.github.com/users/gabrielback/repos',
//     beforeSend: function(xhr) {
//         xhr.setRequestHeader("", "gabrielback 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")
//         console.log(xhr)
//     }, success: function(data){
//         console.log(data)
//         //process the JSON data etc
//     }
// })
// exibir_load(true)

function renderiza_foto(foto) {
    img_Foto.src = `${foto}`
}


// fetch(`https://api.github.com/users/${user}`)
// .then(response => response.json())
// .then(user => {
//     renderiza_foto(user.avatar_url)
//     fetch(user.repos_url)
//     .then(response => response.json())
//     .then(repositorios => {
//         renderizarRepositorios(repositorios)

//     })
// }).catch( error => { // para status de erro
//     console.error('algo deu errado na requisição', error);

// }).finally(() => {
//     // exibir_load(false)
//     console.warn('Sempre cai aqui')
// })