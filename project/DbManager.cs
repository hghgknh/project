using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Principal;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace project
{
    public class DbManager
    {
        private static DbManager instance = null;
        private string connectionString;
        private SqlConnection connection;
        public DbManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DbManager();
                }
                return instance;
            }
        }

        public DbManager()
        {
            try
            {
                connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\visual studio\\project\\project\\Database1.mdf\";Integrated Security=True;MultipleActiveResultSets=True";
                connection = new SqlConnection(connectionString);
                connection.Open();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public void Dispose()
        {
            connection.Close();
            instance = null;
        }




        /*
        public DataTable SelectMenu()
        {
            SqlCommand cmd = new SqlCommand("Select * FROM MenuItem", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            adapter.Dispose();
            return table;
        }*/
        public bool InsertAcc(Account account)
        {
            SqlCommand cmd = new SqlCommand("Insert into Account VALUES(" +
            "@name,@password,@email,@location,@phone_num,@type)", connection);
            cmd.Parameters.AddWithValue("@name", account.Name);
            cmd.Parameters.AddWithValue("@password", account.Password);
            cmd.Parameters.AddWithValue("@email", account.Email);
            cmd.Parameters.AddWithValue("@location", account.Location);
            cmd.Parameters.AddWithValue("@phone_num", account.Phone_num);
            cmd.Parameters.AddWithValue("@type", account.Type);

            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        public bool SearchForName(string x)
        {
            SqlCommand cmd = new SqlCommand("Select name FROM Account WHERE name=@name", connection);
            cmd.Parameters.AddWithValue("@name", x);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            adapter.Dispose();
            if (table != null) return true;
            else return false;
        }
        public bool SelectAccExist(string x, string y)
        {
            SqlCommand cmd = new SqlCommand("Select COUNT(*) FROM Account WHERE name=@name AND password = @password", connection);
            cmd.Parameters.AddWithValue("@name", x);
            cmd.Parameters.AddWithValue("@password", y);
            int count = (int)cmd.ExecuteScalar();
            return count > 0;
        }
        public bool SelectAcc(Account account)
        {
            SqlCommand cmd = new SqlCommand("Select * FROM Account WHERE Id = @id", connection);
            cmd.Parameters.AddWithValue("@id", account.Id);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            adapter.Dispose();
            if (table != null) return true;
            else return false;
        }
        public string SelectAccTypeById(int a)
        {
            SqlCommand cmd = new SqlCommand("SELECT type FROM Account WHERE Id = @username", connection);
            cmd.Parameters.AddWithValue("@username", a);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            adapter.Dispose();
            //Account account = new Account();
            if (table.Rows.Count > 0)
            {
                return table.Rows[0]["type"].ToString();
            }
            else
            {
                return null;
            }
        }
        public int SelectAccIdByUsername(string username)
        {
            SqlCommand cmd = new SqlCommand("SELECT Id FROM Account WHERE name = @username", connection);
            cmd.Parameters.AddWithValue("@username", username);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            adapter.Dispose();
            //Account account = new Account();
            if (table.Rows.Count > 0)
            {
                return int.Parse(table.Rows[0]["Id"].ToString());
            }
            else { return 0; }
        }

        public bool DeleteAcc(int a)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM Account WHERE Id = @id", connection);
            cmd.Parameters.AddWithValue("@id", a);
            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }/*
        public int Select_string1(string a, string b, string x, string y)
        {
            SqlCommand cmd = new SqlCommand($"SELECT {a} FROM {b} WHERE {x} = {y}", connection);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            adapter.Dispose();
            //Account account = new Account();
            if (table.Rows.Count > 0)
            {
                return int.Parse(table.Rows[0]["Id"].ToString());
            }
            else { return 0; }
        }*/

        public bool UpdateAccLocation(int id, string location)
        {
            SqlCommand cmd = new SqlCommand("UPDATE Account SET location = @Location WHERE Id = @id", connection);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@Location", location);

            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public Account SelectPerAcc(int x)
        {
            SqlCommand cmd = new SqlCommand("Select * FROM Account WHERE Id = @id", connection);
            cmd.Parameters.AddWithValue("@id", x);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            Account acc = new Account();
            acc.Id = int.Parse(table.Rows[0]["Id"].ToString());
            acc.Name = table.Rows[0]["Name"].ToString();
            acc.Password = table.Rows[0]["Password"].ToString();
            acc.Location = table.Rows[0]["Location"].ToString();
            acc.Email = table.Rows[0]["Email"].ToString();
            adapter.Dispose();
            return acc;
        }
        public int SelectCount(string a)
        {
            SqlCommand cmd = new SqlCommand($"Select Count(*) From Restaurant", connection);
            //cmd.Parameters.AddWithValue("@id", x);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            adapter.Dispose();
            int x = Convert.ToInt32(cmd.ExecuteScalar());
            return x;
        }
        /*
        public bool InsertProducts(Products products)
        {
            SqlCommand cmd = new SqlCommand("Insert into Products VALUES(" +
            "@food_id,@product)", connection);
            cmd.Parameters.AddWithValue("@food_id", products.Food_id);
            cmd.Parameters.AddWithValue("@product", products.Product);

            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }*/
        public DataTable SelectRestaurantFood(int a)
        {
            SqlCommand cmd = new SqlCommand($"SELECT Restaurant.rastaurant_name, Food.food_name, Food.food_price \r\n" + 
                $"FROM Restaurant \r\n" +
                $"INNER JOIN Restaurant_Food ON Restaurant.Id = Restaurant_Food.restaurant_id \r\n" +
                $"INNER JOIN Food ON Restaurant_Food.food_id = Food.Id \r\n" +
                $"WHERE Restaurant_Food.restaurant_id = @restaurantId", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            adapter.Dispose();
            if (table != null) return table;
            else return null;
        }/*
        public DataTable SelectProducts(int x)
        {
            SqlCommand cmd = new SqlCommand("Select * From Products Where food_id = @id", connection);
            cmd.Parameters.AddWithValue("@id", x);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            adapter.Dispose();
            return table;
        }
        public DataTable SelectIdFromProduct(int x)
        {
            SqlCommand cmd = new SqlCommand("Select * From Food Where Id = @id", connection);
            cmd.Parameters.AddWithValue("@id", x);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            adapter.Dispose();
            return table;
        }*/
        public bool UpdateAcc(int x)
        {
            SqlCommand cmd = new SqlCommand("UPDATE Account SET name = @name, password = @password, email = @email, location = @location WHERE Id = @id", connection);
            cmd.Parameters.AddWithValue("@id", x);

            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool InsertImage(string x, string a, string b, int y)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Restaurant VALUES ("+
                "@image, @restaurant_name, @restaurant_location, @account_id)", connection);
            cmd.Parameters.AddWithValue("@image", File.ReadAllBytes($"{x}"));
            cmd.Parameters.AddWithValue("@restaurant_name", a);
            cmd.Parameters.AddWithValue("@restaurant_location", b);
            cmd.Parameters.AddWithValue("@account_id", y);

            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }/*
        public DataTable SelectRestaurant(int id)
        {
            SqlCommand cmd = new SqlCommand("SELECT ImageData, restaurant_name, restaurant_location, account_id FROM Restaurant WHERE Id = @id", connection);
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            adapter.Dispose();
            return table;
        }
        public DataTable SelectCountid_Restaurants(int y, int z)
        {
            SqlCommand cmd = new SqlCommand($"Select * From Restaurant Order by Id Offset {y} Limit {z}", connection);
            //cmd.Parameters.AddWithValue("@id", x);     int x,
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            adapter.Dispose();
            Restaurant restaurant = new Restaurant();
            restaurant.Id = int.Parse(table.Rows[0]["id"].ToString());
            restaurant.Restaurant_img = table.Rows[0]["restaurant_img"].ToString();
            restaurant.Restaurant_name = table.Rows[0]["restaurant_name"].ToString();
            return table;

        }*//*
        public Restaurant SelectRestaurant(int offset, int limit)
        {
            string query = $"SELECT restaurant_img, restaurant_name, restaurant_location, account_id FROM Restaurant OFFSET {offset} LIMIT {limit}";
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            adapter.Dispose();
            Restaurant restaurant = new Restaurant();
            restaurant.Id = int.Parse(table.Rows[0]["id"].ToString());
            restaurant.Restaurant_img = Convert.FromBase64String(table.Rows[0]["restaurant_img"].ToString());
            restaurant.Restaurant_name = table.Rows[0]["restaurant_name"].ToString();
            restaurant.Restaurant_location = table.Rows[0]["restaurant_location"].ToString();
            restaurant.Account_id = (int)table.Rows[0]["account_id"];// <--    ==   restaurant.Account_id = int.Parse(table.Rows[0]["account_id"].ToString());
            return restaurant;
        }*/
        /*
        public int SelectRestaurants()
        {
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Restaurant", connection);
            int count = (int)cmd.ExecuteScalar();
            return count;
        }*/
        public int CountRestaurants(int offset, int? limit = null)
        {
            SqlCommand cmd = new SqlCommand($"SELECT * FROM Restaurant OFFSET {offset} LIMIT {limit}", connection);
            int count = (int)cmd.ExecuteScalar();// <--    ==   int count = int.Parse(cmd.ExecuteScalar().ToString());
            return count;
        }
        public List<Restaurant> SelectRestaurants(int offset, int limit = 6)
        {
            List<Restaurant> restaurants = new List<Restaurant>();

            // Query to fetch paginated results
            string query = $"SELECT ID, restaurant_img, rastaurant_name, restaurant_location, account_id FROM Restaurant ORDER BY ID OFFSET @offset ROWS FETCH NEXT @limit ROWS ONLY";

            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@offset", offset);
                cmd.Parameters.AddWithValue("@limit", limit);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Restaurant restaurant = new Restaurant();
                        restaurant.Id = reader.GetInt32(0);
                        restaurant.Restaurant_img = (byte[])reader[1]; // Read the image data
                        restaurant.Restaurant_name = reader.GetString(2); // Adjusted index for correct column
                        restaurant.Restaurant_location = reader.GetString(3);
                        restaurant.Account_id = reader.GetInt32(4);
                        restaurants.Add(restaurant);
                    }
                }
            }

            return restaurants;
        }
        public Restaurant SelectRestaurant(int x)
        {
            SqlCommand cmd = new SqlCommand($"SELECT restaurant_img, restaurant_name, restaurant_location, account_id FROM Restaurant WHERE Id = @id", connection);
            cmd.Parameters.AddWithValue("@id", x);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            adapter.Dispose();
            Restaurant restaurant = new Restaurant();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    restaurant.Id = reader.GetInt32(0);
                    restaurant.Restaurant_img = (byte[])reader[1];
                    restaurant.Restaurant_name = reader.GetString(2);
                    restaurant.Restaurant_location = reader.GetString(3);
                    restaurant.Account_id = reader.GetInt32(4);
                }
            }
            return restaurant;
        }
        public bool InsertFood(string x, string a, string b, int y)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Food VALUES (" +
                "@image, @restaurant_name, @restaurant_location, @account_id)", connection);
            cmd.Parameters.AddWithValue("@image", File.ReadAllBytes($"{x}"));
            cmd.Parameters.AddWithValue("@restaurant_name", a);
            cmd.Parameters.AddWithValue("@restaurant_location", b);
            cmd.Parameters.AddWithValue("@account_id", y);

            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public Food SelectFood(int x)
        {
            SqlCommand cmd = new SqlCommand($"SELECT food_name, food_price, time FROM Food WHERE Id = @id", connection);
            cmd.Parameters.AddWithValue("@id", x);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            adapter.Dispose();
            Food food = new Food();
            food.Food_name = table.Rows[0]["Name"].ToString();
            food.Food_price = table.Rows[0]["Password"].ToString();
            food.Time = (int)table.Rows[0]["Location"];
            return food;
        }
        public bool DeleteFood(int a)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM Food WHERE Id = @id", connection);
            cmd.Parameters.AddWithValue("@id", a);
            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
