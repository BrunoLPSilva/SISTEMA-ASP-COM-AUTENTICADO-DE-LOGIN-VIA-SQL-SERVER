using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SistemaPIM.Models
{
    public class ClientModel
    {
        public float Saldo { get; set; }
        public string Email { get; set; }

    }
    public class UsuarioModel
    {
        SqlConnection sqlCon = null;
        public string strcon = @"Data Source=DESKTOP-LBK3281\SQLEXPRESS;Initial Catalog=bdpim;User Id=DESKTOP-LBK3281\SQLEXPRESS;Password=";
        public static bool ValidarUsuario(string login, string senha)
        {
            var ret = false;



            using (var conexao = new SqlConnection())
            {
                conexao.ConnectionString = @"Data Source=DESKTOP-LBK3281\SQLEXPRESS;Initial Catalog=bdpim;User Id=DESKTOP-LBK3281\SQLEXPRESS;Password=";
                
                conexao.Open();

                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexao;
                    comando.CommandText = string.Format(
                        "select count(*) from cliente where emailClient = '{0}' and pClient = '{1}'", login, senha);
                    ret = ((int)comando.ExecuteScalar() > 0);


                   
                    
                }

            }
            return ret;
        }

        public List<ClientModel> ConsultaSaldo(string login)
        {
            try
            {
                
                string query = "select * from cliente where emailClient =  @email";

                ClientModel dataUser = new ClientModel();
                var result = new List<ClientModel>();

                sqlCon = new SqlConnection(strcon);
                SqlCommand comando = new SqlCommand(query, sqlCon);
                sqlCon.Open();

                
               
                    //Create Command
                    SqlCommand cmd = new SqlCommand(query);
                    //Create a data reader and Execute the command
                    SqlDataReader dataReader = cmd.ExecuteReader();

                    while (dataReader.Read())
                    {
                        result.Add(new ClientModel()
                        {
                            Saldo = Convert.ToInt32(dataReader.GetString(dataReader.GetOrdinal("iduserregister"))),
                            Email = (dataReader.GetString(dataReader.GetOrdinal("createdate"))),
                            
                        });
                    }

                    //close Data Reader
                    dataReader.Close();

                //close Connection
                sqlCon.Close();
               

                //return list to be displayed
                return result;
                
                

            }
            catch (Exception )
            {
           
                throw;
            }
        }



    }
}