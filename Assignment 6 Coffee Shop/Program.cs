using System;

namespace Assignment_6_Coffee_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            Drink[] drinks = new Drink[10];


            drinks[0] = new Drink("coffee");
            drinks[1] = new Drink("tea");
            drinks[2] = new Drink("Juice");
            drinks[3] = new Drink("Juice");

            int countOfCoffee = 0;
            int countOfJuice = 0;
            int countOfTea = 0;

            for (int i = 0; i < drinks.Length; i++)
            {
                if (drinks[i] != null)
                {


                    if (drinks[i].GetName() == "coffee")
                    {
                        countOfCoffee++;
                    }
                    else if (drinks[i].GetName() == "Tea")
                    {
                        countOfTea++;
                    }
                    else if (drinks[i].GetName() == "Juice")
                    {
                        countOfJuice++;
                    }
                }
            }
            Console.WriteLine("coffees sole" + countOfCoffee);
            Console.WriteLine("teas sole" + countOfTea);
            Console.WriteLine("juices sole" + countOfJuice);
        }
    }
}
