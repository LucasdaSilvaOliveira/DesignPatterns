// See https://aka.ms/new-console-template for more information
using FactoryMethod;

Console.WriteLine("Factory Method!\n");
Console.WriteLine("Digite o animal que você gosta! (C)achorro ou (G)ato.\n");

var animalEscolhido = Console.ReadLine();

var animal = new AnimalSimpleFactory(animalEscolhido);

Console.WriteLine(animal.animal.FazerBarulho());

Console.ReadLine();