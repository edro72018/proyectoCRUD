// Form1.cs
namespace crudApi
{
    internal class MySqlConnection
    {
        private object connectionString;

        public MySqlConnection(object connectionString)
        {
            this.connectionString = connectionString;
        }
    }
}