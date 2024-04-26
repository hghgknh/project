using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    public class Products
    {
        int id;
        int food_id;
        string product;

        public Products(int food_id, string product)
        {
            this.food_id = food_id;
            this.product = product;
        }
        public Products()
        {
            this.food_id = 0;
            this.product = "";
        }

        public int Id { get => id; set => id = value; }
        public int Food_id { get => food_id; set => food_id = value; }
        public string Product { get => product; set => product = value; }
    }
}
