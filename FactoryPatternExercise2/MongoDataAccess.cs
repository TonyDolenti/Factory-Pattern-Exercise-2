using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public class MongoDataAccess : IDataAccess
    {
        public static List<Product> Products = new List<Product>()
        {
            new Product(){ Name = "Xbox", Price = 350},
            new Product(){ Name = "Drone", Price = 600},
            new Product(){ Name = "Computer", Price = 1300},
            new Product(){ Name = "Car", Price = 16000},
        };

        public List<Product> LoadData()
        {
            Console.WriteLine($"I am reading data from Mongo Data Access.");
            return Products;
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data from a Mongo Data Access");
        }
    }
}
