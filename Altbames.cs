using System.Data;
using Microsoft.Data.SqlClient;
using Newtonsoft.Json;

namespace adodb;

// public class AltNamesRecord
// {
//     public short Level { get; set; }
//     public string Oldcode { get; set; }
//     public string Newcode { get; set; }
// }

public class AltNamesReader: KladrCommon
{
    public AltNamesReader(string connectionString): base(connectionString)
    {
        this.sql = SQLs.altNamesSql;
        this.filenameSubstring = "altnames";
    }
}
