using Pratica.FactoryMethod;

Console.WriteLine("Praticando Factory Method!\n");

Console.WriteLine("Digite o veículo desejado: (M)oto ou (C)arro.");

var veiculoEscolhido = Console.ReadLine();
var veiculoRetornado = VeiculoSimpleFactory.RetornaVeiculo(veiculoEscolhido);

Console.WriteLine(veiculoRetornado.Apresentacao());
Console.ReadLine();