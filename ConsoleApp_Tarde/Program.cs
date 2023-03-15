// See https://aka.ms/new-console-template for more information
using ConsoleApp_Tarde;

Console.WriteLine("Hello, World!");

Produto p1 = new Produto(1, "Mouse xing ling", 10.90M);
Produto p2 = new Produto(2,"Teclado multilaser",20.9M);

Console.WriteLine(p1.getDescricao() + " " + p1.getValor());
Console.WriteLine(p2.getDescricao() + " " + p2.getValor());

p1.setValor(29.90M);
p1.setDescricao("Mouse Razer");

Console.WriteLine(p1.getValor() + "  " + p1.getValor());

Endereco e1 = new Endereco(
 1,
 15991 - 251,
 "Av. Joao ANtonio Marques",
 "Cadioli",
 "Matao",
 192
 ); 

Cliente c1 = new Cliente(1, "Ana", "997706690", e1);
Cliente c2 = new Cliente(2, "Maria", "992168421", e1); Console.WriteLine(c1.getEndereco().EnderecoCompleto());
c1.getEndereco().setRua("Prudente de Morais");
Console.WriteLine(c1.getEndereco().EnderecoCompleto());
c1.getEndereco().AtualizarEndereco("Julio de Moraes", 585, "Presidente Arouca");
Console.WriteLine(c1.getEndereco().EnderecoCompleto());