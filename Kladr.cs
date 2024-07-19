using System.Data;
using Microsoft.Data.SqlClient;
using Newtonsoft.Json;

namespace adodb;

// public class KladrRecord
// {
//     public string Code { get; set; }
//     public string? Name { get; set; }
//     public string? Socr { get; set; }
//     public string? Index { get; set; }
//     public string? Gninmb { get; set; }
//     public string? Uno { get; set; }
//     public string? Ocatd { get; set; }
//     public short Status { get; set; }
// }

public class KladrReader: KladrCommon
{
    public KladrReader(string connectionString): base(connectionString)
    {
        this.sql = SQLs.kladrSql;
        this.filenameSubstring = "kladr";
    }
}
