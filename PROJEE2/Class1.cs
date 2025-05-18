using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJEE2
{
    public class SQLBağlantim
    {
        public SqlConnection baglanti()
        {
            return new SqlConnection(@"Data Source=DESKTOP-5KQACGN\SQLEXPRESS;Initial Catalog=kitapokuma;Integrated Security=True");
        }
    }
}
