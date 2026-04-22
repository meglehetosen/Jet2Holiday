namespace BookingSupportClient.Data;

public static class DatabaseSettings
{
    public const string DatabaseName = "BookingSupport";
    public const string DatabaseFileName = "BookingSupport.mdf";

    public static string DatabaseDirectory =>
        Path.Combine(AppContext.BaseDirectory, "Database");

    public static string DatabaseFilePath =>
        Path.Combine(DatabaseDirectory, DatabaseFileName);

    public static string MasterConnectionString =>
        @"Server=(localdb)\MSSQLLocalDB;Integrated Security=true;Initial Catalog=master;TrustServerCertificate=True;";

    public static string AppConnectionString =>
        $@"Server=(localdb)\MSSQLLocalDB;Integrated Security=true;AttachDbFilename={DatabaseFilePath};Initial Catalog={DatabaseName};TrustServerCertificate=True;MultipleActiveResultSets=True;";
}
