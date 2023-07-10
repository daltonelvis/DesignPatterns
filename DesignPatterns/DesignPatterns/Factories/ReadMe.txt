Simple Factory:

This is not a design pattern but this is the basics hence we should know.

Suppose we have 2 types of Pizza Mushroom Pizza and Chicken Pizza

Customer can just say serve me Chicken Pizza or Mushroom Pizza we would have a 
method called MakePizza for both chicken and Mushroom. without this pattern the client code 
would be something like this

CustomerOrder(string PizzaType)
{

  If(PizzaType == "Chicken")
    create object of chicken pizza
  if(PizzaType == "Mushroom")
    created object of mushroom pizza
}

if there are 2 separate classes one is related to Pizza creation and second is calculating price 
we have to repeat the logic of object creation in both the places and get the correct object to 
calculate the price and makepizza.

Suppose something changes in the logic for example a new pizza type is added or we have to change chicken to CHICKEN then we have to change it in 
both the places.

To avoid this we can move the object creation logic to a common method and this would be a simple factory

The client code will then change to something like this, Any change needed we would just change the factory
CustomerOrder(string PizzaType)
{
   PizzaObject = PizzaFactory.MakePizza(PizzaType);
}

Here MakePizza will have the "if" logic to check the pizza type and return the correct Pizza object.


Factory Method:

In the above approach there is a drawback we still are hardcoding Pizza type check in the common method.

  If(PizzaType == "Chicken")
    create object of chicken pizza
  if(PizzaType == "Mushroom")
    create object of mushroom pizza

In case new Pizza types are created we still have to modify this common menthod which will break the open close principle.
to resolve this we use factory method design pattern.

We create a abstract class with a method which the client would call to get the required object.

The method that client calls "MakePizzaObject()" would then call an abstract method "createPizza()" to create an object, This method implementation 
will be provided by the sub class.

 public IPizza MakePizzaObject()
        {
            IPizza pizza = createPizza();
            pizza.makePizza();
            return pizza;
        }
  protected abstract IPizza createPizza();

So we will have seperate sub classes for each Pizza type which inherit the main abstract class.

    internal class ChickenPizzaFactory : PizzaFactoryMethod
    {
        protected override IPizza createPizza()
        {
            IPizza pizza = new ChickenPizza();
            return pizza;
        }
    }

Client would then get the required pizza object in this way,













