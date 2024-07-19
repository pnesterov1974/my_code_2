using System.Data;
using Microsoft.Data.SqlClient;
using Newtonsoft.Json;

namespace adodb;

// public class StreetRecord
// {
//     public string Code { get; set; }
//     public string? Name { get; set; }
//     public string? Socr { get; set; }
//     public string? Index { get; set; }
//     public string? Gninmb { get; set; }
//     public string? Uno { get; set; }
//     public string? Ocatd { get; set; }
// }

public class StreetReader: KladrCommon
{
    public StreetReader(string connectionString): base(connectionString)
    {
        this.sql = SQLs.streetSql;
        this.filenameSubstring = "street";
    }
}
