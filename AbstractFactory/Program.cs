using AbstractFactory;

Console.WriteLine("Abstract Factory!\n");
Console.WriteLine("Deseja ver informações sobre qual tipo de massa. Pizza ou Bolo?\n");
var tipoMassaEscolhido = Console.ReadLine();

var tipoMassaRetornado = MassaAbstractFactory.CriaFabricaMassa(tipoMassaEscolhido);

if (tipoMassaRetornado.Nome == "Pizza")
{
    Console.WriteLine("Agora escolha o sabor da massa da pizza. Calabresa ou Mussarela");
    var saborMassaEscolhido = Console.ReadLine();

    var saborMassaRetornado = tipoMassaRetornado.CriaMassa(saborMassaEscolhido);

    Console.WriteLine("Os ingredientes são:\n");
    foreach (var ingrediente in saborMassaRetornado.Ingredientes)
    {
        Console.WriteLine(ingrediente + "\n");
        
    }
    Console.ReadLine();
}
else if (tipoMassaRetornado.Nome == "Bolo")
{
    Console.WriteLine("Agora escolha o sabor do bolo. Laranja ou Chocolate");
    var saborMassaEscolhido = Console.ReadLine();

    var saborMassaRetornado = tipoMassaRetornado.CriaMassa(saborMassaEscolhido);

    Console.WriteLine("Os ingredientes são:\n");
    foreach (var ingrediente in saborMassaRetornado.Ingredientes)
    {
        Console.WriteLine(ingrediente + "\n");
    }
    Console.ReadLine();
}