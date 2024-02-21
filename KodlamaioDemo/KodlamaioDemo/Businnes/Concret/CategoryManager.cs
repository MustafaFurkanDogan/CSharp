using KodlamaioDemo.Businnes.Abstracrt;
using KodlamaioDemo.Entities.Concrets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioDemo.Businnes.Concret
{
    public class CategoryManager : ICategoryManager
    {
        private ICategoryManager  _categoryManager;
        public CategoryManager(ICategoryManager categoryManager)
        {
            _categoryManager = categoryManager;
        }
        public void Add(Category category)
        {
            Console.WriteLine("Category added.");
        }

        public void Remove(Category category)
        {
            Console.WriteLine("Category was remove.");
        }

        public void Update(Category category)
        {
            Console.WriteLine("Category updated.");
        }
    }
}
