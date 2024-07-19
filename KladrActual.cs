using System.Data;
using Microsoft.Data.SqlClient;
using Newtonsoft.Json;

namespace adodb;

public class KladrActualReader: KladrCommon
{
    public KladrActualReader(string connectionString): base (connectionString)
    {
        this.sql = SQLs.kladrActualSql;
        this.filenameSubstring = "kladr_actual";
    }
}
