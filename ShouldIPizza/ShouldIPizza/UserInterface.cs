using System;
using System.Collections.Generic;
using System.Text;

namespace ShouldIPizza
{
    class UserInterface
    {
        private PizzaWorks pizzaWorks = new PizzaWorks();
        

        public void RunInterface()
        {
            Console.WriteLine(@"     _______. __    __    ______    __    __   __       _______  ");
            Console.WriteLine(@"    /       ||  |  |  |  /   __ \  |  |  |  | |  |     |       \ ");
            Console.WriteLine(@"   |   (----`|  |__|  | |  |  |  | |  |  |  | |  |     |  .--.  |");
            Console.WriteLine(@"    \   \    |   __   | |  |  |  | |  |  |  | |  |     |  |  |  |");
            Console.WriteLine(@".----)   |   |  |  |  | |  `--'  | |  `--'  | |  `----.|  '--'  |");
            Console.WriteLine(@"|_______/    |__|  |__|  \______/   \______/  |_______||_______/ ");
            Console.WriteLine(@"                               _______                           ");
            Console.WriteLine(@"                              |__   __|                          ");
            Console.WriteLine(@"                                 | |                             ");
            Console.WriteLine(@"                                 | |                             ");
            Console.WriteLine(@"                               __| |__                           ");
            Console.WriteLine(@"                              |_______|                          ");
            Console.WriteLine(@"        .______    __   ________   ________      ___             ");
            Console.WriteLine(@"        |      \  |  ||     /  / |     /  /     /    \            ");
            Console.WriteLine(@"        |  |_)  | |  | `---/  /   `---/  /     /  ^   \           ");
            Console.WriteLine(@"        |   ___/  |  |    /  /       /  /     /  /_ \  \          ");
            Console.WriteLine(@"        |  |      |  |   /  /----.  /  /----./  ____ _  \         ");
            Console.WriteLine(@"        | _|      |__|  /________| /________/__/      \_ \        ");


                                                                
            bool done = false;

            while (!done)
            {
                MainMenu();

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        ListToppings();
                        break;
                    case "2":
                        BuildPizza();
                        break;
                    case "3":
                        RandomPizzaGenerator();
                        break;
                    case "4":
                        About();
                        break;
                    case "q":
                    case "Q":
                        done = true;
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("Try Again!");
                        break;
                }
            }
        }


        public void MainMenu()
        {
            
            Console.WriteLine();
            Console.WriteLine("Face your pizza destiny!");
            Console.WriteLine("1 - List Toppings");
            Console.WriteLine("2 - Choose Toppings");
            Console.WriteLine("3 - SPIN THE WHEEL");
            Console.WriteLine("4 - Who are you to judge my pizza?!");
            Console.WriteLine("Q - quitter");
        }

        public void ListToppings()
        {
            Console.WriteLine();
            Console.WriteLine();
            List<Topping> toppings = pizzaWorks.GetToppings();

            //foreach(Topping topping in toppings)
            //{
            //    Console.WriteLine(topping.Id + " " + topping.Name);
            //}
            for(int i = 0; i < 3; i++)
            {
                Console.Write((toppings[i].Id) + ") " + toppings[i].Name.PadRight(21));                
            }
            Console.WriteLine();
            for (int i = 3; i < 6; i++)
            {
                Console.Write(toppings[i].Id + ") " + toppings[i].Name.PadRight(21));
            }
            Console.WriteLine();
            for (int i = 6; i < 9; i++)
            {
                Console.Write(toppings[i].Id + ") " + toppings[i].Name.PadRight(21));
            }
            Console.WriteLine();
            for (int i = 9; i < 12; i++)
            {
                Console.Write(toppings[i].Id + ") " + toppings[i].Name.PadRight(19));
            }
            Console.WriteLine();
            for (int i = 12; i < 15; i++)
            {
                Console.Write(toppings[i].Id + ") " + toppings[i].Name.PadRight(19));
            }
            Console.WriteLine();
            for (int i = 15; i < 18; i++)
            {
                Console.Write(toppings[i].Id + ") " + toppings[i].Name.PadRight(19));
            }
            Console.WriteLine();
            for (int i = 18; i < 21; i++)
            {
                Console.Write(toppings[i].Id + ") " + toppings[i].Name.PadRight(19));
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }

        public void BuildPizza()
        {
           
            Console.Write("Enter three topping ID's, separated by spaces: ");
            string toppingChoices = Console.ReadLine();
            string[] splitToppingChoices = toppingChoices.Split(' ');
            int toppingOneId = int.Parse(splitToppingChoices[0]);
            int toppingTwoId = int.Parse(splitToppingChoices[1]);
            int toppingThreeId = int.Parse(splitToppingChoices[2]);
            Topping toppingOne = pizzaWorks.GetToppingById(toppingOneId);
            Topping toppingTwo = pizzaWorks.GetToppingById(toppingTwoId);
            Topping toppingThree = pizzaWorks.GetToppingById(toppingThreeId);
            Console.Write($"You have selected: {toppingOne.Name}, {toppingTwo.Name}, and {toppingThree.Name}. SHALL WE PROCEED?! (Y/N): ");
            string response = Console.ReadLine();
            if(response.ToUpper() == "Y")
            {
            Pizza pizza = pizzaWorks.ToppingProfileSum(toppingOne, toppingTwo, toppingThree);
            Console.WriteLine(pizzaWorks.EvaluatePizza(pizza));
            }
            else if(response.ToUpper() == "N")
            {
                Console.WriteLine("Maybe next time, champ.");
                MainMenu();
            }
            else
            {
                Console.WriteLine("Something went wrong, see you on the other side.");
                MainMenu();
            }

          
        }

        public void RandomPizzaGenerator()
        {
            Random r = new Random();
            int toppingOneId = r.Next(1, 21);
            int toppingTwoId = r.Next(1, 21);
            int toppingThreeId = r.Next(1, 21);
            Topping toppingOne = pizzaWorks.GetToppingById(toppingOneId);
            Topping toppingTwo = pizzaWorks.GetToppingById(toppingTwoId);
            Topping toppingThree = pizzaWorks.GetToppingById(toppingThreeId);
            Console.Write($"Your random toppings are: {toppingOne.Name}, {toppingTwo.Name}, and {toppingThree.Name}. Press 'C' to continue. ");
            string response = Console.ReadLine();
            if (response.ToUpper() == "C")
            {
            Pizza pizza = pizzaWorks.ToppingProfileSum(toppingOne, toppingTwo, toppingThree);
            Console.WriteLine(pizzaWorks.EvaluatePizza(pizza));
            }
            else
            {
                Console.WriteLine("I SAID HIT C!");
              
            }
        }

        public void About()
        {
            Console.WriteLine("I'm Charlie, and before starting to learn C#, I made pizzas for 20 years. I've seen it all.");
            Console.WriteLine("In this program I've translated flavor profiles into number values and based on my years of experience and ");
            Console.WriteLine("pizza intuition, I have developed precise formulae to determine balances of flavors and overall enjoyability.");
            Console.WriteLine("But, this is only based on my (educated) opinion, and if you disagree, go ahead and enjoy the pizza the way ");
            Console.WriteLine("you like it...just don't expect me to have a slice :)");
        }

    }
}
