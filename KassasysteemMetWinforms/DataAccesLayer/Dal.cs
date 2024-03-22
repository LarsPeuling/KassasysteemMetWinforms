using KassasysteemMetWinforms.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KassasysteemMetWinforms.DataAccesLayer
{
    public class Dal
    {
        private string conString = "Data Source=.;Initial Catalog=Kassasysteem2.0;Integrated Security=True";
        private SqlConnection cnn;
        public Dal()
        {
            SqlConnection cnn = new SqlConnection(conString);
        }

        //DataAccessLayer for Customer

        /// <summary>
        /// Get all customers from the database
        /// </summary>
        /// <returns></returns>
        public DataTable GetAllCustomers()
        {
            using (SqlConnection cnn = new SqlConnection(conString))
            {
                cnn.Open();
                var query = "select * from Customer";
                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    var reader = cmd.ExecuteReader();
                    var dt = new DataTable();
                    dt.Load(reader);
                    cnn.Close();
                    return dt;
                }
            }   
        }

        /// <summary>
        /// Add Customer to database
        /// </summary>
        /// <param name="customer"></param>
        public void AddCustomer(string name)
        {
            using (SqlConnection cnn = new SqlConnection(conString))
            {
                string query = "insert into Customer (Name) values (@name)";
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Update Customer in database
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        public void UpdateCustomer(int id, string name)
        {
            using (SqlConnection cnn = new SqlConnection(conString))
            {
                string query = "update Customer set name = @name where id = @id";
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        /// <summary>
        /// Delete Customer from database
        /// </summary>
        /// <param name="id"></param>
        public void DeleteCustomer(int id)
        {
            using (SqlConnection cnn = new SqlConnection(conString))
            {
                string query = $"delete from Customer where id = {id}";
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }   
            }
        }

        //DataAccessLayer for Employee
        public DataTable GetAllEmployee()
        {
            using (SqlConnection cnn = new SqlConnection(conString))
            {
                cnn.Open();
                var query = "select * from Employee";
                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    var reader = cmd.ExecuteReader();
                    var dt = new DataTable();
                    dt.Load(reader);
                    cnn.Close();
                    return dt;
                }
            }
        }

        /// <summary>
        /// Add Employee to database
        /// </summary>
        /// <param name="employee"></param>
        public void AddEmployee(string name)
        {
            using (SqlConnection cnn = new SqlConnection(conString))
            {
                string query = "insert into Employee (Name) values (@name)";
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Update Employee in database
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        public void UpdateEmployee(int id, string name)
        {
            using (SqlConnection cnn = new SqlConnection(conString))
            {
                string query = "update Employee set name = @name where id = @id";
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Delete Employee from database
        /// </summary>
        /// <param name="id"></param>
        public void DeleteEmployee(int id)
        {
            using (SqlConnection cnn = new SqlConnection(conString))
            {
                string query = $"delete from Employee where id = {id}";
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }


        //DataAccessLayer for Product
        /// <summary>
        /// Get all products from the database
        /// </summary>
        /// <returns></returns>
        public DataTable GetAllProduct()
        {
            using (SqlConnection cnn = new SqlConnection(conString))
            {
                cnn.Open();
                var query = "select * from Product";
                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    var reader = cmd.ExecuteReader();
                    var dt = new DataTable();
                    dt.Load(reader);
                    cnn.Close();
                    return dt;
                }
            }
        }


        //get product by id
        public Product GetProductById(int id)
        {
            Double price = 0;
            using (SqlConnection cnn = new SqlConnection(conString))
            {
                cnn.Open();
                var query = "select * from Product where id = @id";
                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string name = reader["Name"].ToString();
                            string description = reader["Description"].ToString();
                            price = Convert.ToDouble(reader["Price"]);
                            int stock = Convert.ToInt32(reader["Stock"]);
                            var product = new Product(name, price, stock, description);
                            return product;
                        }
                        else
                        {
                            return null;
                        }
                    }
                    
                }
            }
        }

        /// <summary>
        /// Add Product to database
        /// </summary>
        /// <param name="Product"></param>
        public void AddProduct(Product Product)
        {
            using (SqlConnection cnn = new SqlConnection(conString))
            {
                string query = "insert into Product (Name, Price, Stock, Description) values (@name, @price, @stock, @description)";
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    cmd.Parameters.AddWithValue("@name", Product.Name);
                    cmd.Parameters.AddWithValue("@price", Product.Price);
                    cmd.Parameters.AddWithValue("@stock", Product.Stock);
                    cmd.Parameters.AddWithValue("@description", Product.Description);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Update Product in database
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        public void UpdateProduct(int id, int stock)
        {
            using (SqlConnection cnn = new SqlConnection(conString))
            {
                string query = "update Product set stock = @stock where id = @id";
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@stock", stock);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public Double GetPrice(int id)
        {
            Double price = 0;
            using (SqlConnection cnn = new SqlConnection(conString))
            {
                cnn.Open();
                var query = "select Price from Product where id = @id";
                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    var result = cmd.ExecuteScalar();
                    price = Convert.ToDouble(result);
                }
            }
            return price;
        }

        public int GetStock(int id)
        {
            int stock = 0;
            using (SqlConnection cnn = new SqlConnection(conString))
            {
                cnn.Open();
                var query = "select Stock from Product where id = @id";
                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            stock = Convert.ToInt32(reader["Stock"]);
                            return stock;
                        }
                        else
                        {
                            return 0;
                        }
                    }

                }
            }

        }


        /// <summary>
        /// Delete Product from database
        /// </summary>
        /// <param name="id"></param>
        public void DeleteProduct(int id)
        {
            using (SqlConnection cnn = new SqlConnection(conString))
            {
                string query = $"delete from Product where id = {id}";
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }


        /*//DataAccessLayer for Basket
        public DataTable GetAllBasket()
        {
            cnn.Open();
            var query = "select * from Basket";
            var cmd = new SqlCommand(query, cnn);
            var reader = cmd.ExecuteReader();
            var dt = new DataTable();
            dt.Load(reader);
            cnn.Close();
            return dt;
        }

        /// <summary>
        /// Add Basket to database
        /// </summary>
        /// <param name="Basket"></param>
        public void AddBasket(Basket Basket, int customerId)
        {
            using (SqlConnection cnn = new SqlConnection(conString))
            {
                string query = $"insert into Basket (CustomerId) values ({customerId})";
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    cmd.Parameters.AddWithValue("@customerId", customerId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Update Basket in database
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        public void UpdateBasket(int customerId, string name)
        {
            using (SqlConnection cnn = new SqlConnection(conString))
            {
                string query = $"update Basket set name = @name where CustomerId = {customerId}";
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    cmd.Parameters.AddWithValue("@id", customerId);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Delete Basket from database
        /// </summary>
        /// <param name="id"></param>
        public void DeleteBasket(int id)
        {
            using (SqlConnection cnn = new SqlConnection(conString))
            {
                string query = $"delete from Basket where id = {id}";
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }*/
    }
}
