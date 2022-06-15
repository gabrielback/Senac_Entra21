// Resolução 1

const inputData = [currentNumber = 0, nextNumber = 1, sum = 1, nthTerm = 15]    // Array de parâmetros. Adiciona todos os parametros em um array
const fibonacci = (...spread) => {                                              // Constante que armazena a função fibonacci e espera um array como parâmetro
    const outputData = []                                                       // Constante que armazena um array vazio
    for (let i = 1; i <= nthTerm; i++) {                                        // Loop For >>> Repete a quantidade de vezes (valor de nthTerm)
        outputData.push(sum)                                                    // Adiciona o valor de sum na ultima posição do array
        sum += currentNumber                                                    // Soma <- Soma + currentNumber
        currentNumber = nextNumber                                              // Valor de currentNumber é igualado com valor de nextNumber
        nextNumber = sum                                                        // Valor de nextNumber é igualado com sum
      } 
      return outputData                                                         // Retorna os valores adicionados ao array outputData em forma de array
}
console.log(fibonacci(...inputData))                                            // Invoca e retorna a fução fibonacci em forma de texto através do console

// Resolução 2


// const inputData = [currentNumber = 0, nextNumber = 1, sum = 1, nthTerm = 15]
// const fibonacci = (...spread) => {
//     for (let i = 1; i <= nthTerm; i++) {
//         console.log(`${i}º nthTerm = ${sum}`)
//         sum += currentNumber
//         currentNumber = nextNumber
//         nextNumber = sum        
//       } 
// }
// fibonacci(...inputData)


// Resolução 3


// const fibonacci = (nthTerm) => {
    // let currentNumber = 0
    // let nextNumber = 1
    // let sum =1
    // for (let i = 1; i <= nthTerm; i++) {
    //     console.log(`${i}º nthTerm = ${sum}`)
    //     sum += currentNumber
    //     currentNumber = nextNumber
    //     nextNumber = sum
        
//       } 
// }
// fibonacci(15)

