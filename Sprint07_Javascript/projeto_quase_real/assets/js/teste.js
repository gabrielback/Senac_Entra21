fetch('https://api.github.com/users/gabrielback', { 
                 headers: {
                      'Accept' : 'application/vnd.github.text+json'
                  }})
		.then(response => response.json()) //Converting the response to a JSON object
		.then( data => {
      console.log(data)
                    const root = document.querySelector('#root');
                    root.innerHTML = ` 
                      <a href=${data.html_url}>Name: ${data.name}</a>
                     <p>Followers : ${data}</p>
                  `
                })
		.catch( error => console.error(error));