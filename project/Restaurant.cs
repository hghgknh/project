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
        byte[] restaurant_img;
        string restaurant_name;
        string restaurant_location;
        int account_id;

        public Restaurant(string restaurant_name, byte[] restaurant_img, string restaurant_location, int account_id)
        {
            this.restaurant_name = restaurant_name;
            this.restaurant_img = restaurant_img;
            this.restaurant_location = restaurant_location;
            this.account_id = account_id;
        }
        public Restaurant()
        {
            this.restaurant_name = "";
            this.restaurant_img = null;
            this.restaurant_location = "";
            this.account_id = 0;
        }

        public int Id { get => id; set => id = value; }
        public string Restaurant_name { get => restaurant_name; set => restaurant_name = value; }
        public byte[] Restaurant_img { get => restaurant_img; set => restaurant_img = value; }
        public string Restaurant_location { get => restaurant_location; set => restaurant_location = value; }
        public int Account_id { get => account_id; set => account_id = value; }
    }
}
