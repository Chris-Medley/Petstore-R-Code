using PetstoreRCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetstoreRCode
{
    internal interface IProductLogic
    {
        public void AddProducts(ProductClass product);
        public List<ProductClass> GetAllProducts();
        public DogLeashClass GetDogLeashByName(string dogLeashName);
        public CatFoodClass GetCatFoodByName(string catFoodName);
        public int GetProductCount();
        public List<string> GetProductNames();
        public List<string> GetCatProductNames();
        public List<string> GetDogProductNames();
        public List<string> GetOnlyInStockProducts();

    }

}
