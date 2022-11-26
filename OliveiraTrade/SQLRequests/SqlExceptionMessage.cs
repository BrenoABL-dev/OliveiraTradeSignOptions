using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OliveiraTrade.SQLRequests
{
    internal class SqlExceptionMessage
    {
        private String message = "";
        public String Message {           get { return message;}
                                 internal set { message = value;} }

    }
}
