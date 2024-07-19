using Microsoft.Extensions.Configuration;
using adodb;
using enums;
//using ConsoleTables;

internal class Program
{
    static string connStr = string.Empty;
    
    private static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("-= Подсистема KLADR =-");
        var config = new ConfigurationBuilder()
                         .AddJsonFile("appsettings.json")
                         .SetBasePath(Directory.GetCurrentDirectory())
                         .Build();
        connStr = config.GetConnectionString("DefaultConnection");          
        testAdo();
    }

    static void testOneTable(TargetTable targetTable)
    {
        switch (targetTable)
        {
            case TargetTable.SocrBase:
                {
                    SocrBaseReader dbr = new SocrBaseReader(connStr);
                    dbr.SaveJsonData();
                    dbr.SaveJsonSchema();
                    List<SocrBaseRecord> dg = dbr.GetGenericData();
                    //Console.WriteLine(dg.Count);
                    break;
                }
            case TargetTable.AltNames:
                {
                    AltNamesReader dbr = new AltNamesReader(connStr);
                    dbr.SaveJsonData();
                    dbr.SaveJsonSchema();
                    break;
                }
            case TargetTable.Kladr:
                {
                    KladrReader dbr = new KladrReader(connStr);
                    dbr.SaveJsonData();
                    dbr.SaveJsonSchema();
                    break;
                }
            case TargetTable.Streets:
                {
                    StreetReader dbr = new StreetReader(connStr);
                    dbr.SaveJsonData();
                    dbr.SaveJsonSchema();
                    break;
                }
            case TargetTable.Doma:
                {
                    DomaReader dbr = new DomaReader(connStr);
                    dbr.SaveJsonData();
                    dbr.SaveJsonSchema();
                    break;
                }
            case TargetTable.KladrActual:
                {
                    KladrActualReader dbr = new KladrActualReader(connStr);
                    dbr.SaveJsonData();
                    dbr.SaveJsonSchema();
                    break;
                }
            case TargetTable.StreetActual:
                {
                    StreetActualReader dbr = new StreetActualReader(connStr);
                    dbr.SaveJsonData();
                    dbr.SaveJsonSchema();
                    break;
                }
                //default:{
                //    throw;
                //}
        }
    }

    static void testAdo()
    {
        testOneTable(TargetTable.SocrBase);
        Console.WriteLine("===== ===== =====");
        testOneTable(TargetTable.AltNames);
        Console.WriteLine("===== ===== =====");
        testOneTable(TargetTable.Kladr);
        Console.WriteLine("===== ===== =====");
        testOneTable(TargetTable.Streets);
        Console.WriteLine("===== ===== =====");
        testOneTable(TargetTable.Doma);

        testOneTable(TargetTable.KladrActual);
        Console.WriteLine("===== ===== =====");
        testOneTable(TargetTable.StreetActual);
        Console.WriteLine("===== ===== =====");
        //Proc p = new Proc(connStr);
        //p.LaunchProc();
    }
}
