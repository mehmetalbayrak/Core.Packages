using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCuttingConcerns.Serilog.ConfigurationModels;

public class MsSqlConfiguration
{
    public string ConnectionString { get; set; }
    public string Table { get; set; }
    public bool AutoCreateSqlTable { get; set; }
    public MsSqlConfiguration()
    {
        ConnectionString = string.Empty;
        Table = string.Empty;
    }
    public MsSqlConfiguration(string connectionString, string table, bool autoCreateSqlTable)
    {
        ConnectionString = connectionString;
        Table = table;
        AutoCreateSqlTable = autoCreateSqlTable;
    }
}
