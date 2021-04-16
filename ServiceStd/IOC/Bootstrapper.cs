using ModelStd.IRepository;
using RepositoryStd.Database;
using RepositoryStd.FileSystem;
using StructureMap;


namespace ServiceStd.IOC
{
    public static class Bootstrapper
    {
        public static Container container;
        
        static Bootstrapper()
        {
            container = new Container(x =>
            {
                configureForDatabase(x);
                //configureForFileSystem(x);



                //x.ForConcreteType<Repository.Repository>().Configure.Singleton();
                //x.For<IAdApi>().Use<AdApi>();
                // x.For<ISharedPreferences>().Use(PreferenceManager.GetDefaultSharedPreferences(Application.Context));
                //x.For<IRepository>().Use<Repository>();
                //x.For<ISimpleModel>().Use<SimpleModel>().Ctor<int>().Is(250);
                //string directoryPath = HttpContext.Current.Server.MapPath("~/AdvertisementImages/");
                //x.For<IImageRepository>().Use<ImageRepositoryFileSystem>().Ctor<string>().Is(directoryPath);

            });
        }

        private static void configureForDatabase(ConfigurationExpression x)
        {
            x.For<ISymbolInfo>().Use<DatabaseSymbolInfo>();
            x.For<IDataLoader>().Use<DataLoaderDatabase>();
        }

        private static void configureForFileSystem(ConfigurationExpression x)
        {
            x.For<ISymbolInfo>().Use<HandWrittenSymbolInfo>();
        }        
    }
}
