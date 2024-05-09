using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    public class Restaurant
    {
        int id;
        string restaurant_img;
        string restaurant_name;

        public Restaurant(string restaurant_name, string restaurant_img)
        {
            this.restaurant_name = restaurant_name;
            this.restaurant_img = restaurant_img;
        }
        public Restaurant()
        {
            this.restaurant_name = "";
            this.restaurant_img = "";
        }

        public int Id { get => id; set => id = value; }
        public string Restaurant_name { get => restaurant_name; set => restaurant_name = value; }
        public string Restaurant_img { get => restaurant_img; set => restaurant_img = value; }
    }
}
