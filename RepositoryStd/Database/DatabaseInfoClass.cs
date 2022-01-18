 namespace RepositoryStd.Database
{
    public class DatabaseInfoClass
    {
        private static WhereAreYou whereAreYou = WhereAreYou.work;
        private static DatabaseLocation databaseLocation = DatabaseLocation.local;

        public static string DefaultConnectionString()
        {
            switch (databaseLocation)
            {
                case DatabaseLocation.local:
                    return "Data Source= .\\;Initial Catalog=StockDb;Persist Security Info=True;User ID=ayoobfar_ali;Password=119801;MultipleActiveResultSets=true";
                case DatabaseLocation.server:
                    return "Data Source = www.elecontrol.ir\\MSSQLSERVER2019; Initial Catalog = elecont1_data; Persist Security Info = True; User ID = elecont1_nejati; Password = Ali11980*; MultipleActiveResultSets = true";
            }
            return "plesk3.tegrahost.com,2019";
        }

        public static string CsvFilesPath()
        {
            switch (whereAreYou)
            {
                case WhereAreYou.work:
                    return @"E:\Ali\Projects\Website\WebAliNejati\Last\StockMarket\RepositoryStd\FileSystem\CSVFiles\";//work
                case WhereAreYou.desktop:
                    return @"C:\Users\test\Source\Repos\StockMarket\RepositoryStd\FileSystem\CSVFiles\";//desktop
                case WhereAreYou.laptop:
                    return @"C:\Users\ali\Source\Repos\ali61n60\StockMarket\RepositoryStd\FileSystem\CSVFiles\";//laptop
            }            
            return @"C:\Users\test\Documents\TseClient 2.0\";
        }
    }

    public enum WhereAreYou
    {
        work,
        laptop,
        desktop
    }

    public enum DatabaseLocation
    {
        local,
        server
    }
}
