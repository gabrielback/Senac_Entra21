// functions

function mediana(arr) {
    const middle = (arr.length + 1) / 2;

    // Avoid mutating when sorting
    const sorted = [...arr].sort((a, b) => a - b);
    const isEven = sorted.length % 2 === 0;

    return isEven ? (sorted[middle - 1.5]
        + sorted[middle - 0.5]) / 2 :
        sorted[middle - 1];
}

const media = (numeros) => {
    let soma = 0
    for (let i = 0; i < numeros.length; i++) {
        soma = numeros[i] + soma
    }
    return soma / numeros.length
}


const fatorial = (n, p) => {
    if (n > 1 && p == undefined) {
        return n * fatorial(n - 1)
    }
    return n
}

const permutacao = (n, p) => {
    if (n > 1) {
        return fatorial(n - 1)
    }
    return n
}

const permutacaoSubtracao = (n, p) => {
    if (n && p)
        return fatorial(n) / fatorial(n - p)
    else
        return `Necessario dois parametros (n, p)`

}
const anagrama = (n) => {
    return fatorial(n.length)
}


// moda
const toArray = obj => Object.keys(obj).map(key => obj[key]);

const summarize = numbers => toArray(numbers.reduce(summarizeFn, {}));

const summarizeFn = function(summary, num) {
  summary[num] = summary[num]
      ? { num, count: summary[num].count + 1 }
      : { num, count: 1 }
  return summary;
};

const findMode = summary => summary.reduce(findModeFn, 0);

const findModeFn = (max, { count }) => count > max ? count : max;

const filterMode = (summary, mode) => summary.filter(({ count }) => count == mode);

const getValues = items => items.map(({ num }) => num);

const moda = function(numbers) {
  const summary = summarize(numbers);
  const mode = findMode(summary);
  const modeItems = filterMode(summary, mode);
  return modeItems.length == summary.length ? [] : getValues(modeItems);
}
const tempoEmSegundos = (tempo) => {
    let a = tempo.split(':');
    let seconds = (+a[0]) * 60 * 60 + (+a[1]) * 60 + (+a[2]);
    return seconds
}
const segundosEmHoras = (tempo) => {

    // let sec = tempo
    let hour = Math.trunc(tempo/ 3600)
    let min = Math.trunc(tempo/60 - hour*60)
    let sec = tempo % 60
    return `${hour}:${min}:${sec}`
}


// console log

// const numeros = [ 2, 2, 3, 3, 5, 7, 8, 9, 10, 11]
// const numeros = [146, 125, 139, 132, 121, 135, 114, 114, 130, 169, 114, 130, 169, 125, 103]
// const numeros = [10, 12, 15, 17, 16]

// console.log(segundosEmHoras(7322))
// console.log(tempoEmSegundos('02:02:02'))


// const numeros = [
//     tempoEmSegundos('00:03:38'),
//     tempoEmSegundos('00:03:18'),
//     tempoEmSegundos('00:02:46'),
//     tempoEmSegundos('00:02:57'),
//     tempoEmSegundos('00:03:26')

// ]

// console.log(segundosEmHoras(193))






//anagrama
// console.log(anagrama('educação'))


//permutação com subtração
// console.log(`Permutação subtração = ${permutacaoSubtracao(5, 3)}`)

// permutação
// console.log(`Permutação = ${permutacao(6)}`)

// fatorial
// console.log(`Fatorial = ${fatorial(11)}`)





//fatorial equação
// console.log(fatorial(6)/(fatorial(6-3)*fatorial(3)))
// console.log(fatorial(4+2)/fatorial(4))
// console.log(`divisão fatorial ${(fatorial(4)*fatorial(5))/ fatorial(3)}`)

// const numeros = [10, 12, 15, 17]


//media
// console.log(`media => ${media(numeros)}`)

// mediana
// console.log(`mediana => ${mediana(numeros)}`);

// moda
// console.log('moda separados por (,) > '+ moda(numeros));

// console.log(fatorial(5))

/*
1) Apresentar o quadrado dos números inteiros de 15 a 200.

2) Apresentar os resultados de uma tabuada de multiplicar (de 1 até 10) de um numero qualquer.

3) Apresentar o total da soma obtida dos cem primeiros números inteiros (1+2+3+4 ...+98+100)

4) Elaborar um programa que apresente no final o somatório dos valores pares existentes na faixa de 1 até 500.

5) Apresentar todos os valores numéricos inteiros ímpares situados na faixa de 0 a 20. Para verificar se o número é ímpar, efetuar dentro da malha a verificação lógica
desta condição com a instrução se, perguntando se o número é impar; send, mostre-o não sendo, passe para o próximo passo.

*/



function somaPares(num = 0){
    let soma = num
    while (num <= 4) {

        if(num % 2 == 0){
            soma += num
        }
        num++
    }
    return soma
}


//console.log(somaPares())

/*

6) Apresentar resultados das potências de 3, variando do expoente 0 até o expoente 15.
Deve ser considerado que qualquer número elevado a 0 é 1, e elevado a 1  é ele próprio.


7) Elaborar um programa que apresente como resultado o valor de uma potência de uma base qualquer elevada a um expoênte qualquer ,ou seja, de B, em que B é o valor da base e E o valor do expoente.


8) Escreva um programa que apresenta uma série de Fibonacci até o décimo quinto termo.
A série de Fibonacci é formada pela sequência: 1, 1, 2, 3, 5, 8, 13, 21, 34..., etc. Esta série se caracteriza pela soma de um termo atual com o seu anterior subsequente para que seja formado o próximo valor da sequência. Portanto começando com os números 1, 1 o proximo termo é 1+1=2, o próximo é 1+2 = 3 o próximo é 2+3 = 5, o próximo é 3 + 5 = 8, etc.

*/