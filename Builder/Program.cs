using Builder.Builder;
using Builder.Director;

Console.WriteLine("### BUILDER! ###\n");

var pizzaria = new Pizzaria(new PizzaCalabresa());
pizzaria.MontarPizza();

var pizzaCalabresa = pizzaria.GetPizza();

Console.WriteLine($"Pizza de calabresa com tamanho de {pizzaCalabresa.Tamanho} cm.\n");
Console.WriteLine($"Borda {pizzaCalabresa.Borda}\n");
Console.WriteLine("E com os ingredientes:\n");

foreach (var ingredientes in pizzaCalabresa.Ingredientes)
{
    Console.WriteLine(ingredientes + "\n");
}
Console.WriteLine("=================\n");

pizzaria = new Pizzaria(new PizzaMussarela());
pizzaria.MontarPizza();

var pizzaMussarela = pizzaria.GetPizza();

Console.WriteLine($"Pizza de mussarela com tamanho de {pizzaMussarela.Tamanho} cm.\n");
Console.WriteLine($"Borda {pizzaMussarela.Borda}\n");
Console.WriteLine("E com os ingredientes:\n");

foreach (var ingredientes in pizzaMussarela.Ingredientes)
{
    Console.WriteLine(ingredientes + "\n");
}

Console.ReadLine();