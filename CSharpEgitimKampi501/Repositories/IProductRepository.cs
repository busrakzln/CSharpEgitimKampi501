using CSharpEgitimKampi501.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi501.Repositories
{
    public interface IProductRepository
    {
        //asenkron (async):C# ta bir uygulamanın uzun süren işlemleri(örneğin, dosya okuma,web istekleri
        //veri tabanı işlemleri) beklerken uygulamanın yanıt vermeye devam etmesini sağlar.
        //yani bir işlem yapılırken başka bir işlemin de yapılmasını sağlar
        Task<List<ResultProductDto>> GetAllProductAsync();
        Task CreateProductAsync(CreateProductDto createProductDto);
        Task UpdateProductAsync(UpdateProductDto updateProductDto);
        Task DeleteProductAsync(int id);
        Task GetByProductIdAsync(int id);
    }
}
