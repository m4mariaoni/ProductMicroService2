using System;
using System.Collections.Generic;
using System.Text;
using ProductMicroservice.Data.Models;

namespace ProductMicroservice.Data.Interface
{
    public interface IProductRepository
    {
        IEnumerable<Products> GetProducts();
        Products GetProductById(int ProductId);
        int InsertProduct(Products Product);
        int DeleteProduct(int ProductId);
        int UpdateProduct(Products Product);

    }
}
