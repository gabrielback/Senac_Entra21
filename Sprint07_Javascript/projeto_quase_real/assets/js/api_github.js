// exibir_load(true)
function renderiza_foto(foto){
    const img_Foto = document.getElementById('foto')
    img_Foto.src = `${foto}`
}
fetch('https://api.github.com/users/gabrielback')
.then(response => response.json())
.then(data => {
    console.log(data)
    renderiza_foto(data.avatar_url)
    document.getElementById('nome').innerText = data.name
})
.catch( error => { // para status de erro
    console.error('algo deu errado na requisição', error);

}).finally(() => {
    // exibir_load(false)
    console.warn('Sempre cai aqui')
})
