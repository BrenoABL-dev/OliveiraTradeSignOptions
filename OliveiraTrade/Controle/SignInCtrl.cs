using OliveiraTrade.SQLRequests;
using OliveiraTrade.UserInputExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OliveiraTrade.Controle
{
    public class SignInCtrl
    {
        //valid if hasAccout = true and sqlErrorTxt = ""

        public bool hasAccount = false;
        public String sqlErrorTxt = "";
        

        public bool TryLogin(String username, String password)
        {
            if      (username.Length > 50)  {throw new UserIdLenghExceededExeption();}
            else if (password.Length > 50)  {throw new PasswLenghExceededExeption();}

            else{
                SignInCommand serverSignin = new SignInCommand();

                hasAccount = serverSignin.DatabaseSigninVerifRequest(username, password);

                if (!serverSignin.Message.Equals("")){
                    this.sqlErrorTxt = serverSignin.Message;
                }


                return hasAccount;
            }
        }
    }
}
