using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarClassLibrary
{
    public class Store
    {   
        //a list of type Car
        public List<Car> CarList { get; set; }
        public List<Car> ShoppingList { get; set; }

        public Store() //Constructor method
        { 
            CarList = new List<Car>();
            ShoppingList = new List<Car>();
        }
        public decimal Checkout()
        {
            //initialize the total cost
            decimal totalCost = 0;

            foreach (Car car in ShoppingList) 
            { 
                totalCost += car.Price;
            }

            ShoppingList.Clear();

            return totalCost;
        }
    }
}
