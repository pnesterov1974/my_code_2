using System.Data;
using Microsoft.Data.SqlClient;
using Newtonsoft.Json;

namespace adodb;

public class SocrBaseRecord
{
    public short Level { get; set; }
    public string Scname { get; set; }
    public string SocrName { get; set; }
    public string KodTSt { get; set; }
}

public class SocrBaseReader : KladrCommon
{
    public SocrBaseReader(string connectionString) : base(connectionString)
    {
        this.sql = SQLs.socrBaseSql;
        this.filenameSubstring = "socrbase";
    }

    public List<SocrBaseRecord> GetGenericData()
    {
        List<SocrBaseRecord> Data = new List<SocrBaseRecord>();
        foreach (DataRow row in this.TableData.Rows)
        {
            SocrBaseRecord sb = new SocrBaseRecord();
            sb.Level = (short)row[0];
            sb.Scname = (string)row[1];
            sb.SocrName = (string)row[2];
            sb.KodTSt = (string)row[3];
            Data.Add(sb);
        }
        return Data;
    }
}
