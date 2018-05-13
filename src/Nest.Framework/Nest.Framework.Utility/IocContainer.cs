using Autofac;
//using Autofac.Configuration;
//using Microsoft.Extensions.Configuration;
//using System;
//using System.IO;
using System.Reflection;

namespace Nest.Framework.Utility
{
    public class IocContainer
    {
        private static IContainer _IContainer = null;

        /// <summary>
        /// 注册
        /// </summary>
        //public static void Register()
        //{
        //    //将配置添加到ConfigurationBuilder
        //    var config = new ConfigurationBuilder();
        //    config.AddJsonFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "AutofacConfig.json"));

        //    //用Autofac注册ConfigurationModule
        //    var module = new ConfigurationModule(config.Build());
        //    var builder = new ContainerBuilder();
        //    builder.RegisterModule(module);
        //    _IContainer = builder.Build();
        //}

        /// <summary>
        /// 注册
        /// </summary>
        public static void Register()
        {
            var builder = new ContainerBuilder();
            var IService = Assembly.Load("Nest.Framework.SqlSugarDao");
            var Service = Assembly.Load("Nest.Framework.SqlSugarDao");
            var IRepository = Assembly.Load("TestDal");
            var Repository = Assembly.Load("TestDal");

            //根据名称约定（服务层的接口和实现均以DataAccess结尾），实现服务接口和服务实现的依赖
            builder.RegisterAssemblyTypes(IService, Service)
              .Where(t => t.Name.EndsWith("DataAccess"))
              .AsImplementedInterfaces();

            //根据名称约定（数据访问层的接口和实现均以Repository结尾），实现数据访问接口和数据访问实现的依赖
            builder.RegisterAssemblyTypes(IRepository, Repository)
              .Where(t => t.Name.EndsWith("Repository"))
              .AsImplementedInterfaces();

            _IContainer = builder.Build();
        }

        public static T Resolve<T>()
        {
            return _IContainer.Resolve<T>();
        }
    }
}
