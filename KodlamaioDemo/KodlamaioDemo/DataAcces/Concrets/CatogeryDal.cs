using KodlamaioDemo.DataAcces.Abstracts;
using KodlamaioDemo.Entities.Concrets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioDemo.DataAcces.Concrets
{
    public class CatogeryDal : ICategoryDal
    {
        List<Category> categories;
        public CatogeryDal()
        {
           Category category = new Category();
            category.CategoryName = "Programlama";
            category.Id = 1; 
            categories.Add(category);
        }

        public void Add(Category addCategory)
        {
           categories.Add(addCategory);
            Console.WriteLine("Category added.");
        }

        public Category Read(int categoryId)
        {
            return categories.Find(c => c.Id == categoryId);
        }

        public void Remove(Category removeCategory)
        {
            categories.Remove(removeCategory);
            Console.WriteLine("Category  deleted.");
        }

        public void Update(Category updateCategory)
        {
            Category existingCategory = categories.Find(category=>category.Id==updateCategory.Id);
            if (existingCategory != null) 
            { 
                existingCategory.CategoryName = updateCategory.CategoryName;
                Console.WriteLine("Category updated.");

            }
            else 
            {

                Console.WriteLine("Category not found.");

            }
        }
    }
}
