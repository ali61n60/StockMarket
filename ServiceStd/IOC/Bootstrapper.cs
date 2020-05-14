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
                x.For<ISymbolInfo>().Use<DatabaseStockInfo>();
                x.For<IDataLoader>().Use<DataLoaderDatabase>();
                //x.ForConcreteType<Repository.Repository>().Configure.Singleton();
                //x.For<IAdApi>().Use<AdApi>();
               // x.For<ISharedPreferences>().Use(PreferenceManager.GetDefaultSharedPreferences(Application.Context));
                //x.For<IRepository>().Use<Repository>();
                //x.For<ISimpleModel>().Use<SimpleModel>().Ctor<int>().Is(250);
                //string directoryPath = HttpContext.Current.Server.MapPath("~/AdvertisementImages/");
                //x.For<IImageRepository>().Use<ImageRepositoryFileSystem>().Ctor<string>().Is(directoryPath);

            });
        }
    }
}
