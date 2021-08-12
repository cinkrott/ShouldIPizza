using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;



namespace ShouldIPizza
{
    public class PizzaDAO
    {
        string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=Pizza;Integrated Security=True";

        string sqlGetToppings = "SELECT * FROM Toppings";

        string sqlGetToppingById = "SELECT * FROM Toppings WHERE Id = @id";

        public List<Topping> GetToppings()
        {
            List<Topping> toppings = new List<Topping>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(sqlGetToppings, conn);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["Id"]);
                    string name = Convert.ToString(reader["Name"]);
                    int salt = Convert.ToInt32(reader["Salt"]);
                    int sweet = Convert.ToInt32(reader["Sweet"]);
                    int bite = Convert.ToInt32(reader["Bite"]);
                    int rich = Convert.ToInt32(reader["Rich"]);
                    int umami = Convert.ToInt32(reader["Umami"]);
                    int spicy = Convert.ToInt32(reader["Spicy"]);
                    Topping topping = new Topping(id, name, salt, sweet, bite, rich, umami, spicy);
                    toppings.Add(topping);

                }
            }
            return toppings;
        }

        public Topping GetToppingById(int toppingId)
        {
            List<Topping> toppings = new List<Topping>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(sqlGetToppingById, conn);

                cmd.Parameters.AddWithValue("@id", toppingId);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["Id"]);
                    string name = Convert.ToString(reader["Name"]);
                    int salt = Convert.ToInt32(reader["Salt"]);
                    int sweet = Convert.ToInt32(reader["Sweet"]);
                    int bite = Convert.ToInt32(reader["Bite"]);
                    int rich = Convert.ToInt32(reader["Rich"]);
                    int umami = Convert.ToInt32(reader["Umami"]);
                    int spicy = Convert.ToInt32(reader["Spicy"]);
                    Topping topping = new Topping(id, name, salt, sweet, bite, rich, umami, spicy);
                    toppings.Add(topping);
                }
            }
            Topping returnedTopping = toppings[0];
            return returnedTopping;
            
        }
    }
}
