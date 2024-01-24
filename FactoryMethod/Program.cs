using FactoryMethod;

Console.WriteLine("Factory Method!\n");
Console.WriteLine("Digite o animal que você gosta! (C)achorro ou (G)ato.\n");

var animalEscolhido = Console.ReadLine();

var animalRetornado = AnimalSimpleFactory.RetornarAnimal(animalEscolhido.ToUpper());

Console.WriteLine(animalRetornado.FazerBarulho());
Console.WriteLine(animalRetornado.Apresentacao());

Console.ReadLine();