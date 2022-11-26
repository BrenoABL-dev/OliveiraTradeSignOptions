using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OliveiraTrade.SQLRequests
{
    internal class SignUpCommand : SqlExceptionMessage
    {
        DataConnection  databaseCon = new DataConnection();
        SqlCommand      sqlCmd      = new SqlCommand();
        public bool     accCreated = false;

        public String DatabaseSignUpRequest(String usuario, String password, long cpf, String email)
        {

            sqlCmd.CommandText = "INSERT INTO USERSTABLE VALUES (@USERID, @PASSWORD, @CPF, @EMAIL);";
            sqlCmd.Parameters.AddWithValue("@USERID", usuario);
            sqlCmd.Parameters.AddWithValue("@PASSWORD", password);
            sqlCmd.Parameters.AddWithValue("@cpf", cpf);
            sqlCmd.Parameters.AddWithValue("@email", email);


            try
            {
                sqlCmd.Connection = databaseCon.Connect();
                sqlCmd.ExecuteNonQuery();
                databaseCon.Desconnect();
                
                //if it didn't catch anything
                accCreated = true;
                this.Message = "Você foi registrado com sucesso.";
            }
            catch (SqlException)
            {

                this.Message = "Houve um Erro no Banco de Dados";
            }

            return Message;
        }

    }
}
