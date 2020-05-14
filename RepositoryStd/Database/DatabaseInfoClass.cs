 namespace RepositoryStd.Database
{
    public class DatabaseInfoClass
    {
        public string ConnectionString { get;}

        public DatabaseInfoClass(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public static string DefaultConnectionString()
        {
            //return "Data Source = www.whereismycar.ir\\MSSQLSERVER2012; Initial Catalog = whereism_database; Persist Security Info = True; User ID = whereism_ali; Password = Lam8u38@; MultipleActiveResultSets = true";
            return "Data Source= .\\;Initial Catalog=StockDb;Persist Security Info=True;User ID=ayoobfar_ali;Password=119801;MultipleActiveResultSets=true";
        }
    }
}
