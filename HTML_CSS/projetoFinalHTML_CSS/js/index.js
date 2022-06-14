let mainArticle = document.getElementById('artigo')
artigo.innerHTML = openPage('artigo', 'main.html')

const headerList = document.querySelectorAll('li>a')
headerList.forEach((e) => e.addEventListener("click", () => {
    document.querySelector('.selected').classList.remove('selected')
    e.classList.add('selected')
}
))

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
