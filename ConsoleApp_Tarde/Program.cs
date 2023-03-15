// See https://aka.ms/new-console-template for more information
using ConsoleApp_Tarde;
using ConsoleApp_Tarde.Heranca;

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
 "Rua Hamilton Bastia",
 "Nova Matao",
 "Matao",
 671
 ); 

Cliente c1 = new Cliente(1, "Ana", "997706690", e1);
Cliente c2 = new Cliente(2, "Maria", "992168421", e1); Console.WriteLine(c1.getEndereco().EnderecoCompleto());
c1.getEndereco().setRua("Prudente de Morais");
Console.WriteLine(c1.getEndereco().EnderecoCompleto());
c1.getEndereco().AtualizarEndereco("Julio de Moraes", 585, "Presidente Arouca");
Console.WriteLine(c1.getEndereco().EnderecoCompleto());

Carro car = new Carro();
car.cor = "Vermelho";
car.quantidadaRodas = 4;
car.quantidadeAcentos = 5;
car.TemMotor = true;

Bike bicicleta = new Bike();
bicicleta.cor ="Azul";
bicicleta.quantidadaRodas = 2;
bicicleta.quantidadeAcentos = 1;
bicicleta.TemMotor = false;


Aviao aviao = new Aviao();
aviao.cor = "Branco";
aviao.quantidadaRodas = 12;
aviao.quantidadeAcentos = 300;
aviao.TemMotor = true;

List<Veiculo> veiculoLista = new List<Veiculo>();
veiculoLista.Add(car);
veiculoLista.Add(aviao);
veiculoLista.Add(bicicleta);

foreach (var item in veiculoLista)
{
    Console.WriteLine(item.ExibirDados());

}

Console.WriteLine("Qtd itens da lista" + veiculoLista.Count);




