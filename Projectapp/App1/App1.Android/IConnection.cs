using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    interface IConnection
    {
        void InsertIntoDB();
        void OpenConnection();
        void CloseConnection();
        void dbCommand(string sqlQuery);
    }
}
