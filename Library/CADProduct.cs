using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data;

namespace Library
{
    public class CADProduct
    {
        private string constring { get; }
        public CADProduct()
        {
            constring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database.mdf;Integrated Security=True";
        }
        public bool Create(ENProduct en)
        {
            try
            {
                /**
                 * CREATE TABLE [dbo].[Products]
                    (
                    [id] INT IDENTITY (1, 1) NOT NULL,
                    [name] NVARCHAR (32) NOT NULL,
                    [code] NVARCHAR (16) NOT NULL,
                    [amount] INT NOT NULL,
                    [price] FLOAT NOT NULL,
                    [category] INT NOT NULL,
                    [creationDate] DATETIME NOT NULL,
                    PRIMARY KEY CLUSTERED ([id] ASC),
                    UNIQUE NONCLUSTERED ([code] ASC),
                    constraint FK_Products_category foreign key (category)
                    references Categories(id)
                    )
                 **/
                SqlConnection connection = new SqlConnection(constring);
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
        }
        public bool Update(ENProduct en)
        {
            return true;
        }
        public bool Delete(ENProduct en)
        {
            return true;
        }
        public bool Read(ENProduct en)
        {
            return true;
        }
        public bool ReadFirst(ENProduct en)
        {
            return true;
        }
        public bool ReadNext(ENProduct en)
        {
            return true;
        }
        public bool ReadPrev(ENProduct en)
        {
            return true;
        }
    }
}
