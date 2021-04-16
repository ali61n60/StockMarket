using ModelStd.Carts;
using ModelStd.IRepository;
using RepositoryStd.Database;
using RepositoryStd.FileSystem;
using StructureMap;
using System;

namespace ServiceStd.IOC
{
    public static class Bootstrapper
    {
        public static Container container;
        public static ConfigurationExpression cx;

        static Bootstrapper()
        {
            container = new Container(x =>
            {
                cx = x;
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

        public static void configureMvCRelated(IServiceProvider services)
        {
            services.AddScoped<Cart>(sp => SessionCart.GetCart(sp));
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();


            cx.For<Cart>().UseInstance(SessionCart.GetCart(sp));




        }
    }
}
