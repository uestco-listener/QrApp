namespace QrApp.Resources
{
    public static class PostgreSql
    {
        public static string databaseName = "uestco_qr_users_db";
#if DEBUG
        public static string connString = $"Server=127.0.0.1;Port=5432;Database=uestco_qr_users_db;User Id=postgres;Password=vs2p7qfM4R2T;";
#else
        public static string connString = $"Server=127.0.0.1;Port=5432;Database=uestco_qr_users_db;User Id=postgres;Password=12345;";
#endif
    }
}
