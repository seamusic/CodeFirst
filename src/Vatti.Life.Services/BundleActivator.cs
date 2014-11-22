using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Lennon.Core.Data.Entity;
using Lennon.Core.Data.Entity.Migrations;
using Vatti.Life.Contracts.Dtos;
using Vatti.Life.Contracts.Models;

namespace Vatti.Life.Services
{
    public class BundleActivator
    {
        #region Implementation of IBundleActivator

        public void Start()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            DatabaseInitializer.AddMapperAssembly(assembly);

            SeedDataInitialize();
            MapperCreate();
        }

        //public void Stop(IBundleContext context)
        //{ }

        #endregion

        private static void SeedDataInitialize()
        {
            ISeedAction seedAction = new SeedAction();
            CreateDatabaseIfNotExistsWithSeed.SeedActions.Add(seedAction);
        }

        private static void MapperCreate()
        {
            Mapper.CreateMap<DemoEntityDto, DemoEntity>();
        }
    }
}
