using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task04._28._23.Services.Interfaces.RestaurantInterface;

namespace Task04._28._23.Services.Implementations.Restaurant
{
    internal class RestaurantServices : IRestaurantServices
    {
     List<   Models. Restaurant> restaurants = new List< Models.Restaurant>();
        public void Create(string name)
        {
           
            Models.Restaurant restaurant =new Models.Restaurant(name);
            restaurant.Name = name;
            restaurants.Add(restaurant);
         }


        public void Delete(string name)
        {
            foreach (var item in restaurants)
            {
                if (item.Name==name)
                {
                    restaurants.Remove(item);
                }

            }
        }

        public Models.Restaurant GetById(int id)
        {
           Models.Restaurant restaurant=restaurants.Find(x => x.Id==id);
            return restaurant;
        }

        public void Update(string name)
        {
            foreach (var item in restaurants)
            {
                if (item.Name==name)
                {
                    Console.WriteLine(name);
                }
            }
        }
    }
}
