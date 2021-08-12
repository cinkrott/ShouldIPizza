using System;
using System.Collections.Generic;
using System.Text;


namespace ShouldIPizza
{
   public class PizzaWorks
    {
        private PizzaDAO pizzaDao = new PizzaDAO();
        

        public List<Topping> GetToppings()
        {
            List<Topping> toppings = pizzaDao.GetToppings();
            return toppings;
        }

        public string EvaluatePizza(Pizza pizza)
        {
            string result = "";

            if(pizza.SpicySum > 8)
            {
                result = "Whoa cowboy, that's pretty spicy!! Hope you brought your milk! But if that's how you like it, go ahead and pizza!";
            }
            else if(pizza.SaltSum > 10)
            {
                result = "That's too much salt! DO NOT PIZZA!";
            }
            else if(pizza.SweetSum > 8)
            {
                result = "Maybe you should just eat a candy bar, that's way too sweet! DO NOT PIZZA!";
            }
            else if(pizza.RichSum > 10)
            {
                result = "That's too rich for my blood! You need some bite to cut through all that pork fat. DO NOT PIZZA!";
            }
           else if(pizza.BiteSum > 10)
            {
                result = "I've never seen a pizza bite back until now!  Try to balance it out with some richness. DO NOT PIZZA!";
            }
            else if(pizza.SaltSum >= 5 && pizza.SaltSum <= 10 && pizza.SweetSum >= 3 && pizza.SweetSum <= 7 && pizza.SpicySum >= 3 && pizza.SpicySum <= 7)
            {
                result = "It's....it's...BEAUTIFUL! This is pizza in it's ultimate form. You did it. You've reached pizza Nirvana. Enjoy bliss, and PIZZA ON DUDES!";
            }
            else if(pizza.RichSum >=5 && pizza.RichSum <= 10 && pizza.BiteSum >= 5 && pizza.BiteSum <= 10)
            {
                result = "Somebody knows what they're doing.  You've built a true winner. GET YOUR PIZZA ON!";
            }
            else
            {
                result = "This pizza should be just fine. Go forth and PIZZA!";
            }
            

            return result;
        }

        public Pizza ToppingProfileSum(Topping toppingOne, Topping toppingTwo, Topping toppingThree)
        {
            int saltSum = toppingOne.Salt + toppingTwo.Salt + toppingThree.Salt;
            int sweetSum = toppingOne.Sweet + toppingTwo.Sweet + toppingThree.Sweet;
            int biteSum = toppingOne.Bite + toppingTwo.Bite + toppingThree.Bite;
            int richSum = toppingOne.Rich + toppingTwo.Rich + toppingThree.Rich;
            int umamiSum = toppingOne.Umami + toppingTwo.Umami + toppingThree.Umami;
            int spicySum = toppingOne.Spicy + toppingTwo.Spicy + toppingThree.Spicy;
            Pizza result = new Pizza(saltSum, sweetSum, biteSum, richSum, umamiSum, spicySum);
            return result;
        }

        public Topping GetToppingById(int toppingId)
        {
            Topping topping = pizzaDao.GetToppingById(toppingId);
            return topping;
        }
    }
}
