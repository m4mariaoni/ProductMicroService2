using ProductMicroservice.Data.Interface;
using ProductMicroService.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using ProductMicroservice.Data.Repo;
using System.Diagnostics;
using ProductMicroservice.Data.Services;
using AutoMoq;
using Microsoft.Extensions.DependencyInjection;

namespace CategoryNUnit.Test
{
    [TestFixture]
    public class CategoryTest //: CategoryRepository
    {

        private ProductConfiguration configuration;
        private readonly IDatabaseConnnectionProvider _databaseConnnectionProvider;
        //[SetUp]
        //public void Init()
        //{
        //    configuration = TestHelper.GetApplicationConfiguration(TestContext.CurrentContext.TestDirectory);

        //    var services = new ServiceCollection();
        //    IServiceProvider provider = ServiceCollection.BuildServiceProvider();

        //    // Simple configuration object injection (no IOptions<T>)
        //    services.AddSingleton(configuration);


        //    // configure EF Core DbContext - using the configuration
        //    services.AddDbContext<KavaDocsContext>(builder =>
        //    {
        //        var connStr = configuration.ConnectionString;
        //        if (string.IsNullOrEmpty(connStr))
        //            connStr = "User ID =postgres;Password=password;Server=localhost;Database=ProductDB;Pooling=true;";

        //        builder.UseSqlServer(connStr, opt =>
        //        {
        //            opt.EnableRetryOnFailure();
        //            opt.CommandTimeout(15);
        //        });
        //    });

        //}
       
        //public CategoryTest(IDatabaseConnnectionProvider databaseConnnectionProvider) : base(databaseConnnectionProvider)
        //{
        //    //_databaseConnnectionProvider = new DefaultDatabaseConnectionProvider() databaseConnnectionProvider;
        //}

            //Arrange
            //public int DeleteCategory(int CategoryId)
            //{
            //    throw new NotImplementedException();
            //}

            //public IEnumerable<Category> GetCategory()
            //{
            //    throw new NotImplementedException();
            //}

            //public Category GetCategoryById(int CategoryId)
            //{
            //    throw new NotImplementedException();
            //}
            //private AutoMoq _mocker;

            //[SetUp]
            //public void Setup()
            //{
            //    _mocker = new AutoMoq();
            //}

        [SetUp]
        public void Init()
        {
            configuration = TestHelper.GetApplicationConfiguration(TestContext.CurrentContext.TestDirectory);
        }


        //[TestCase]
        //public int InsertCategory(Category category)
        //{
        //    //Arrange
        //    category.Name = "Belt";
        //    category.Description = "Leather";

        //    //Act
        //    CategoryRepository repository = new CategoryRepository(_databaseConnnectionProvider);
        //    int id = TestHelper.InsertCategory(category);

        //    Debug.Assert(id > 0);


        //    return id;
        //}

        //public int UpdateCategory(Category category)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
