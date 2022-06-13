let mainArticle = document.getElementById('mainArticle')
mainArticle.innerHTML = openPage('mainArticle', 'main.html')

// document.onload(openPage('mainArticle', 'main.html'))


function openPage(target, url) {
    url = `./src/${url}`
    var xml = new XMLHttpRequest()
    xml.onreadystatechange = function () {
        console.log(xml)
        if (xml.readyState == 4 && xml.status == 200) {
            document.getElementById(target).innerHTML = xml.responseText
        }
    }
    xml.open("GET", url, true)

    xml.send()
}

