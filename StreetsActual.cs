using System.Data;
using Microsoft.Data.SqlClient;
using Newtonsoft.Json;

namespace adodb;

public class StreetActualReader: KladrCommon
{
    public StreetActualReader(string connectionString): base(connectionString)
    {
        this.sql = SQLs.streetsActualSql;
        this.filenameSubstring = "street_actual";
    }
}
