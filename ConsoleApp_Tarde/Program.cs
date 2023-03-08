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