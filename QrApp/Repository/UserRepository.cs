using Npgsql;
using NPoco;
using QrApp.Concrete;
using QrApp.Resources;

namespace QrApp.Repository
{
    public class UserRepository
    {
        public void Delete(User user)
        {
            NpgsqlConnection conn = new NpgsqlConnection(PostgreSql.connString);
            using (IDatabase connection = new Database(conn, DatabaseType.PostgreSQL))
            {
                conn.Open();
                connection.Delete(user);
                conn.Close();
            }
        }

        public List<User> GetAllList()
        {
            NpgsqlConnection conn = new NpgsqlConnection(PostgreSql.connString);
            using (IDatabase connection = new Database(conn, DatabaseType.PostgreSQL))
            {
                conn.Open() ;
                var list = connection.Fetch<User>().ToList();
                conn.Close();
                return list;
            }
        }

        public User GetById(Guid id)
        {
            NpgsqlConnection conn = new NpgsqlConnection(PostgreSql.connString);
            using (IDatabase connection = new Database(conn, DatabaseType.PostgreSQL))
            {
                conn.Open();
                var val = connection.SingleOrDefaultById<User>(id);
                conn.Close();
                return val;
            }
        }

        public User GetById(long id)
        {
            NpgsqlConnection conn = new NpgsqlConnection( PostgreSql.connString);
            using (IDatabase connection = new Database(conn, DatabaseType.PostgreSQL))
            {
                conn.Open();
                var val = connection.SingleOrDefaultById<User>(id);
                conn.Close() ;
                return val;
            }
        }

        public User Insert(User user)
        {
            NpgsqlConnection conn = new NpgsqlConnection(PostgreSql.connString);
            using (IDatabase connection = new Database(conn, DatabaseType.PostgreSQL))
            {
                conn.Open();
                connection.Insert(user);
                conn.Close();
                return user;
            }
        }
    }
}
