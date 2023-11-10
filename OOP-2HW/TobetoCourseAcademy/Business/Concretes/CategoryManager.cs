using DataAccess.Concretes;
using Entity.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class CategoryManager
    {
        //AdoNetCategoryDal categoryDal = new AdoNetCategoryDal();
        
        public void Add(Category category)
        {
            Console.WriteLine("categoryDal category eklendi");
        }
    }
}
