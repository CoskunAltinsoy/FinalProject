using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{//Static olduğu için new lwmwye gerek yoktur.
    public static class Messages
    {
        public static  string CategoryLimeteExceed = "Kategori 15'i aştı";
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Bakım zamanı";
        public static string ProductsListed = "Ürünler listelendi";

        public static string ProductCountOfCategoryError = "Sayı aştı";

        public static string ProductNameAlreadyExists = "Bu isimde zaten başka bir ürün var";
    }
}
