using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    interface IConnection
    {
        void DbConnection();
        void Initialize();
        void OpenConnection();
        void CloseConnection();
        
    }
}
