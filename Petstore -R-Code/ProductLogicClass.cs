using System.Linq.Expressions;

namespace PetstoreRCode
{
    public class ProductLogicClass : IProductLogic
    {
        private List<ProductClass> _productsConst;
        private List<string> _productsNameConst;
        private Dictionary<string, DogLeashClass> _dogLeashDictConst;
        private Dictionary<string, CatFoodClass> _catFoodDictConst;
        private List<string> _catFoodListNames;
        private List<string> _dogLeashListNames;

        //add temporary constructors
        public ProductLogicClass()
        {
            _productsConst = new List<ProductClass>();
            _productsNameConst = new List<string>();
            _dogLeashDictConst = new Dictionary<string, DogLeashClass>();
            _catFoodDictConst = new Dictionary<string, CatFoodClass>();
            _dogLeashListNames = new List<string>();
            _catFoodListNames = new List<string>();
        }

        //add products to various dictionaries & lists (including name list hack)
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
            //this is gross, fix
            _productsConst.Add(product);
            _productsNameConst.Add(product.Name);
        }

        //lookup all products
        public List<ProductClass> GetAllProducts()
        {
            return _productsConst;
        }

        //lookup dog leashes by name
        public DogLeashClass GetDogLeashByName(string dogLeashName)
        {
            try
            {
                return _dogLeashDictConst[dogLeashName];
            }
            catch (Exception ex)
            {
                return null;
            }
        }


        //lookup cat food by name
        public CatFoodClass GetCatFoodByName(string catFoodName)
        {
            try
            {
                return _catFoodDictConst[catFoodName];
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        //get count of all products
        public int GetProductCount()
        {
            return _productsConst.Count;
        }

        //get list of all product names (hacked)
        public List<string> GetProductNames()
        {
            return _productsNameConst;
        }

        //get list of cat food names
        public List<string> GetCatProductNames()
        {
            return _catFoodListNames;
        }

        //get list of dog leash names
        public List<string> GetDogProductNames()
        {
            return _dogLeashListNames;
        }

        public List<string> GetOnlyInStockProducts()
        {
            return _productsConst.Where(x => x.Quantity > 0).Select(x => x.Name).ToList();
        }
    }
}