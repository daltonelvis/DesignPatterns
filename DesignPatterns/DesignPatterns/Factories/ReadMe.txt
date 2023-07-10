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

if there are 2 separate classes one is related to Pizza creation and second is calculating price we have to repeat the logic of object creation in both the places and get the correct object to calculate the price and makepizza

Suppose something changes in the logic for example a new pizza type is added or we have to change chicken to CHICKEN then we have to change it in 
both the places.

To Avoid this we can move the object creation logic to a common method and this would be a simple factory

the client code will then change to something like this, Any change needed we would just change the common method

CustomerOrder(string PizzaType)
{
 PizzaFactory.MakePizza(PizzaType);
}

here MakePizza will have the if logic to check the pizza type and return the correct Pizza object



