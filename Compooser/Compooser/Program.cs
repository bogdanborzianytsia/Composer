using  Compooser;
Pizza pepperoniPizza = new Pizza("Pepperoni");
Topping pepperoniTopping = new Topping("Pepperoni");
Topping cheeseTopping = new Topping("Cheese");

pepperoniPizza.AddTopping(pepperoniTopping);
pepperoniPizza.AddTopping(cheeseTopping);

Client client = new Client();
client.ClientCode(pepperoniPizza);

pepperoniPizza.RemoveTopping(cheeseTopping);
client.ClientCode(pepperoniPizza);