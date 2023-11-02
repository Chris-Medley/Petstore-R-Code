using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetstoreRCode
    {
public class ProductLogicClass
{
    private List<ProductClass> _productsConst;
    private Dictionary<string, DogLeashClass> _dogLeashDictConst;
    private Dictionary<string, CatFoodClass> _catFoodDictConst;

        public ProductLogicClass()
        {
            _productsConst = new List<ProductClass>();
            _dogLeashDictConst = new Dictionary<string, DogLeashClass>();
            _catFoodDictConst = new Dictionary<string, CatFoodClass>();
        }

        public void AddProducts(ProductClass product)
    {
        if (product is DogLeashClass)
        {
            _dogLeashDictConst.Add(product.Name, product as DogLeashClass);
        }
        if (product is CatFoodClass)
        {
            _catFoodDictConst.Add(product.Name, product as CatFoodClass);
        }
        _productsConst.Add(product);
    }

    public List<ProductClass> GetAllProducts()
    {
        return _productsConst;
    }

    public DogLeashClass GetDogLeashByName(string dogLeashName)
    {
        return _dogLeashDictConst[dogLeashName];
    }

    public CatFoodClass GetCatFoodByName(string catFoodName)
    {
        return _catFoodDictConst[catFoodName];
    }

    public int GetProductCount()
    {
        return _productsConst.Count;
    }
}
}