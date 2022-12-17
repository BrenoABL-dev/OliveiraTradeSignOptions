using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OliveiraTrade.SQLRequests
{
    internal class SignInCommand : SqlExceptionMessage
    {

        #region Variables and references
        
        DataConnection  databaseCon = new DataConnection();
        SqlCommand      sqlCmd =      new SqlCommand();
        SqlDataReader   dataReader;

        private bool    accExists = false;
        public bool     AccExists {         get { return accExists; }
                                    private set { accExists = value;}}

        #endregion



        public bool DatabaseSigninVerifRequest(String userID, String password)
{
            sqlCmd.CommandText = "SELECT * FROM USERSTABLE WHERE userID = @userID AND password = @password";
            sqlCmd.Parameters.AddWithValue("@userID", userID);
            sqlCmd.Parameters.AddWithValue("@password", password);

            try{
                sqlCmd.Connection = databaseCon.Connect();
                dataReader =        sqlCmd.ExecuteReader();

                if (dataReader.HasRows)
                {
                    AccExists = true;
                }

                databaseCon.Desconnect();
                dataReader.Close();
            }

            catch (SqlException)
            {
                this.Message = "Houve um erro no banco de dados";
            }

            return AccExists;
        }
    }
}
