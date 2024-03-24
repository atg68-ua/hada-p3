using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Configuration;

namespace Library
{
    public class CADProduct
    {
        private string constring { get; }
        public CADProduct()
        {
            constring = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
        }
        public bool Create(ENProduct en)
        {
            SqlConnection connection = new SqlConnection(constring);
            try
            {
                connection.Open();

                SqlCommand command = new SqlCommand(null, connection);

                command.CommandText = "INSERT INTO [dbo].[Products] " +
                    "VALUES (@name,@code,@amount,@price,@category,@creationDate)";

                SqlParameter codeParam = new SqlParameter("@code", SqlDbType.NVarChar, 16);
                SqlParameter nameParam = new SqlParameter("@name", SqlDbType.NVarChar, 32);
                SqlParameter amountParam = new SqlParameter("@amount", SqlDbType.Int);
                SqlParameter priceParam = new SqlParameter("@price", SqlDbType.Float);
                SqlParameter categoryParam = new SqlParameter("@category", SqlDbType.Int);
                SqlParameter creationDateParam = new SqlParameter("@creationDate", SqlDbType.DateTime);

                codeParam.Value = en.Code;
                nameParam.Value = en.Name;
                amountParam.Value = en.Amount;
                priceParam.Value = en.Price;
                categoryParam.Value = en.Category;
                creationDateParam.Value = en.CreationDate;

                command.Parameters.Add(codeParam);
                command.Parameters.Add(nameParam);
                command.Parameters.Add(amountParam);
                command.Parameters.Add(priceParam);
                command.Parameters.Add(categoryParam);
                command.Parameters.Add(creationDateParam);

                command.Prepare();
                command.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("User operation has failed. Error: {0}", ex.Message);
                return false;
            }
            finally
            {
                if (connection != null) connection.Close();
            }
        }
        public bool Update(ENProduct en)
        {
            SqlConnection connection = new SqlConnection(constring);
            try
            {
                connection.Open();

                SqlCommand command = new SqlCommand(null, connection);

                command.CommandText = "UPDATE [dbo].[Products] " +
                    "SET name=@name, amount=@amount, price=@price, category=@category, creationDate=@creationDate " +
                    "WHERE code=@code";

                SqlParameter codeParam = new SqlParameter("@code", SqlDbType.NVarChar, 16);
                SqlParameter nameParam = new SqlParameter("@name", SqlDbType.NVarChar, 32);
                SqlParameter amountParam = new SqlParameter("@amount", SqlDbType.Int);
                SqlParameter priceParam = new SqlParameter("@price", SqlDbType.Float);
                SqlParameter categoryParam = new SqlParameter("@category", SqlDbType.Int);
                SqlParameter creationDateParam = new SqlParameter("@creationDate", SqlDbType.DateTime);

                codeParam.Value = en.Code;
                nameParam.Value = en.Name;
                amountParam.Value = en.Amount;
                priceParam.Value = en.Price;
                categoryParam.Value = en.Category;
                creationDateParam.Value = en.CreationDate;

                command.Parameters.Add(codeParam);
                command.Parameters.Add(nameParam);
                command.Parameters.Add(amountParam);
                command.Parameters.Add(priceParam);
                command.Parameters.Add(categoryParam);
                command.Parameters.Add(creationDateParam);

                command.Prepare();
                command.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("User operation has failed. Error: {0}", ex.Message);
                return false;
            }
            finally
            {
                if (connection != null) connection.Close();
            }
        }
        public bool Delete(ENProduct en)
        {
            SqlConnection connection = new SqlConnection(constring);
            try
            {
                connection.Open();

                SqlCommand command = new SqlCommand(null, connection);

                command.CommandText = "DELETE FROM [dbo].[Products] " +
                    "WHERE code=@code";

                SqlParameter codeParam = new SqlParameter("@code", SqlDbType.NVarChar, 16);

                codeParam.Value = en.Code;

                command.Parameters.Add(codeParam);

                command.Prepare();
                command.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("User operation has failed. Error: {0}", ex.Message);
                return false;
            }
            finally
            {
                if (connection != null) connection.Close();
            }
        }
        public bool Read(ENProduct en)
        {
            SqlConnection connection = new SqlConnection(constring);
            try
            {
                connection.Open();

                SqlCommand command = new SqlCommand(null, connection);

                command.CommandText = "SELECT * FROM [dbo].[Products] " +
                    "WHERE code=@code";

                SqlParameter codeParam = new SqlParameter("@code", SqlDbType.NVarChar, 16);

                codeParam.Value = en.Code;

                command.Parameters.Add(codeParam);

                command.Prepare();
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();

                en.Name = reader["name"].ToString();
                en.Code = reader["code"].ToString();
                en.Amount = int.Parse(reader["amount"].ToString());
                en.Price = float.Parse(reader["price"].ToString());
                en.Category = int.Parse(reader["category"].ToString());
                en.CreationDate = DateTime.Parse(reader["creationDate"].ToString());

                connection.Close();
                return true;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("User operation has failed. Error: {0}", ex.Message);
                return false;
            }
            finally
            {
                if (connection != null) connection.Close();
            }
        }
        public bool ReadFirst(ENProduct en)
        {
            SqlConnection connection = new SqlConnection(constring);
            try
            {
                connection.Open();

                SqlCommand command = new SqlCommand(null, connection);

                command.CommandText = "SELECT * FROM [dbo].[Products] ORDER BY id";

                command.Prepare();
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();

                en.Name = reader["name"].ToString();
                en.Code = reader["code"].ToString();
                en.Amount = int.Parse(reader["amount"].ToString());
                en.Price = float.Parse(reader["price"].ToString());
                en.Category = int.Parse(reader["category"].ToString());
                en.CreationDate = DateTime.Parse(reader["creationDate"].ToString());

                connection.Close();
                return true;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("User operation has failed. Error: {0}", ex.Message);
                return false;
            }
            finally
            {
                if (connection != null) connection.Close();
            }
        }
        public bool ReadNext(ENProduct en)
        {
            SqlConnection connection = new SqlConnection(constring);
            try
            {
                connection.Open();

                SqlCommand command = new SqlCommand(null, connection);

                command.CommandText = "SELECT * FROM [dbo].[Products] ORDER BY id";

                command.Prepare();
                SqlDataReader reader = command.ExecuteReader();
                bool found = false;

                while (reader.Read())
                {
                    if (found)
                    {
                        en.Name = reader["name"].ToString();
                        en.Code = reader["code"].ToString();
                        en.Amount = int.Parse(reader["amount"].ToString());
                        en.Price = float.Parse(reader["price"].ToString());
                        en.Category = int.Parse(reader["category"].ToString());
                        en.CreationDate = DateTime.Parse(reader["creationDate"].ToString());
                        return true;
                    }

                    if (reader["code"].ToString() == en.Code)
                        found = true;
                }

                return false;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("User operation has failed. Error: {0}", ex.Message);
                return false;
            }
            finally
            {
                if (connection != null) connection.Close();
            }
        }
        public bool ReadPrev(ENProduct en)
        {
            SqlConnection connection = new SqlConnection(constring);
            try
            {
                connection.Open();

                SqlCommand command = new SqlCommand(null, connection);

                command.CommandText = "SELECT * FROM [dbo].[Products] ORDER BY id";

                command.Prepare();
                SqlDataReader reader = command.ExecuteReader();

                ENProduct prev = new ENProduct();
                bool found = false;

                while (reader.Read())
                {
                    if (reader["code"].ToString() == en.Code)
                    {
                        found = true;
                        break;
                    }

                    prev.Name = reader["name"].ToString();
                    prev.Code = reader["code"].ToString();
                    prev.Amount = int.Parse(reader["amount"].ToString());
                    prev.Price = float.Parse(reader["price"].ToString());
                    prev.Category = int.Parse(reader["category"].ToString());
                    prev.CreationDate = DateTime.Parse(reader["creationDate"].ToString());
                }

                if (found)
                {
                    en.Name = prev.Name;
                    en.Code = prev.Code;
                    en.Amount = prev.Amount;
                    en.Price = prev.Price;
                    en.Category = prev.Category;
                    en.CreationDate = prev.CreationDate;
                    return true;
                }
                return false;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("User operation has failed. Error: {0}", ex.Message);
                return false;
            }
            finally
            {
                if (connection != null) connection.Close();
            }
        }
    }
}
