# Banco de Dados 

```bash

Aula de banco de dados.

```

# Aula SQL

[Xampp Control](C:\xampp\mysql\data) 

Acessar banco de dados : [MySQL - Banco de dados](C:\xampp\mysql\data)

# Comandos SQL

## Aba SQL
    SELECT arg, arg .... 
    FROM (nome da tabela)

### Seleciontar toda tabela
    SELECT * 
    FROM <tabela>;
 
 
### Condições
```bash
    SELECT NOME, ADVERTENCIA, MENSALIDADE
    FROM aluno
    WHERE ADVERTENCIA >=3; # mostrar alunos com advertência maior que 3.

    SELECT NOME, ADVERTENCIA, MENSALIDADE
    FROM aluno
    WHERE ADVERTENCIA >=3 OR MENSALIDADE>100; # Mostrar alunos com mais de 3 advertências ou com mensalidade > 100.

    SELECT *
    FROM aluno
    WHERE NOME="Gabriel"; #alunos com o nome estritamente igual.
        
    SELECT *
    FROM aluno
    WHERE NOME LIKE "%abr%"; #nomes que contenham caracteres "abr".

    SELECT *
    FROM aluno
    WHERE NOME LIKE "%abr%"
    AND MENSALIDADE>2; #nomes que contenham caracteres abr e mensalidade maior que 2.

    SELECT *
    FROM aluno
    WHERE (NOME LIKE "%abr%"
       AND MENSALIDADE>500)
       OR ESTADO="SC"; # Nomes que contenham a primeira ou a segunda expressão. () são resolvidos primeiro.

```

### SELECT AVG

```bash
    SELECT AVG (MENSALIDADE)
    FROM aluno; # Retorna a média das mensalidades dos alunos.
```


### UPDATE

```bash
    UPDATE nome_da_tabela

    SELECT campo1, campo2
    FROM nome_da_tabela
    WHERE condição_desejada;

    UPDATE aluno
    SET MENSALIDADE=MENSALIDADE *1.3
    WHERE NOME LIKE "%sa%"; # Atualiza a mensalidade em mensalidade*1.3 onde o nome contem (sa)

    UPDATE aluno
    SET NOME="Nome novo"
    WHERE NOME="Nome antigo"; # Atualiza (nome antigo) para (nome novo)

```

### DELETE

    DELETE *
    FROM aluno
    WHERE MAT_ALUNO=1;

### 1) selecione todos os alunos que moram perto do mueller e possuem mais de 1 advertência -->

    SELECT *
    FROM aluno
    WHERE (BAIRRO LIKE "%am%rica%" OR "sagua%u" OR "%boa%20%vista" OR "bucar%m" OR "anita%20garibaldi%" OR "atiradores") AND ADVERTENCIA=1;



### 2) Modifique a cidade do aluno XYZ para a cidade Perdidos nos buracos

    UPDATE aluno
    SET CIDADE="perdidos nos buracos"
    WHERE NOME="João";