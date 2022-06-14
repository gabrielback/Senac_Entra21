let mainArticle = document.getElementById('artigo')
artigo.innerHTML = openPage('artigo', 'main.html')

const selectElement = () => {
    let li = document.querySelectorAll('ul>li>a')
    
    li.forEach(element => {
        element.addEventListener('click', () => {
            let selectedElement = document.querySelector('.selected')
            selectedElement.classList.remove('selected')
            element.classList.add('selected')
        })
    })
}

// selectElement()

function openPage(element, url) {
    url = `./pages/${url}`
    var xml = new XMLHttpRequest()
    xml.onreadystatechange = function () {
        if (xml.readyState == 4 && xml.status == 200) {
            document.getElementById(element).innerHTML = xml.responseText
        }
    }
    xml.open("GET", url, true)
    xml.send()
}