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
            //return "Data Source= .\\;Initial Catalog=StockDb;Persist Security Info=True;User ID=ayoobfar_ali;Password=119801;MultipleActiveResultSets=true";
            return "Data Source = www.elecontrol.ir\\MSSQLSERVER2019; Initial Catalog = elecont1_data; Persist Security Info = True; User ID = elecont1_nejati; Password = Ali11980*; MultipleActiveResultSets = true";
            //plesk3.tegrahost.com,2019
        }
    }
}
