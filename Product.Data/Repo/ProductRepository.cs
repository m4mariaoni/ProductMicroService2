using Dapper;
using ProductMicroservice.Data.Interface;
using ProductMicroservice.Data.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace ProductMicroservice.Data.Repo
{
    public class ProductRepository : IProductRepository
    {
        private readonly IDatabaseConnnectionProvider _databaseConnnectionProvider;
        public ProductRepository(IDatabaseConnnectionProvider databaseConnnectionProvider)
        {
            _databaseConnnectionProvider = databaseConnnectionProvider;
        }
       
        public int DeleteProduct(int ProductId)
        {
            using (var connection = _databaseConnnectionProvider.GetDbConnection())
            {
                try
                {
                    var sql = "DELETE from product where id = @ProductId";
                    int ans = connection.Execute(sql, new { ProductId });
                    if (ans <= 0)
                    {
                        return 0;
                    }
                    return ans;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public Products GetProductById(int ProductId)
        {
            var product = new Products();
            using (var connection = _databaseConnnectionProvider.GetDbConnection())
            {
                try
                {
                    product = connection.QuerySingle<Products>("Select * from product where id = @ProductId", new { ProductId });
                }
                catch (Exception)
                {
                    throw;
                }

            }
            return product;
        }

        public IEnumerable<Products> GetProducts()
        {
            IEnumerable<Products> allProducts = null;
            using (var connection = _databaseConnnectionProvider.GetDbConnection())
            {
                allProducts = connection.Query<Products>("Select * from product");
            }

            return allProducts;
        }

        public int InsertProduct(Products products)
        {
            using (var connection = _databaseConnnectionProvider.GetDbConnection())
            {
                var sql = @"INSERT INTO product(name,description,categoryid,price) VALUES(@name, @description,@categoryid,@price)";
                var id = connection.Execute(sql, products);

                if (id <= 0)
                {
                    return 0;
                }
                return id;

            }


        }
        


        public int UpdateProduct(Products Product)
        {
            using (var connection = _databaseConnnectionProvider.GetDbConnection())
            {
                try
                {
                    var existingRecord = GetProductById(Product.Id);
                    if (existingRecord == null)
                    {
                        return 0;
                    }
                    string updateQuery = @"UPDATE product SET name=@name,description=@description,price=@price,categoryid=@categoryid WHERE id=@id";
                    int id = connection.Execute(updateQuery, Product);
                    if (id <= 0)
                    {
                        return 0;
                    }
                    return id;

                }
                catch (Exception)
                {
                    throw;
                }


            }
        }
    }

    }
