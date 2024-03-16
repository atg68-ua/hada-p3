using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.Common;

namespace Library
{
    public class CADCategory
    {
        private string constring { get; }
        public CADCategory()
        {
            constring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database.mdf;Integrated Security=True";
        }
        public bool Read(ENCategory en)
        {
            try
            {
                SqlConnection connection = new SqlConnection(constring);
                connection.Open();
                SqlCommand command = new SqlCommand(null, connection);

                command.CommandText = "SELECT name FROM [dbo].[Category] WHERE name=(@name)";
                SqlParameter nameParam = new SqlParameter("@name", SqlDbType.NVarChar, 32);
                nameParam.Value = en.Name;
                command.Parameters.Add(nameParam);

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
        }
        public List<ENCategory> readAll()
        {
            try
            {
                List<ENCategory> valores = new List<ENCategory>();
                SqlConnection connection = new SqlConnection(constring);
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT name, id FROM [dbo].[Categories]", connection);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    valores.Add(new ENCategory(reader.GetString(0), reader.GetInt32(1)));
                }
                
                reader.Close();
                connection.Close();
                return valores; 
            }
            catch (SqlException ex)
            {
                Console.WriteLine("User operation has failed. Error: {0}", ex.Message);
                return new List<ENCategory>();
            }
        }
    }
}
