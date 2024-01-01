namespace DAL.Repos
{
    internal class Repo
    {
        internal OneGoContext db;
        internal Repo()
        {
            db = new OneGoContext();
        }
    }
}