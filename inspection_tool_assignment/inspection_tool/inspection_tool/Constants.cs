using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inspection_tool
{
    class Constants
    {
        // Queries
        public static string SELECTALLUser = "SELECT * FROM User";
        public static string INSERTUser = "INSERT INTO Inspector (username, email, password) VALUES (@username, @email, @password)";
    }
}
