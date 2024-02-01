using Pratica.Builder;

Console.WriteLine("Praticando Builder!\n");

var pizzaria = new Pizzaria(new PizzaCalabresa());
pizzaria.MontaPizza();
var pizza = pizzaria.GetPizza();

Console.WriteLine(pizza.Sabor);

pizzaria = new Pizzaria(new PizzaMussarela());

pizzaria.MontaPizza();
var pizza2 = pizzaria.GetPizza();

Console.WriteLine(pizza2.Sabor);

Console.ReadLine();