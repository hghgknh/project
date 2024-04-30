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
                connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\visual studio\\project\\project\\Database1.mdf\";Integrated Security=True";
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
            adapter.Dispose();
            Account acc = new Account();
            acc.Id = int.Parse(table.Rows[0]["id"].ToString());
            acc.Name = table.Rows[0]["name"].ToString();
            acc.Password = table.Rows[0]["password"].ToString();
            acc.Email = table.Rows[0]["email"].ToString();
            acc.Location = table.Rows[0]["location"].ToString();
            //acc.Phone_num = table.Rows[0]["phone_num"].ToString();
            //acc.Type = table.Rows[0]["type"].ToString();
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
        }
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
        }
        public DataTable SelectRestaurantFood(int a)
        {
            SqlCommand cmd = new SqlCommand($"SELECT Restaurant.restarant_name,Food.food_name,Food.food_price\r\n" +
            $"FROM Restaurant_Food INNER JOIN Food ON Restaurant_food.food_id = Food.Id\r\n" +
            $"WHERE Restaurant_Food.restaurant_id = {a};", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            adapter.Dispose();
            if (table != null) return table;
            else return null;
        }
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
        }
        public bool UpdateAcc(Account account)
        {
            SqlCommand cmd = new SqlCommand("UPDATE Account SET name = @name, password = @password, email = @email, location = @location WHERE Id = @id", connection);
            cmd.Parameters.AddWithValue("@id", account.Id);
            cmd.Parameters.AddWithValue("@name", account.Name);
            cmd.Parameters.AddWithValue("@password", account.Password);
            cmd.Parameters.AddWithValue("@email", account.Email);
            cmd.Parameters.AddWithValue("@Location", account.Location);

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
        public bool InsertImage(string x, string a, string b)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Restaurant VALUES ("+
                "@image, @restaurant_name)", connection);
            cmd.Parameters.AddWithValue("@image", File.ReadAllBytes($"{x}"));
            cmd.Parameters.AddWithValue("@restaurant_name", a);
            cmd.Parameters.AddWithValue("@restaurant_location", b);

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
