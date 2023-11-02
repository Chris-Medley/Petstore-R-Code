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
    private List<string> _productsNameConst;
    private Dictionary<string, DogLeashClass> _dogLeashDictConst;
    private Dictionary<string, CatFoodClass> _catFoodDictConst;
    private List<string> _catFoodListNames;
    private List<string> _dogLeashListNames;

        public ProductLogicClass()
        {
            _productsConst = new List<ProductClass>();
            _productsNameConst = new List<string>();
            _dogLeashDictConst = new Dictionary<string, DogLeashClass>();
            _catFoodDictConst = new Dictionary<string, CatFoodClass>();
            _dogLeashListNames = new List<string>();
            _catFoodListNames = new List<string>();
        }

        public void AddProducts(ProductClass product)
    {
        if (product is DogLeashClass)
        {
            _dogLeashDictConst.Add(product.Name, product as DogLeashClass);
            _dogLeashListNames.Add(product.Name);
        }
        if (product is CatFoodClass)
        {
            _catFoodDictConst.Add(product.Name, product as CatFoodClass);
            _catFoodListNames.Add(product.Name);
        }
        _productsConst.Add(product);
        _productsNameConst.Add(product.Name);
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

    public List<string> GetProductNames()
        {
            return _productsNameConst;
        }

    public List<string> GetCatProductNames()
        {
            return _catFoodListNames;
        }

    public List<string> GetDogProductNames()
        {
            return _dogLeashListNames;
        }
    }
}