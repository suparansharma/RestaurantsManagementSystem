using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Entities
{
    public class Food
    {
        public int Id { get; set; }
        public string foodName { get; set; }
        public string Size { get; set; }
        public int Price { get; set; }
        public string foodType { get; set; }
        public string description { get; set; }

        public Food(int id, string foodName, string size, int price, string foodType, string description)
        {
            Id = id;
            this.foodName = foodName;
            Size = size;
            Price = price;
            this.foodType = foodType;
            this.description = description;
        }
    }
}
