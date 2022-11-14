using System;

namespace _02._Summer_Outfit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int degrees = int.Parse(Console.ReadLine());
            string time = Console.ReadLine();

            string outfit = "", shoes = "";

            if (10 <= degrees && degrees <= 18)
            {

                switch (time)
                {
                    case "Morning":
                        outfit = "Sweatshirt";
                        shoes = "Sneakers";
                        break;
                    case "Afternoon":
                        outfit = "Shirt";
                        shoes = "Moccasins";
                        break ;
                    //case "Evening": 
                    default:
                        outfit = "Shirt";
                        shoes = "Moccasins";
                        break;
                   
                }
            }
            else if (18 <= degrees && degrees <= 24)
            {
                switch (time)
                {
                    case "Morning":
                        outfit = "Shirt";
                        shoes = "Moccasins";
                        break;
                    case "Afternoon":
                        outfit = "T-Shirt";
                        shoes = "Sandals";
                        break;
                    //case "Evening": 
                    default:
                        outfit = "Shirt";
                        shoes = "Moccasins";
                        break;

                }
            }
            else
            {
                switch (time)
                {
                    case "Morning":
                        outfit = "T-Shirt";
                        shoes = "Sandals";
                        break;
                    case "Afternoon":
                        outfit = "Swim Suit";
                        shoes = "Barefoot";
                        break;
                    //case "Evening": 
                    default:
                        outfit = "Shirt";
                        shoes = "Moccasins";
                        break;

                }
            }


            Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
        }
    }
}
