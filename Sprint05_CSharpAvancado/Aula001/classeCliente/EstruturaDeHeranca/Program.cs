// See https://aka.ms/new-console-template for more information

using EstruturaDeHeranca;

Pessoa pessoa = new Pessoa();

int[] verificaDigito1 = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
int[] verificaDigito2 = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

pessoa.Cpf = "062.148.267-56";

string newCpf = pessoa.Cpf.Replace(".", "").Replace("-","");

string intervalCpf = newCpf.Trim().Substring(0,9);


Console.WriteLine(intervalCpf);