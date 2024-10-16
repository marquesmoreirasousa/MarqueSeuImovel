using MarqueSeuImovel.Controller;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarqueSeuImovel.Model
{
    internal class PropertyDAO
    {
        private Connection Connect { get; set; }
        private SqlCommand Command { get; set; }
        //Sempre o nome da classe
        public PropertyDAO() 
        {
            Connect = new Connection();
            Command = new SqlCommand();
        }
        public void Insert(Property prop)
        {
            Command.Connection = Connect.ReturnConnection();
            Command.CommandText = @"INSERT INTO Property VALUES 
            (@objective, @city, @price)";

            Command.Parameters.AddWithValue("@objective", prop.Objective);
            Command.Parameters.AddWithValue("@city", prop.City);
            Command.Parameters.AddWithValue("@price", prop.Price);
            

            try
            {
                //Executa query definida acima.
                Command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao inserir " +
                    "imóvel no banco.\n" + err.Message);
            }
            finally
            {
                Connect.CloseConnection();
            }
        }
    }
}
