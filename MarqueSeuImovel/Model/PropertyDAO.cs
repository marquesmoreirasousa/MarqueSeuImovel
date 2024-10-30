using MarqueSeuImovel.Controller;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
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
        public PropertyDAO() //método construtor
        {
            Connect = new Connection();
            Command = new SqlCommand();
        }
        public void Insert(Property prop)
        {
            Command.Connection = Connect.ReturnConnection();
            Command.CommandText = 
            @"INSERT INTO 
            Property VALUES 
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
        

        public void Update(Property prop)
        {
            Command.Connection = Connect.ReturnConnection();
            Command.CommandText = @"UPDATE Property SET 
            Objective = @objective,
            City = @city,
            Price = @price
            WHERE CodProperty = @code";

            Command.Parameters.AddWithValue("@objective", prop.Objective);
            Command.Parameters.AddWithValue("@city", prop.City);
            Command.Parameters.AddWithValue("@price", prop.Price);
            Command.Parameters.AddWithValue("@code", prop.CodProperty);

            try
            {
                Command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: " +
                    "Problemas ao realizar atualização de " +
                    "imóvel no banco.\n" + err.Message);
            }
            finally
            {
                Connect.CloseConnection();
            }
        }

        public void Delete(int codProperty)
        {
            Command.Connection = Connect.ReturnConnection();
            Command.CommandText = @"DELETE FROM Property 
            WHERE CodProperty = @code";
            Command.Parameters.AddWithValue("@code", codProperty);
            try
            {
                Command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao excluir " +
                    "imóvel no banco.\n" + err.Message);
            }
            finally
            {
                Connect.CloseConnection();
            }
        }
        public List<Property> ListAllProperties()
        {

            Command.Connection = Connect.ReturnConnection();
            Command.CommandText = "SELECT * FROM Property";

            List<Property>  props = new List<Property>(); //Instancio a list com o tamanho padrão.
            try
            {
                SqlDataReader rd = Command.ExecuteReader();

                //Enquanto for possível continuar a leitura das linhas que foram retornadas na consulta, execute.
                while (rd.Read())
                {
                    Property prop = new Property(
                        (int)rd["CodProperty"],
                        (string)rd["Objective"], 
                        (string)rd["City"], 
                        (float)rd["Price"]
                        );
                    props.Add(prop);
                }
                rd.Close();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao realizar " +
                    "leitura de imóveis no banco.\n" + err.Message);
            }
            finally
            {
                Connect.CloseConnection();
            }

            return props;
        }
    }
}
