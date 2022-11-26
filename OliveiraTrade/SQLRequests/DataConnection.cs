using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OliveiraTrade.SQLRequests
{
    public class DataConnection
    {

        SqlConnection DatabaseCon = new SqlConnection();


        
        public  DataConnection() 
        {
           DatabaseCon.ConnectionString = @"Data Source=oliveiratradetestdb.c0hl6p5idp3o.sa-east-1.rds.amazonaws.com,1433;Initial Catalog=OTradeUsers;Integrated Security=False;Persist Security Info=True;User ID=admin;Password=jpXNLvUanST8Ywj";
        }
        //this database for test only and will be deleted at 01/01/2023


        #region Methods
        public SqlConnection Connect() 
        {
            if (DatabaseCon.State == System.Data.ConnectionState.Closed)
            {
                DatabaseCon.Open();
            }

            return DatabaseCon;
        }


        public void Desconnect()
        {
            DatabaseCon.Close();
        }

        #endregion

    
    }
}
