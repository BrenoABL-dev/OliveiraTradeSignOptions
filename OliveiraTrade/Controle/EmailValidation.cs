using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace OliveiraTrade.Controle
{
    public class EmailValidation
    {

        private bool isValid = false;
        
        Regex validation = new Regex("^[A-Za-z0-9](([_.-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([.-]?[a-zA-Z0-9]+)*)([.][A-Za-z]{2,4})$");



        public bool ValidateEmail(String _email)
        {
            if (validation.IsMatch(_email))
            {
                isValid = true;
            }

            return isValid;
        }
    }
}
