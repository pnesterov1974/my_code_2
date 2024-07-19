using Microsoft.Data.SqlClient;
using Newtonsoft.Json;

namespace adodb;

public class CommonReader
{
    public CommonReader(string connectionString)
    {
        this.connectionString = connectionString;
    }

    private string connectionString = String.Empty;

    private void Connection_StateChange(object sender, System.Data.StateChangeEventArgs e)
    {
        SqlConnection conn = sender as SqlConnection;
        Console.Write("Изменено состояние подключения...\t");
        Console.Write("Database: " + conn.Database + "\tState: " + conn.State);
        Console.WriteLine();
    }

    public string GetJsonData()
    {
        //this.ReadData();
        //return JsonConvert.SerializeObject(this.Data, Formatting.Indented);
        return "";
    }
}
