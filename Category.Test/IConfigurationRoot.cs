using ProductMicroService.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CategoryNUnit.Test
{
    public interface IConfigurationRoot
    {
        IConfigurationRoot GetIConfigurationRoot(string outputPath);
        int InsertCategory(Category category);

    }
}
