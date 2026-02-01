using MySql.Data.MySqlClient;

namespace PENJUALAN_TOKO
{
    public static partial class KoneksiDB
    {
        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(
                "server=localhost;database=db_toko;uid=root;pwd=;");
        }
    }
}
