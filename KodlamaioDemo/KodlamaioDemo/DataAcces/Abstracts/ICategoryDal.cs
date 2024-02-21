using KodlamaioDemo.Entities.Concrets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioDemo.DataAcces.Abstracts
{
    public interface ICategoryDal
    {
        Category Read(int categoryId);
        void Add(Category addCategory);
        void Remove(Category removeCategory);
        void Update (Category updateCategory);    

    }
}
