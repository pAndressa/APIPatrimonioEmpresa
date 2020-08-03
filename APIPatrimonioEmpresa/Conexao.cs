using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace APIPatrimonioEmpresa
{
    public class Conexao
    {
        private string StringConexao()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "ANDRESSA\\SQLEXPRESS";
            builder.IntegratedSecurity = true;            
            builder.InitialCatalog = "Patrimonio_Empresa";

            return builder.ConnectionString;
        }
        public DataTable Consulta(string query)
        {
            try
            {
                using (SqlConnection connection =  new SqlConnection(StringConexao()))
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = new SqlCommand(query, connection);

                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    return dataTable;
                }
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void Executar(string query)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(StringConexao()))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
