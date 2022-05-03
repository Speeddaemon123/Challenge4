using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge4
{
    internal class Program
    {
        
        

        static void Main(string[] args)
        {
            

            #region "Challenge 4"
            List<FoodItems> objFoodItem = new List<FoodItems>();// Object creation of list item
            FillTheRestaurantList(objFoodItem);//Calling the function to populate the restaurant list
            PlaceOrder(objFoodItem);//Taking input and placing the order
            #endregion
            
          
        }

        private static void FillTheRestaurantList(List<FoodItems> objFoodItem)//function created to hold the restaurant name,foodname and price
        {
            var fd1 = new FoodItems { RestaurantName = "Desi Tadka", FoodName = "Dal Khichdi", FoodPrice =10 };
            var fd2 = new FoodItems { RestaurantName = "Desi Tadka", FoodName = "Paneer Kadhai", FoodPrice = 15 };
            var fd3 = new FoodItems { RestaurantName = "Desi Tadka", FoodName = "Roti", FoodPrice = 5 };
            var fd4 = new FoodItems { RestaurantName = "Desi Tadka", FoodName = "Icecream", FoodPrice = 20 };
            var fd5 = new FoodItems { RestaurantName = "16 Candles", FoodName = "Pasta", FoodPrice = 35 };
            var fd6 = new FoodItems { RestaurantName = "16 Candles", FoodName = "Milk shake", FoodPrice = 25 };
            var fd7 = new FoodItems { RestaurantName = "Tequila Mockingbird", FoodName = "Pizza", FoodPrice = 40 };
            var fd8 = new FoodItems { RestaurantName = "Tequila Mockingbird", FoodName = "Veg Burger", FoodPrice = 35 };
            var fd9 = new FoodItems { RestaurantName = "Tequila Mockingbird", FoodName = "Sadwitch", FoodPrice = 12 };
            objFoodItem.AddRange(new[] { fd1, fd2, fd3, fd4, fd5, fd6, fd7, fd8, fd9 });

        }

        static void PlaceOrder(List<FoodItems> objFoodItem)
        {

            string foodItemName = String.Empty;
            foreach (var item in objFoodItem)
            {
                Console.WriteLine(item.FoodName);

            }
            do
            {
                
                Console.WriteLine("Enter the food item you would like to order.");
                Console.WriteLine("press 'Escape' to exit\n");
                foodItemName = Console.ReadLine();
                FoodItems FI = objFoodItem.FirstOrDefault(food => food.FoodName.ToLower() == foodItemName.ToLower());
                if (FI != null)
                {
                    Console.WriteLine("{0}, {1}, ${2}", FI.RestaurantName, FI.FoodName, FI.FoodPrice.ToString());
                }
                else
                {
                    Console.WriteLine("Currently there are no restaurant serving the given item. Please try something else.");
                }

            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
       
    }
}
