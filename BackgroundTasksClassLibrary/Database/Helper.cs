namespace Ga.Personal.BackgroundTasks.ClassLibrary.Database
{
    internal class Helper
    {
        private static readonly string _connectionString;

        internal static string ConnectionString { get => _connectionString; }

        internal static bool CheckConnection()
        {
            return true;
        }
    }
}
