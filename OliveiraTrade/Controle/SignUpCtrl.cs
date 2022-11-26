using OliveiraTrade.SQLRequests;
using OliveiraTrade.UserInputExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OliveiraTrade.Controle
{
    internal class SignUpCtrl
    {
        public bool hasBeenRegistered = false;
        public String sqlText = "";


        public String RegisterToSQL(String username, String password, String confirmPassword, long CPF, String email)
        {
            EmailValidation emailValid = new EmailValidation();

            if      (username.Length > 20)              { throw new UserIdLenghExceededExeption(); }
            else if (password.Length > 20)              { throw new PasswLenghExceededExeption(); } 
            else if (password != confirmPassword)       { throw new PassWNotConfirmedExeption(); }
            else if (CPF < 0 || CPF > 99999999999)      { throw new InvalidCPFExeption(); }
            else if (!emailValid.ValidateEmail(email))  { throw new InvalidEmailExeption(); }

            else
            {
                SignUpCommand serverSignUp = new SignUpCommand();

                this.sqlText = serverSignUp.DatabaseSignUpRequest(username, password, CPF, email);
                if (serverSignUp.accCreated == true)
                {
                    hasBeenRegistered = true;
                }
            }

            return sqlText;
        }




    }
}
