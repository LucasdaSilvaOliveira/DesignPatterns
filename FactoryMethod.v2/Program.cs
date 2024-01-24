// See https://aka.ms/new-console-template for more information
using FactoryMethod;

Console.WriteLine("Factory Method!\n");
Console.WriteLine("Escolha o tipo de veículo que deseja! (C)arro ou (M)oto.\n");
var veiculoEscolhido = Console.ReadLine();

var veiculoRetornado = VeiculoSimpleFactory.CriarVeiculo(veiculoEscolhido.ToUpper());

Console.WriteLine(veiculoRetornado.MontagemDoVeiculo());
Console.ReadLine();