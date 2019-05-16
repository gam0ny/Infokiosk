namespace DatabaseLayer.Repositories
{
    public class BaseRepository
    {
        public DatabaseManager DbManager { get; set; }

        public BaseRepository()
        {
            DbManager = new DatabaseManager();
        }
    }
}
