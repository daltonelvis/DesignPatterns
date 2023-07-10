
Facade is used when you want to hide the complex implementation one example is 
we have a some functioniality like below to add to cart. Without facade it would be something like
this.

UserclickedADDtoCart()
{

 GetProductCatalog() 

 if(CheckProductExists())
   if(CheckifproductCanBeshippedTotheAddress())
     AddtoCart()
     UpdatePrice()

}

In facade all this complex information will be hidden

UserclickedADDtoCart()
{
  ShoppingCartFacade.AddToCart() 
}

All the complex logic of getting product, checking, calculating the price is all written inside 
shoppingcartfacade.AddToCart()
