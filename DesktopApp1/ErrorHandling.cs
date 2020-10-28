using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DesktopApp1
{
    class ErrorHandling
    {
        public string GetMessage(Exception e)
        {
            string message = "";
            if (e is SqlException)
            {
                message = e.Message;
            }
            else if (e is System.Data.Entity.Core.EntityCommandExecutionException || e is System.Data.Entity.Core.EntityException)
            {
                message = e.InnerException.Message;
            }
            else
            {
                message = "Something went wrong";
            }
            return message;
        }
    }
}
