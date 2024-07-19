using System.Data;
using Microsoft.Data.SqlClient;
using Newtonsoft.Json;

namespace adodb;

// public class DomaRecord
// {
//     public string Code { get; set; }
//     public string? Name { get; set; }
//     public string? Korp { get; set; }
//     public string? Socr { get; set; }
//     public string? Index { get; set; }
//     public string? Gninmb { get; set; }
//     public string? Uno { get; set; }
//     public string? Ocatd { get; set; }
// }

public class DomaReader: KladrCommon
{
    public DomaReader(string connectionString): base(connectionString)
    {
        this.sql = SQLs.domaSql;
        this.filenameSubstring = "doma";
    }
}
