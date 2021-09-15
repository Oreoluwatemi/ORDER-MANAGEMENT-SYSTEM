using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class OrderDB
    {
        public static Order FindWithOneInput(int id)
        {
            SqlConnection conn = ManagementDataDB.GetConnection();

            string query = "SELECT OrderDate, CustomerId, TotalAmount, OrderNumber FROM [Order] WHERE Id = @id";

            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@id", id);

            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    Order order = new Order();
                    //order.OrderId = reader.GetInt32(0);
                    order.OrderDate = Convert.ToDateTime(reader["OrderDate"]);
                    order.CustomerId = Convert.ToInt32(reader["CustomerId"]);
                    order.TotalAmount = Convert.ToDecimal(reader["TotalAmount"]);
                    order.OrderNumber = reader["OrderNumber"].ToString();

                    return order;
                }
                else
                {
                    return null;
                }               
            }
            catch(SqlException ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }

        public static Order FindWithTwoInput(int id, string orderNo)
        {
            SqlConnection conn = ManagementDataDB.GetConnection();

            string query = "SELECT CustomerId, TotalAmount, OrderDate FROM [Order] WHERE Id = @id AND OrderNumber =@orderNo";

            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@orderNo", orderNo);

            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    Order order = new Order();
                    //order.OrderDate = Convert.ToDateTime(reader["OrderDate"]);
                    order.CustomerId = Convert.ToInt32(reader["CustomerId"]);
                    order.TotalAmount = Convert.ToDecimal(reader["TotalAmount"]);
                    order.OrderDate = Convert.ToDateTime(reader["OrderDate"]);

                    return order;
                }
                else
                {
                    return null;
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }

        public static void DeleteOrder(int id)
        {
            SqlConnection conn = ManagementDataDB.GetConnection();

            string query = "DELETE FROM [Order] WHERE Id = @id";

            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@id", id);
            try
            {
                conn.Open();
                command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }

        public static void AddOrder(Order order)
        {
            SqlConnection conn = ManagementDataDB.GetConnection();

            string querySet = "SET IDENTITY_INSERT [Order] ON";
            string query = "INSERT [Order] (Id, OrderDate, CustomerId, TotalAmount, OrderNumber) VALUES (@id, @OrderDate, @custId, @totalAmount, @orderNumber)";
            
            SqlCommand command1 = new SqlCommand(querySet, conn);
            SqlCommand command = new SqlCommand(query, conn);

            DateTime dateTimeVariable = DateTime.Now;
            command.Parameters.AddWithValue("@id", order.OrderId);
            command.Parameters.AddWithValue("@OrderDate", dateTimeVariable);
            command.Parameters.AddWithValue("@custId", order.CustomerId);
            command.Parameters.AddWithValue("@totalAmount", order.TotalAmount);
            command.Parameters.AddWithValue("@orderNumber", order.OrderNumber);
            try
            {
                conn.Open();
                command1.ExecuteNonQuery();
                command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }


        }

        public static void ModifyOrder(Order order)
        {
            SqlConnection conn = ManagementDataDB.GetConnection();
            string query = "Update [Order] SET CustomerId = @custId, TotalAmount = @totalAmount, OrderNumber = @orderNumber WHERE Id = @id";

            SqlCommand command = new SqlCommand(query, conn);

            command.Parameters.AddWithValue("@id", order.OrderId);
            command.Parameters.AddWithValue("@custId", order.CustomerId);
            command.Parameters.AddWithValue("@totalAmount", order.TotalAmount);
            command.Parameters.AddWithValue("@orderNumber", order.OrderNumber);
            try
            {
                conn.Open();
                command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
