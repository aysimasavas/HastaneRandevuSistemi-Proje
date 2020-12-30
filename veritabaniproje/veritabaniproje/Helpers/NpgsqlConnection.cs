namespace veritabaniproje.Helpers
{
    public class NpgsqlConnection
    {
        private string urlDB;

        public NpgsqlConnection(string urlDB)
        {
            this.urlDB = urlDB;
        }
    }
}