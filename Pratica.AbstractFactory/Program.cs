using Pratica.AbstractFactory;

Console.WriteLine("Praticando Abstract Factory!\n");

Console.WriteLine("Escolha o tipo de comida que deseja. Pizza ou Bolo.");
var massaEscolhida = Console.ReadLine();

var massa = MassaAbstractFactory.RetornaFactory(massaEscolhida);

if(massaEscolhida == "Pizza")
{
    Console.WriteLine("Escolha o sabor da pizza que deseja. Mussarela ou Calabresa.");
    var saborPizzaEscolhido = Console.ReadLine();
    var saborPizzaRetornado = massa.RetornaSabor(saborPizzaEscolhido);

    Console.WriteLine($"O sabor é de {saborPizzaRetornado.Sabor}");
    Console.ReadLine();
} else if(massaEscolhida == "Bolo")
{
    Console.WriteLine("Escolha o sabor do bolo que deseja. Chocolate ou Laranja.");

    var saborBoloEscolhido = Console.ReadLine();
    var saborBoloRetornado = massa.RetornaSabor(saborBoloEscolhido);

    Console.WriteLine($"O sabor é de {saborBoloRetornado.Sabor}");
    Console.ReadLine();
}