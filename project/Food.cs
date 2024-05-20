using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    public class Food
    {
        int id;
        byte[] food_img;
        string food_name;
        string food_price;
        int time;

        public Food(int id, byte[] food_img, string food_name, string food_price, int time)
        {
            this.id = id;
            this.food_img = food_img;
            this.food_name = food_name;
            this.food_price = food_price;
            this.time = time;
        }
        public Food()
        {
            this.id = 0;
            this.food_img = null;
            this.food_name = "";
            this.food_price = "";
            this.time = 0;
        }

        public int Id { get => id; set => id = value; }
        public byte[] Food_img { get => food_img; set => food_img = value; }
        public string Food_name { get => food_name; set => food_name = value; }
        public string Food_price { get => food_price; set => food_price = value; }
        public int Time { get => time; set => time = value; }
    }
}
